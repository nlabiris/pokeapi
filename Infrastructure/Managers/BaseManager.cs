using Infrastructure.Core.Business;
using Infrastructure.Core.Business.Data;
using Infrastructure.Core.Business.Interfaces;
using Infrastructure.Core.DataAccess;
using Infrastructure.Core.DataAccess.Interfaces;
using Infrastructure.Managers.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Managers {
    public class BaseManager : IBaseManager {
        public IKernel Kernel { get; set; }
        private readonly ISessionDataStoringManager sessionErrorHandler;

        public BaseManager(IKernel kernel) {
            this.sessionErrorHandler = kernel.Get<ISessionDataStoringManager>();
            this.Kernel = kernel;
        }

        public IBusinessResult<T> GetFullEntityList<T>() where T : IBusinessData {
            try {
                var repositoryInstance = Kernel.Get<IGenericDatabaseRepository<T>>();
                var res = repositoryInstance.GetEntityFullList();
                return repositoryInstance == null ? null : GetBusinessDataOrNull(res, new BusinessResult<T>());
            } catch (Exception ex) {
                SetErrors(new List<BusinessError>
                {
                    new BusinessError
                    {
                        BusinessErrorDescription = ex.Message,
                        BusinessErrorCode = BusinessErrorCode.InternalError
                    }
                });
                return null;
            }
        }

        public IBusinessResult<T> GetEntityByKey<T>(int id) where T : IBusinessData {
            try {
                var repositoryInstance = Kernel.Get<IGenericDatabaseRepository<T>>();
                var res = repositoryInstance.GetEntityByKey(id);
                return repositoryInstance == null ? null : GetBusinessDataOrNull(res, new BusinessResult<T>());
            } catch (Exception ex) {
                SetErrors(new List<BusinessError>
                {
                    new BusinessError
                    {
                        BusinessErrorDescription = ex.Message,
                        BusinessErrorCode = BusinessErrorCode.InternalError
                    }
                });
                return null;
            }
        }

        public IBusinessResult<T> GetBusinessDataOrNull<T>(IBusinessResult<T> bcResult, IBusinessResult<T> @default = null) where T : IBusinessData {
            if (
                bcResult.BusinessState.BusinessStatus == BusinessStatus.BusinessOk ||
                (bcResult.BusinessState.BusinessStatus == BusinessStatus.BusinessOkWithWarnings && !bcResult.Data.Any())
            ) {
                return bcResult;
            }
            SetErrors(bcResult.BusinessState.BusinessErrors);
            return @default;
        }

        public virtual void SetErrors(IList<BusinessError> errors) {
            foreach (var error in errors) {
                sessionErrorHandler.SetError(error);
            }
        }

        public virtual void SetError(BusinessError error) {
            sessionErrorHandler.SetError(error);
        }
    }
}
