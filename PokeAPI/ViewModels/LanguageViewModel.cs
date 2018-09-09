using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class LanguageViewModel : DataWorker {
        public Language RetrieveSpecificLanguage(IDbConnection connection, int language_id) {
            Language Language = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificLanguage;
                command.Prepare();
                command.AddWithValue("@language_id", language_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        Language = new Language {
                            Id = reader.CheckValue<int>("id"),
                            Iso639 = reader.CheckObject<string>("iso639"),
                            Iso3166 = reader.CheckObject<string>("iso3166"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            OfficialIndex = reader.CheckValue<bool>("official"),
                            Order = reader.CheckValue<int>("order")
                        };
                    }
                }
            } // Command
            return Language;
        }
    }
}