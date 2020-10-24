using Infrastructure.Core.Business.Interfaces;
using Infrastructure.Core.DataAccess.Interfaces;
using Infrastructure.Logging.Interfaces;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.DataAccess.Repositories {
    public class SqlRepository<TBusinessObject> : ISqlRepository<TBusinessObject> where TBusinessObject : IBusinessData {
        private readonly ILogger logger;

        public SqlRepository(ILogger logger) {
            this.logger = logger;
        }

        public IEnumerable<TBusinessObject> GetEntityQueryCollection() {
            try {
                using (var dc = new DatabaseContext("db")) {
                    var queyryable = GetIQueryableObjectCollection(dc, typeof(TBusinessObject));
                    var list = queyryable.ToList();
                    return list != null ? list.Select(x => (TBusinessObject)x) : new List<TBusinessObject>();
                }
            } catch (Exception ex) {
                throw;
            }
        }

        public object GetEntityByKey(Type t, object keyValue) {
            return GetEntityQueryCollection().FirstOrDefault();
        }

        #region Private methods

        private IQueryable<object> GetIQueryableObjectCollection(DatabaseContext dal, Type type) {
            try {
                return GetCollectionByType(dal, type);
            } catch (Exception ex) {
                throw;
            }
        }

        private IQueryable<object> GetCollectionByType(DatabaseContext dal, Type type) {
            try {
                var prop = GetCollectionPropertyInfoByType(dal, type);
                return prop.GetGetMethod().Invoke(dal, null) as IQueryable<object>;
            } catch (Exception ex) {
                throw;
            }
        }

        private PropertyInfo GetCollectionPropertyInfoByType(DatabaseContext dal, Type entityType) {
            return (dal.GetType())
                .GetProperties()
                .Where(
                    o => o.PropertyType.IsGenericType && o.PropertyType.GetGenericTypeDefinition() == typeof(ITable<>)
                         && o.PropertyType.GetGenericArguments()[0] == entityType).FirstOrDefault();
        }

        #endregion
    }
}
