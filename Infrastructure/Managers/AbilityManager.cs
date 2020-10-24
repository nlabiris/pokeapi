using Infrastructure.Core.Business.Interfaces;
using Infrastructure.Managers.Interfaces;
using Infrastructure.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Managers {
    public class AbilityManager : BaseManager, IAbilityManager {
        public AbilityManager(IKernel kernel) : base(kernel) {
        }

        public IBusinessResult<Ability> GetAllAbilities() {
            return GetFullEntityList<Ability>();
        }
    }
}
