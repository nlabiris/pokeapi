using Infrastructure.Core.Business.Data;
using Infrastructure.Core.Business.Interfaces;
using Infrastructure.Core.DataAccess.Interfaces;
using Infrastructure.Core.DataAccess.Repositories;
using Infrastructure.Logging;
using Infrastructure.Logging.Interfaces;
using Infrastructure.Managers;
using Infrastructure.Managers.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DependencyInjection {
    public class Bindings : NinjectModule {
        public override void Load() {
            Bind(typeof(IGenericDatabaseRepository<>)).To(typeof(GenericDatabaseRepository<>));
            Bind(typeof(ISqlRepository<>)).To(typeof(SqlRepository<>));
            Bind<ISessionDataStoringManager>().To<SessionDataStoringManager>();
            Bind<ILogger>().To<NLogger>();

            Bind<IBaseManager>().To<BaseManager>();
            Bind<IAbilityManager>().To<AbilityManager>();
        }
    }
}
