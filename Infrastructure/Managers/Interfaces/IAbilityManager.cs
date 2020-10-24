using Infrastructure.Core.Business.Interfaces;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Managers.Interfaces {
    public interface IAbilityManager {
        IBusinessResult<Ability> GetAllAbilities();
    }
}
