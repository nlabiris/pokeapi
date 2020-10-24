using Infrastructure.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Managers.Interfaces {
    public interface IBaseManager {
        IBusinessResult<T> GetEntityByKey<T>(int id) where T : IBusinessData;
        IBusinessResult<T> GetFullEntityList<T>() where T : IBusinessData;
        IBusinessResult<T> GetBusinessDataOrNull<T>(IBusinessResult<T> bcResult, IBusinessResult<T> @default = null) where T : IBusinessData;
    }
}
