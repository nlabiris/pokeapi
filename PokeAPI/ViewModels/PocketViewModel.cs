using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class PocketViewModel : DataWorker {
        public Pocket RetrieveSpecificPocket(IDbConnection connection, int pocket_id) {
            Pocket pocket = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificPocket;
                command.Prepare();
                command.AddWithValue("@pocket_id", pocket_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        pocket = new Pocket {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier")
                        };
                    }
                }
            } // Command
            return pocket;
        }
    }
}