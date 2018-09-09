using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using PokeAPI.DataAccess;

namespace PokeAPI.Contexts {
    public class AbilityContext : DataWorker {
        public IEnumerable<Ability> AllAbilities() {
            List<Ability> abilities = new List<Ability>();
            using (IDbConnection connection = database.CreateOpenConnection()) {
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

                foreach (Ability a in abilities) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificGeneration;
                        command.Prepare();
                        command.AddWithValue("@generations_id", a.Generation.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                a.Generation = new Generation {
                                    Id = reader.CheckValue<int>("id"),
                                    MainRegion = new Region {
                                        Id = reader.CheckValue<int>("main_region_id")
                                    },
                                    Identifier = reader.CheckObject<string>("identifier")
                                };
                            }
                        }
                    } // Command

                    if (a.Generation.MainRegion != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificRegion;
                            command.Prepare();
                            command.AddWithValue("@regions_id", a.Generation.MainRegion.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    a.Generation.MainRegion = new Region {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier")
                                    };
                                }
                            }
                        } // Command
                    }

                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificAbilityChangelog;
                        command.Prepare();
                        command.AddWithValue("@ability_id", a.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                a.AbilityChangelog = new AbilityChangelog {
                                    Id = reader.CheckValue<int>("id"),
                                    ChangedInVersionGroup = new VersionGroups {
                                        Id = reader.CheckValue<int>("changed_in_version_group_id")
                                    }
                                };
                            }
                        }
                    } // Command

                    if (a.AbilityChangelog != null && a.AbilityChangelog.ChangedInVersionGroup != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificVersionGroup;
                            command.Prepare();
                            command.AddWithValue("@version_group_id", a.AbilityChangelog.ChangedInVersionGroup.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    a.AbilityChangelog.ChangedInVersionGroup = new VersionGroups {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier"),
                                        Generation = new Generation {
                                            Id = reader.CheckValue<int>("generation_id")
                                        },
                                        Order = reader.CheckValue<int>("order")
                                    };
                                }
                            }
                        } // Command

                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificAbilityChangelogProse;
                            command.Prepare();
                            command.AddWithValue("@ability_changelog_id", a.AbilityChangelog.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    a.AbilityChangelog.AbilityChangelogProse = new AbilityChangelogProse {
                                        LocalLanguage = new Language {
                                            Id = reader.CheckValue<int>("local_language_id")
                                        },
                                        Effect = reader.CheckObject<string>("effect")
                                    };
                                }
                            }
                        } // Command

                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificLanguage;
                            command.Prepare();
                            command.AddWithValue("@language_id", a.AbilityChangelog.AbilityChangelogProse.LocalLanguage.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    a.AbilityChangelog.AbilityChangelogProse.LocalLanguage = new Language {
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

                        if (a.AbilityChangelog.ChangedInVersionGroup.Generation != null) {
                            using (IDbCommand command = database.CreateCommand()) {
                                command.Connection = connection;
                                command.CommandText = Query.GetSpecificGeneration;
                                command.Prepare();
                                command.AddWithValue("@generations_id", a.AbilityChangelog.ChangedInVersionGroup.Generation.Id);
                                using (IDataReader reader = command.ExecuteReader()) {
                                    if (reader.Read()) {
                                        a.AbilityChangelog.ChangedInVersionGroup.Generation = new Generation {
                                            Id = reader.CheckValue<int>("id"),
                                            MainRegion = new Region {
                                                Id = reader.CheckValue<int>("main_region_id")
                                            },
                                            Identifier = reader.CheckObject<string>("identifier")
                                        };
                                    }
                                }
                            } // Command

                            if (a.AbilityChangelog.ChangedInVersionGroup.Generation.MainRegion != null) {
                                using (IDbCommand command = database.CreateCommand()) {
                                    command.Connection = connection;
                                    command.CommandText = Query.GetSpecificRegion;
                                    command.Prepare();
                                    command.AddWithValue("@regions_id", a.AbilityChangelog.ChangedInVersionGroup.Generation.MainRegion.Id);
                                    using (IDataReader reader = command.ExecuteReader()) {
                                        if (reader.Read()) {
                                            a.AbilityChangelog.ChangedInVersionGroup.Generation.MainRegion = new Region {
                                                Id = reader.CheckValue<int>("id"),
                                                Identifier = reader.CheckObject<string>("identifier")
                                            };
                                        }
                                    }
                                } // Command
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
    }
}