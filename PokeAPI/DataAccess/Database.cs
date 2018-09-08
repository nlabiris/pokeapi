using System;
using System.Configuration;
using System.Data;
using PokeAPI.Properties;

namespace PokeAPI.DataAccess {
    internal abstract class Database : IDatabase {
        private static IDbConnection _connection;

        internal static IDbConnection Connection {
            private set {
                _connection = value;
            }
            get {
                return _connection;
            }
        }
        #region Abstract methods

        public abstract IDbConnection CreateConnection();
        public abstract IDbConnection CreateOpenConnection();
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract IDbCommand CreateCommand();
        public abstract IDbCommand CreateCommand(string commandText, IDbConnection connection);
        public abstract IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection);
        public abstract IDataParameter CreateParameter(string parameterName, object parameterValue);
        public abstract void BeginTransaction();
        public abstract void CommitTransaction();
        public abstract void Dispose();

        #endregion
    }   
}