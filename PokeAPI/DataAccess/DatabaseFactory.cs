using System;
using System.Configuration;
using System.Reflection;
using PokeAPI.Properties;

namespace PokeAPI.DataAccess {
    internal sealed class DatabaseFactory {
        internal static IDatabase CreateDatabase() {
            string db = DatabaseConfiguration.GetDatabaseNamespace();
            try {
                // Find the class
                Type database = Type.GetType(db);
                // Get it's constructor
                ConstructorInfo constructor = database.GetConstructor(new Type[] { });
                // Invoke it's constructor, which returns an instance.
                Database createdObject = (Database)constructor.Invoke(null);
                // Initialize the connection string property for the database.
                DatabaseConfiguration.ConnectionString = Settings.Default.DatabaseConnectionString;
                // Pass back the instance as a Database
                return createdObject;
            } catch (Exception ex) {
                throw new Exception("Error instantiating database: " + db + ". " + ex.Message);
            }
        }
    }   
}