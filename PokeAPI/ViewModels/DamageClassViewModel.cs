using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class DamageClassViewModel : DataWorker {
        public DamageClass RetrieveSpecificDamageClass(IDbConnection connection, int damage_class_id) {
            DamageClass damageClass = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificDamageClass;
                command.Prepare();
                command.AddWithValue("@damage_class_id", damage_class_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        damageClass = new DamageClass {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier")
                        };
                    }
                }
            } // Command
            return damageClass;
        }
    }
}