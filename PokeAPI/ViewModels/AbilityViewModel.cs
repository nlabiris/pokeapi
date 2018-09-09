using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.ViewModels {
    public class AbilityViewModel : DataWorker {
        public List<Ability> RetrieveAllAbilities(IDbConnection connection) {
            List<Ability> abilities = new List<Ability>();
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetAllAbilities;
                command.Prepare();
                using (IDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Ability ability = new Ability {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Generation = new Generation {
                                Id = reader.CheckValue<int>("generation_id")
                            },
                            IsMainSeries = reader.CheckValue<bool>("is_main_series")
                        };
                        abilities.Add(ability);
                    }
                }
            } // Command
            return abilities;
        }

        public Ability RetrieveSpecificAbility(IDbConnection connection, int ability_id) {
            Ability ability = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificAbility;
                command.Prepare();
                command.AddWithValue("@ability_id", ability_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        ability = new Ability {
                            Id = reader.CheckValue<int>("id"),
                            Identifier = reader.CheckObject<string>("identifier"),
                            Generation = new Generation {
                                Id = reader.CheckValue<int>("generation_id")
                            },
                            IsMainSeries = reader.CheckValue<bool>("is_main_series")
                        };
                    }
                }
            } // Command
            return ability;
        }

        public AbilityChangelog RetrieveSpecificAbilityChangelog(IDbConnection connection, int ability_id) {
            AbilityChangelog abilityChangelog = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificAbilityChangelog;
                command.Prepare();
                command.AddWithValue("@ability_id", ability_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        abilityChangelog = new AbilityChangelog {
                            Id = reader.CheckValue<int>("id"),
                            ChangedInVersionGroup = new VersionGroups {
                                Id = reader.CheckValue<int>("changed_in_version_group_id")
                            }
                        };
                    }
                }
            } // Command
            return abilityChangelog;
        }

        public AbilityChangelogProse RetrieveSpecificAbilityChangelogProse(IDbConnection connection, int ability_changelog_id) {
            AbilityChangelogProse abilityChangelogProse = null;
            using (IDbCommand command = database.CreateCommand()) {
                command.Connection = connection;
                command.CommandText = Query.GetSpecificAbilityChangelogProse;
                command.Prepare();
                command.AddWithValue("@ability_changelog_id", ability_changelog_id);
                using (IDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        abilityChangelogProse = new AbilityChangelogProse {
                            LocalLanguage = new Language {
                                Id = reader.CheckValue<int>("local_language_id")
                            },
                            Effect = reader.CheckObject<string>("effect")
                        };
                    }
                }
            } // Command
            return abilityChangelogProse;
        }
    }
}