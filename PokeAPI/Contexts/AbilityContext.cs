using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using MySql.Data.MySqlClient;

namespace PokeAPI.Contexts {
    public class AbilityContext {
        public IEnumerable<Ability> All() {
            List<Ability> abilities = new List<Ability>();
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Uid=root;Pwd=compaq;Database=pkmn;CHARSET=utf8;SslMode=none;")) {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
FROM `abilities`
INNER JOIN `ability_names` ON `ability_names`.`ability_id` = `abilities`.`id`
INNER JOIN `ability_prose` ON `ability_prose`.`ability_id` = `abilities`.`id`";
                    command.Prepare();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {
                        Ability ability = new Ability {
                            Id = Utility.Check(reader, "id") ? (int)reader["id"] : 0,
                            Identifier = Utility.Check(reader, "identifier") ? (string)reader["identifier"] : string.Empty,
                            Name = Utility.Check(reader, "name") ? (string)reader["name"] : string.Empty,
                            ShortEffect = Utility.Check(reader, "short_effect") ? (string)reader["short_effect"] : string.Empty,
                            Effect = Utility.Check(reader, "effect") ? (string)reader["effect"] : string.Empty
                        };
                        abilities.Add(ability);
                    }
                } // Command
                connection.Close();
            } // Connection
            return abilities;
        }
    }
}