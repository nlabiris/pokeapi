using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class GenerationViewModel : DataWorker {
        public Generation RetrieveSpecificGeneration(IDbConnection connection, int generations_id) {
            Generation generation = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificGeneration;
                command.Prepare();
                command.AddWithValue("@generations_id", generations_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        generation = new Generation {
                            Id = reader.CheckValue<int>("id"),
                            MainRegion = new Region {
                                Id = reader.CheckValue<int>("main_region_id")
                            },
                            Identifier = reader.CheckObject<string>("identifier")
                        };
                    }
                }
            } // Command
            return generation;
        }
    }
}