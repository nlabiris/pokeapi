using System;
using System.Configuration;

namespace PokeAPI.Helper {
    public static class AppConfig {
        /// <summary>
        /// Gets the database provider.
        /// </summary>
        /// <returns></returns>
        public static string GetDatabaseProvider() {
            try {
                return ConfigurationManager.AppSettings["provider"] ?? string.Empty;
            } catch (ConfigurationErrorsException) {
                Console.WriteLine("Error reading app settings");
                throw;
            }
        }

        /// <summary>
        /// Gets the database connection string.
        /// </summary>
        /// <returns></returns>
        public static string GetDatabaseConnectionString() {
            try {
                return ConfigurationManager.AppSettings["connectionString"] ?? string.Empty;
            } catch (ConfigurationErrorsException) {
                Console.WriteLine("Error reading app settings");
                throw;
            }
        }
    }
}