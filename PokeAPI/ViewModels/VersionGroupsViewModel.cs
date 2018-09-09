using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class VersionGroupsViewModel : DataWorker {
        public VersionGroups RetrieveSpecificVersionGroups(IDbConnection connection, int version_group_id) {
            VersionGroups versionGroups = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificVersionGroup;
                command.Prepare();
                command.AddWithValue("@version_group_id", version_group_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        versionGroups = new VersionGroups {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Generation = new Generation {
                                Id = reader.CheckValue<int>("generation_id")
                            },
                            Order = reader.CheckValue<int>("order")
                        };
                    }
                }
            } // Command
            return versionGroups;
        }
    }
}