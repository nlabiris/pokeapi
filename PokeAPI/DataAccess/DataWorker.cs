using System;
using System.Configuration;
using System.Reflection;
using PokeAPI.Properties;

namespace PokeAPI.DataAccess {
    public class DataWorker {
        private static IDatabase _database = null;
        static DataWorker() {
            try {
                _database = DatabaseFactory.CreateDatabase();
            } catch (Exception ex) {
                throw ex;
            }
        }

        internal static IDatabase database {
            get { return _database; }
        }
    }
}