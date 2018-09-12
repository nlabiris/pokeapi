using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class ContestTypeViewModel : DataWorker {
        public ContestType RetrieveSpecificContestType(IDbConnection connection, int contest_type_id) {
            ContestType contestType = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificContestType;
                command.Prepare();
                command.AddWithValue("@contest_type_id", contest_type_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        contestType = new ContestType {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier")
                        };
                    }
                }
            } // Command
            return contestType;
        }
    }
}