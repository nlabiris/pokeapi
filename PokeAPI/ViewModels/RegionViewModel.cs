using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class RegionViewModel : DataWorker {
        public Region RetrieveSpecificRegion(IDbConnection connection, int regions_id) {
            Region region = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificRegion;
                command.Prepare();
                command.AddWithValue("@regions_id", regions_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        region = new Region {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier")
                        };
                    }
                }
            } // Command
            return region;
        }
    }
}