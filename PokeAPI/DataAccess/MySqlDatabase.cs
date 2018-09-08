using System;
using System.Configuration;
using System.Data;
using PokeAPI.Properties;
using MySql.Data.MySqlClient;

namespace PokeAPI.DataAccess
{
    internal class MySqlDatabase : Database {
        public override void BeginTransaction() {
            throw new NotImplementedException();
        }

        public override void CloseConnection() {
            throw new NotImplementedException();
        }

        public override void CommitTransaction() {
            throw new NotImplementedException();
        }

        public override IDbCommand CreateCommand() {
            return new MySqlCommand();
        }

        public override IDbCommand CreateCommand(string commandText, IDbConnection connection) {
            return new MySqlCommand(commandText, (MySqlConnection)connection);
        }

        public override IDbConnection CreateConnection() {
            return new MySqlConnection(Settings.Default.DatabaseConnectionString);
        }

        public override IDbConnection CreateOpenConnection() {
            MySqlConnection connection = new MySqlConnection(Settings.Default.DatabaseConnectionString);
            connection.Open();

            return connection;
        }

        public override IDataParameter CreateParameter(string parameterName, object parameterValue) {
            return new MySqlParameter(parameterName, parameterValue);
        }

        public override IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection) {
            throw new NotImplementedException();
        }

        public override void Dispose() {
            throw new NotImplementedException();
        }

        public override void OpenConnection() {
            throw new NotImplementedException();
        }
    }
}