
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class TypeViewModel : DataWorker {
        public List<Type> RetrieveAllType(IDbConnection connection) {
            List<Type> types = new List<Type>();
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetAllTypes;
                command.Prepare();
                using (IDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Type type = new Type {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Generation = new Generation {
                                Id = reader.CheckValue<int>("generation_id"),
                            },
                            MoveDamageClass = new MoveDamageClass {
                                Id = reader.CheckValue<int>("damage_class_id"),
                            }
                        };
                        types.Add(type);
                    }
                }
            } // Command
            return types;
        }

        public Type RetrieveSpecificType(IDbConnection connection, int type_id) {
            Type type = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificType;
                command.Prepare();
                command.AddWithValue("@type_id", type_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        type = new Type {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Generation = new Generation {
                                Id = reader.CheckValue<int>("generation_id"),
                            },
                            MoveDamageClass = new MoveDamageClass {
                                Id = reader.CheckValue<int>("damage_class_id"),
                            }
                        };
                    }
                }
            } // Command
            return type;
        }
    }
}