using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class ItemViewModel : DataWorker {
        public Item RetrieveSpecificItem(IDbConnection connection, int item_id) {
            Item item = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificItem;
                command.Prepare();
                command.AddWithValue("@item_id", item_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        item = new Item {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Category = new Category {
                                Id = reader.CheckValue<int>("category_id"),
                            },
                            Cost = reader.CheckValue<int>("cost"),
                            FlingPower = reader.CheckValue<int>("fling_power"),
                            FlingEffect = new FlingEffects {
                                Id = reader.CheckValue<int>("fling_effect_id")
                            }
                        };
                    }
                }
            } // Command
            return item;
        }
    }
}