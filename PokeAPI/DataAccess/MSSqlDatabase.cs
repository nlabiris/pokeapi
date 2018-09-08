using System;
using System.Configuration;
using System.Data;

namespace PokeAPI.DataAccess {
    internal class MSSqlDatabase: Database
    {
        public override void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public override void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public override void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public override IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public override IDbCommand CreateCommand(string commandText, IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public override IDbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }

        public override IDbConnection CreateOpenConnection()
        {
            throw new NotImplementedException();
        }

        public override IDataParameter CreateParameter(string parameterName, object parameterValue)
        {
            throw new NotImplementedException();
        }

        public override IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}