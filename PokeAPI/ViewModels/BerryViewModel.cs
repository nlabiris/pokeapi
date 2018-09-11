
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class BerryViewModel : DataWorker {
        public List<Berry> RetrieveAllBerries(IDbConnection connection) {
            List<Berry> berries = new List<Berry>();
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetAllBerries;
                command.Prepare();
                using (IDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Berry berry = new Berry {
                            Id = reader.CheckValue<int>("id"),
                            Item = new Item {
                                Id = reader.CheckValue<int>("item_id")
                            },
                            BerryFirmness = new BerryFirmness {
                                Id = reader.CheckValue<int>("firmness_id")
                            },
                            NaturalGiftPower = reader.CheckValue<int>("natural_gift_power"),
                            NaturalGiftType = new Type {
                                Id = reader.CheckValue<int>("natural_gift_type_id")
                            },
                            Size = reader.CheckValue<int>("size"),
                            MaxHarvest = reader.CheckValue<int>("max_harvest"),
                            GrowthTime = reader.CheckValue<int>("growth_time"),
                            SoilDryness = reader.CheckValue<int>("soil_dryness"),
                            Smoothness = reader.CheckValue<int>("smoothness")
                        };
                        berries.Add(berry);
                    }
                }
            } // Command
            return berries;
        }

        public Berry RetrieveSpecificBerry(IDbConnection connection, int berry_id) {
            Berry berry = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificBerry;
                command.Prepare();
                command.AddWithValue("@berry_id", berry_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        berry = new Berry {
                            Id = reader.CheckValue<int>("id"),
                            Item = new Item {
                                Id = reader.CheckValue<int>("item_id")
                            },
                            BerryFirmness = new BerryFirmness {
                                Id = reader.CheckValue<int>("firmness_id")
                            },
                            NaturalGiftPower = reader.CheckValue<int>("natural_gift_power"),
                            NaturalGiftType = new Type {
                                Id = reader.CheckValue<int>("natural_gift_type_id")
                            },
                            Size = reader.CheckValue<int>("size"),
                            MaxHarvest = reader.CheckValue<int>("max_harvest"),
                            GrowthTime = reader.CheckValue<int>("growth_time"),
                            SoilDryness = reader.CheckValue<int>("soil_dryness"),
                            Smoothness = reader.CheckValue<int>("smoothness")
                        };
                    }
                }
            } // Command
            return berry;
        }

        public BerryFirmness RetrieveSpecificBerryFirmness(IDbConnection connection, int firmness_id) {
            BerryFirmness berryFirmness = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificBerryFirmness;
                command.Prepare();
                command.AddWithValue("@firmness_id", firmness_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        berryFirmness = new BerryFirmness {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier")
                        };
                    }
                }
            } // Command
            return berryFirmness;
        }
    }
}