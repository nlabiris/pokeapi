using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.ViewModels;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.Contexts {
    public class AbilityContext : DataWorker {
        private readonly AbilityViewModel VM_Ability = null;
        private readonly GenerationViewModel VM_Generation = null;
        private readonly RegionViewModel VM_Region = null;
        private readonly VersionGroupsViewModel VM_VersionGroups = null;
        private readonly LanguageViewModel VM_Language = null;

        public AbilityContext() {
            if (VM_Ability == null) {
                VM_Ability = new AbilityViewModel();
            }
            if (VM_Generation == null) {
                VM_Generation = new GenerationViewModel();
            }
            if (VM_Region == null) {
                VM_Region = new RegionViewModel();
            }
            if (VM_VersionGroups == null) {
                VM_VersionGroups = new VersionGroupsViewModel();
            }
            if (VM_Language == null) {
                VM_Language = new LanguageViewModel();
            }
        }

        public IEnumerable<Ability> AllAbilities() {
            List<Ability> abilities = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                abilities = VM_Ability.RetrieveAllAbilities(connection);

                foreach (Ability a in abilities) {
                    a.Generation = VM_Generation.RetrieveSpecificGeneration(connection, a.Generation.Id);
                    
                    if (a.Generation != null && a.Generation.MainRegion != null) {
                        a.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, a.Generation.MainRegion.Id);
                    }

                    a.AbilityChangelog = VM_Ability.RetrieveSpecificAbilityChangelog(connection, a.Id);
                    if (a.AbilityChangelog != null && a.AbilityChangelog.ChangedInVersionGroup != null) {
                        a.AbilityChangelog.ChangedInVersionGroup = VM_VersionGroups.RetrieveSpecificVersionGroups(connection, a.AbilityChangelog.ChangedInVersionGroup.Id);
                        a.AbilityChangelog.AbilityChangelogProse = VM_Ability.RetrieveSpecificAbilityChangelogProse(connection, a.AbilityChangelog.Id);
                        a.AbilityChangelog.AbilityChangelogProse.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, a.AbilityChangelog.AbilityChangelogProse.LocalLanguage.Id);

                        if (a.AbilityChangelog.ChangedInVersionGroup.Generation != null) {
                            a.AbilityChangelog.ChangedInVersionGroup.Generation = VM_Generation.RetrieveSpecificGeneration(connection, a.AbilityChangelog.ChangedInVersionGroup.Generation.Id);

                            if (a.AbilityChangelog.ChangedInVersionGroup.Generation.MainRegion != null) {
                                a.AbilityChangelog.ChangedInVersionGroup.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, a.AbilityChangelog.ChangedInVersionGroup.Generation.MainRegion.Id);
                            }
                        }
                    }
                } // foreach
                connection.Close();
            } // Connection
            return abilities;
        }

        public Ability GetAbility(int ability_id) {
            Ability ability = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                using (IDbCommand command = database.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = Query.GetAllAbilities;
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

                if (ability == null) {
                    return ability;
                }

                using (IDbCommand command = database.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = Query.GetSpecificGeneration;
                    command.Prepare();
                    command.AddWithValue("@generations_id", ability.Generation.Id);
                    using (IDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            ability.Generation = new Generation {
                                Id = reader.CheckValue<int>("id"),
                                MainRegion = new Region {
                                    Id = reader.CheckValue<int>("main_region_id")
                                },
                                Identifier = reader.CheckObject<string>("identifier")
                            };
                        }
                    }
                } // Command

                if (ability.Generation.MainRegion != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificRegion;
                        command.Prepare();
                        command.AddWithValue("@regions_id", ability.Generation.MainRegion.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                ability.Generation.MainRegion = new Region {
                                    Id = reader.CheckValue<int>("id"),
                                    Identifier = reader.CheckObject<string>("identifier")
                                };
                            }
                        }
                    } // Command
                }
                connection.Close();
            } // Connection
            return ability;
        }
    } //class
} // namespace