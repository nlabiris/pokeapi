using Infrastructure.Core.Business;
using Infrastructure.Core.Business.Data;
using Infrastructure.Core.Business.Interfaces;
using Infrastructure.Core.DataAccess.Interfaces;
using Infrastructure.Logging.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.DataAccess.Repositories {
    public class GenericDatabaseRepository<TBusinessData> : IGenericDatabaseRepository<TBusinessData> where TBusinessData : IBusinessData {
        private readonly IKernel kernel;

        public GenericDatabaseRepository(IKernel kernel) {
            this.kernel = kernel;
        }

        public IBusinessResult<TBusinessData> GetEntityByKey(int id) {
            try {
                IEnumerable<TBusinessData> results = GetSQLRepository<TBusinessData>().GetEntityQueryCollection();
                return CreateSuccess(results == null ? null : results.ToList());
            } catch (Exception ex) {
                return CreateFailWithMessage($"{ex.Message} {ex.InnerException?.Message} {ex.StackTrace}");
            }
        }

        public IBusinessResult<TBusinessData> GetEntityFullList() {
            try {
                IEnumerable<TBusinessData> results = GetSQLRepository<TBusinessData>().GetEntityQueryCollection();
                return CreateSuccess(results == null ? null : results.ToList());
            } catch (Exception ex) {
                return CreateFailWithMessage($"{ex.Message} {ex.InnerException?.Message} {ex.StackTrace}");
            }
        }

        private IBusinessResult<TBusinessData> CreateFailWithMessage(string message) {
            var result = new BusinessResult<TBusinessData>();
            result.BusinessState.BusinessStatus = BusinessStatus.BusinessFailed;
            result.BusinessState.BusinessErrors = new List<BusinessError>() {
                new BusinessError(){
                    BusinessErrorDescription = message
                }
            };
            return result;
        }

        private IBusinessResult<TBusinessData> CreateSuccess(List<TBusinessData> res) {
            var result = new BusinessResult<TBusinessData>();
            result.Data = res;
            result.EntityCount = res.Count();
            return result;
        }

        private ISqlRepository<T> GetSQLRepository<T>() where T : IBusinessData {
            return kernel.Get<ISqlRepository<T>>();
        }
    }
}
