using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class CategoryViewModel : DataWorker {
        public Category RetrieveSpecificCategory(IDbConnection connection, int category_id) {
            Category category = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificCategory;
                command.Prepare();
                command.AddWithValue("@category_id", category_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        category = new Category {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Pocket = new Pocket {
                                Id = reader.CheckValue<int>("pocket_id"),
                            }
                        };
                    }
                }
            } // Command
            return category;
        }
    }
}