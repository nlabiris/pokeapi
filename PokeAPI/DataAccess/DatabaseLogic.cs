using System;
using System.Data;

namespace PokeAPI.DataAccess {
    class DatabaseLogic : DataWorker {
        public void LoadData() {
            using (IDbConnection connection = database.CreateOpenConnection()) {
                using (IDbCommand command = database.CreateCommand("SELECT `id` FROM `organization`.`vehicle`", connection)) {
                    using (IDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            Console.WriteLine(reader["id"]);
                        }
                        connection.Dispose();
                    }
                }
            }
        }
    }
}