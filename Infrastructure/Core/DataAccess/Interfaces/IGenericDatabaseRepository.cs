using Infrastructure.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.DataAccess.Interfaces {
    public interface IGenericDatabaseRepository<TBusinessData> where TBusinessData : IBusinessData {
        IBusinessResult<TBusinessData> GetEntityByKey(int id);
        IBusinessResult<TBusinessData> GetEntityFullList();
    }
}
