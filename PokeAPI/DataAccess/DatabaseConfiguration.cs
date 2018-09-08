using System;
using System.Configuration;
using System.Reflection;
using PokeAPI.Properties;

namespace PokeAPI.DataAccess {
    internal static class DatabaseConfiguration {
        private static string connectionString;

        internal static string ConnectionString {
            get {
                return connectionString;
            }
            set {
                connectionString = value;
            }
        }

        /// <summary>
        /// Retrieve the namespace from the database type provided in settings.
        /// </summary>
        /// <returns>Database namespace</returns>
        internal static string GetDatabaseNamespace() {
            if (Settings.Default.DatabaseUsed.ToLower() == "mysql")
                return "PokeAPI.DataAccess.MySqlDatabase";
            else if (Settings.Default.DatabaseUsed.ToLower() == "mssql")
                return "PokeAPI.DataAccess.MSSqlDatabase";
            else
                return "PokeAPI.DataAccess.PostgreSqlDatabase";
        }

        /// <summary>
        /// Creates a new database access from the database type provided in settings.
        /// </summary>
        /// <returns>Database object</returns>
        internal static IDatabase GetDatabaseObject() {
            if (Settings.Default.DatabaseUsed.ToLower() == "mysql")
                return new MySqlDatabase();
            else if (Settings.Default.DatabaseUsed.ToLower() == "mssql")
                return new MSSqlDatabase();
            else
                return new PostgreSqlDatabase();
        }
    }   
}