using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PokeAPI.Models;
using PokeAPI.Helper;
using MySql.Data.MySqlClient;
using PokeAPI.DataAccess;

namespace PokeAPI.Contexts {
    public class PokemonContext : DataWorker {
        public IEnumerable<Pokemon> AllPokemon() {
            List<Pokemon> pokemons = new List<Pokemon>();
            using (IDbConnection connection = database.CreateOpenConnection()) {
                using (IDbCommand command = database.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = Query.GetAllPokemon;
                    command.Prepare();
                    using (IDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            Pokemon pokemon = new Pokemon {
                                Id = reader.CheckValue<int>("id"),
                                Identifier = reader.CheckObject<string>("identifier"),
                                Species = new Species {
                                    Id = reader.CheckValue<int>("species_id"),
                                },
                                Height = reader.CheckValue<int>("height"),
                                Weight = reader.CheckValue<int>("weight"),
                                BaseExperience = reader.CheckValue<int>("base_experience"),
                                Order = reader.CheckValue<int>("order"),
                                IsDefault = reader.CheckValue<bool>("is_default"),
                            };
                            pokemons.Add(pokemon);
                        }
                    }
                } // Command

                foreach (Pokemon p in pokemons) {
                    if (p.Species != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificSpecies;
                            command.Prepare();
                            command.AddWithValue("@species_id", p.Species.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species = new Species {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier"),
                                        Generation = new Generation {
                                            Id = reader.CheckValue<int>("generation_id")
                                        },
                                        EvolvesFromSpecies = reader.CheckValue<int>("evolves_from_species_id"),
                                        EvolutionChain = new EvolutionChain {
                                            Id = reader.CheckValue<int>("evolution_chain_id")
                                        },
                                        Color = new Color {
                                            Id = reader.CheckValue<int>("color_id")
                                        },
                                        Shape = new Shape {
                                            Id = reader.CheckValue<int>("shape_id")
                                        },
                                        Habitat = new Habitat {
                                            Id = reader.CheckValue<int>("habitat_id")
                                        },
                                        GenderRate = reader.CheckValue<int>("gender_rate"),
                                        CaptureRate = reader.CheckValue<int>("capture_rate"),
                                        BaseHappiness = reader.CheckValue<int>("base_happiness"),
                                        IsBaby = reader.CheckValue<bool>("is_baby"),
                                        HatchCounter = reader.CheckValue<int>("hatch_counter"),
                                        HasGenderDifferences = reader.CheckValue<bool>("has_gender_differences"),
                                        GrowthRate = new GrowthRate {
                                            Id = reader.CheckValue<int>("growth_rate_id")
                                        },
                                        FormsSwitchable = reader.CheckValue<bool>("forms_switchable"),
                                        Order = reader.CheckValue<int>("order"),
                                        ConquestOrder = reader.CheckValue<int>("conquest_order")
                                    };
                                }
                            }
                        } // Command
                    }

                    if (p.Species.Generation != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificGeneration;
                            command.Prepare();
                            command.AddWithValue("@generations_id", p.Species.Generation.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species.Generation = new Generation {
                                        Id = reader.CheckValue<int>("id"),
                                        MainRegion = new Region {
                                            Id = reader.CheckValue<int>("main_region_id")
                                        },
                                        Identifier = reader.CheckObject<string>("identifier")
                                    };
                                }
                            }
                        } // Command
                        
                        if (p.Species.Generation.MainRegion != null) {
                            using (IDbCommand command = database.CreateCommand()) {
                                command.Connection = connection;
                                command.CommandText = Query.GetSpecificRegion;
                                command.Prepare();
                                command.AddWithValue("@regions_id", p.Species.Generation.MainRegion.Id);
                                using (IDataReader reader = command.ExecuteReader()) {
                                    if (reader.Read()) {
                                        p.Species.Generation.MainRegion = new Region {
                                            Id = reader.CheckValue<int>("id"),
                                            Identifier = reader.CheckObject<string>("identifier")
                                        };
                                    }
                                }
                            } // Command
                        }
                    }


                    if (p.Species.Color != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificColor;
                            command.Prepare();
                            command.AddWithValue("@color_id", p.Species.Color.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species.Color = new Color {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier")
                                    };
                                }
                            }
                        } // Command
                    }

                    if (p.Species.Shape != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificShape;
                            command.Prepare();
                            command.AddWithValue("@shape_id", p.Species.Shape.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species.Shape = new Shape {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier")
                                    };
                                }
                            }
                        } // Command
                    }

                    if (p.Species.Habitat != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificHabitat;
                            command.Prepare();
                            command.AddWithValue("@habitat_id", p.Species.Habitat.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species.Habitat = new Habitat {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier")
                                    };
                                }
                            }
                        } // Command
                    }

                    if (p.Species.GrowthRate != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificGrowthRate;
                            command.Prepare();
                            command.AddWithValue("@growth_rate_id", p.Species.GrowthRate.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species.GrowthRate = new GrowthRate {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier"),
                                        Formula = reader.CheckObject<string>("formula")
                                    };
                                }
                            }
                        } // Command
                    }

                    if (p.Species.EvolutionChain != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificEvolutionChain;
                            command.Prepare();
                            command.AddWithValue("@evolution_chains_id", p.Species.EvolutionChain.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    p.Species.EvolutionChain = new EvolutionChain {
                                        Id = reader.CheckValue<int>("id"),
                                        BabyTriggerItem = new Item {
                                            Id = reader.CheckValue<int>("baby_trigger_item_id")
                                        }
                                    };
                                }
                            }
                        } // Command

                        if (p.Species.EvolutionChain.BabyTriggerItem != null) {
                            using (IDbCommand command = database.CreateCommand()) {
                                command.Connection = connection;
                                command.CommandText = Query.GetSpecificBabyTriggerItem;
                                command.Prepare();
                                command.AddWithValue("@baby_trigger_item_id", p.Species.EvolutionChain.BabyTriggerItem.Id);
                                using (IDataReader reader = command.ExecuteReader()) {
                                    if (reader.Read()) {
                                        p.Species.EvolutionChain.BabyTriggerItem = new Item {
                                            Id = reader.CheckValue<int>("id"),
                                            Identifier = reader.CheckObject<string>("identifier"),
                                            Category = new Category {
                                                Id = reader.CheckValue<int>("category_id")
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

                            if (p.Species.EvolutionChain.BabyTriggerItem.Category != null) {
                                using (IDbCommand command = database.CreateCommand()) {
                                    command.Connection = connection;
                                    command.CommandText = Query.GetSpecificCategory;
                                    command.Prepare();
                                    command.AddWithValue("@category_id", p.Species.EvolutionChain.BabyTriggerItem.Category.Id);                                    using (IDataReader reader = command.ExecuteReader()) {
                                        if (reader.Read()) {
                                            p.Species.EvolutionChain.BabyTriggerItem.Category = new Category {
                                                Id = reader.CheckValue<int>("id"),
                                                Pocket = new Pocket {
                                                    Id = reader.CheckValue<int>("id")
                                                },
                                                Identifier = reader.CheckObject<string>("identifier")
                                            };
                                        }
                                    }
                                } // Command

                                if (p.Species.EvolutionChain.BabyTriggerItem.Category.Pocket != null) {
                                    using (IDbCommand command = database.CreateCommand()) {
                                        command.Connection = connection;
                                        command.CommandText = Query.GetSpecificPocket;
                                        command.Prepare();
                                        command.AddWithValue("@pocket_id", p.Species.EvolutionChain.BabyTriggerItem.Category.Pocket.Id);
                                        using (IDataReader reader = command.ExecuteReader()) {
                                            if (reader.Read()) {
                                                p.Species.EvolutionChain.BabyTriggerItem.Category.Pocket = new Pocket {
                                                    Id = reader.CheckValue<int>("id"),
                                                    Identifier = reader.CheckObject<string>("identifier")
                                                };
                                            }
                                        }
                                    } // Command
                                }
                            }

                            if (p.Species.EvolutionChain.BabyTriggerItem.FlingEffect != null) {
                                using (IDbCommand command = database.CreateCommand()) {
                                    command.Connection = connection;
                                    command.CommandText = Query.GetSpecificFlingEffect;
                                    command.Prepare();
                                    command.AddWithValue("@fling_effect_id", p.Species.EvolutionChain.BabyTriggerItem.FlingEffect.Id);
                                    using (IDataReader reader = command.ExecuteReader()) {
                                        if (reader.Read()) {
                                            p.Species.EvolutionChain.BabyTriggerItem.FlingEffect = new FlingEffects {
                                                Id = reader.CheckValue<int>("id")
                                            };
                                        }
                                    }
                                } // Command
                            }
                        }
                    }
                }
                connection.Close();
            } // Connection
            return pokemons;
        }

        public Pokemon GetPokemon(int pokemon_id) {
            Pokemon pokemon = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                using (IDbCommand command = database.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = Query.GetSpecificPokemon;
                    command.Prepare();
                    command.AddWithValue("@pokemon_id", pokemon_id);
                    using (IDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            pokemon = new Pokemon {
                                Id = reader.CheckValue<int>("id"),
                                Identifier = reader.CheckObject<string>("identifier"),
                                Species = new Species {
                                    Id = reader.CheckValue<int>("species_id"),
                                },
                                Height = reader.CheckValue<int>("height"),
                                Weight = reader.CheckValue<int>("weight"),
                                BaseExperience = reader.CheckValue<int>("base_experience"),
                                Order = reader.CheckValue<int>("order"),
                                IsDefault = reader.CheckValue<bool>("is_default"),
                            };
                        }
                    }
                } // Command

                if (pokemon == null) {
                    return pokemon;
                }

                if (pokemon.Species != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificSpecies;
                        command.Prepare();
                        command.AddWithValue("@species_id", pokemon.Species.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species = new Species {
                                    Id = reader.CheckValue<int>("id"),
                                    Identifier = reader.CheckObject<string>("identifier"),
                                    Generation = new Generation {
                                        Id = reader.CheckValue<int>("generation_id")
                                    },
                                    EvolvesFromSpecies = reader.CheckValue<int>("evolves_from_species_id"),
                                    EvolutionChain = new EvolutionChain {
                                        Id = reader.CheckValue<int>("evolution_chain_id")
                                    },
                                    Color = new Color {
                                        Id = reader.CheckValue<int>("color_id")
                                    },
                                    Shape = new Shape {
                                        Id = reader.CheckValue<int>("shape_id")
                                    },
                                    Habitat = new Habitat {
                                        Id = reader.CheckValue<int>("habitat_id")
                                    },
                                    GenderRate = reader.CheckValue<int>("gender_rate"),
                                    CaptureRate = reader.CheckValue<int>("capture_rate"),
                                    BaseHappiness = reader.CheckValue<int>("base_happiness"),
                                    IsBaby = reader.CheckValue<bool>("is_baby"),
                                    HatchCounter = reader.CheckValue<int>("hatch_counter"),
                                    HasGenderDifferences = reader.CheckValue<bool>("has_gender_differences"),
                                    GrowthRate = new GrowthRate {
                                        Id = reader.CheckValue<int>("growth_rate_id")
                                    },
                                    FormsSwitchable = reader.CheckValue<bool>("forms_switchable"),
                                    Order = reader.CheckValue<int>("order"),
                                    ConquestOrder = reader.CheckValue<int>("conquest_order")
                                };
                            }
                        }
                    } // Command
                }

                if (pokemon.Species.Generation != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificGeneration;
                        command.Prepare();
                        command.AddWithValue("@generations_id", pokemon.Species.Generation.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species.Generation = new Generation {
                                    Id = reader.CheckValue<int>("id"),
                                    MainRegion = new Region {
                                        Id = reader.CheckValue<int>("main_region_id")
                                    },
                                    Identifier = reader.CheckObject<string>("identifier")
                                };
                            }
                        }
                    } // Command
                    
                    if (pokemon.Species.Generation.MainRegion != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificRegion;
                            command.Prepare();
                            command.AddWithValue("@regions_id", pokemon.Species.Generation.MainRegion.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    pokemon.Species.Generation.MainRegion = new Region {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier")
                                    };
                                }
                            }
                        } // Command
                    }
                }

                if (pokemon.Species.Color != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificColor;
                        command.Prepare();
                        command.AddWithValue("@color_id", pokemon.Species.Color.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species.Color = new Color {
                                    Id = reader.CheckValue<int>("id"),
                                    Identifier = reader.CheckObject<string>("identifier")
                                };
                            }
                        }
                    } // Command
                }

                if (pokemon.Species.Shape != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificShape;
                        command.Prepare();
                        command.AddWithValue("@shape_id", pokemon.Species.Shape.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species.Shape = new Shape {
                                    Id = reader.CheckValue<int>("id"),
                                    Identifier = reader.CheckObject<string>("identifier")
                                };
                            }
                        }
                    } // Command
                }

                if (pokemon.Species.Habitat != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificHabitat;
                        command.Prepare();
                        command.AddWithValue("@habitat_id", pokemon.Species.Habitat.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species.Habitat = new Habitat {
                                    Id = reader.CheckValue<int>("id"),
                                    Identifier = reader.CheckObject<string>("identifier")
                                };
                            }
                        }
                    } // Command
                }

                if (pokemon.Species.GrowthRate != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificGrowthRate;
                        command.Prepare();
                        command.AddWithValue("@growth_rate_id", pokemon.Species.GrowthRate.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species.GrowthRate = new GrowthRate {
                                    Id = reader.CheckValue<int>("id"),
                                    Identifier = reader.CheckObject<string>("identifier"),
                                    Formula = reader.CheckObject<string>("formula")
                                };
                            }
                        }
                    } // Command
                }

                if (pokemon.Species.EvolutionChain != null) {
                    using (IDbCommand command = database.CreateCommand()) {
                        command.Connection = connection;
                        command.CommandText = Query.GetSpecificEvolutionChain;
                        command.Prepare();
                        command.AddWithValue("@evolution_chains_id", pokemon.Species.EvolutionChain.Id);
                        using (IDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                pokemon.Species.EvolutionChain = new EvolutionChain {
                                    Id = reader.CheckValue<int>("id"),
                                    BabyTriggerItem = new Item {
                                        Id = reader.CheckValue<int>("baby_trigger_item_id")
                                    }
                                };
                            }
                        }
                    } // Command

                    if (pokemon.Species.EvolutionChain.BabyTriggerItem != null) {
                        using (IDbCommand command = database.CreateCommand()) {
                            command.Connection = connection;
                            command.CommandText = Query.GetSpecificBabyTriggerItem;
                            command.Prepare();
                            command.AddWithValue("@baby_trigger_item_id", pokemon.Species.EvolutionChain.BabyTriggerItem.Id);
                            using (IDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    pokemon.Species.EvolutionChain.BabyTriggerItem = new Item {
                                        Id = reader.CheckValue<int>("id"),
                                        Identifier = reader.CheckObject<string>("identifier"),
                                        Category = new Category {
                                            Id = reader.CheckValue<int>("category_id")
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

                        if (pokemon.Species.EvolutionChain.BabyTriggerItem.Category != null) {
                            using (IDbCommand command = database.CreateCommand()) {
                                command.Connection = connection;
                                command.CommandText = Query.GetSpecificCategory;
                                command.Prepare();
                                command.AddWithValue("@category_id", pokemon.Species.EvolutionChain.BabyTriggerItem.Category.Id);                                    using (IDataReader reader = command.ExecuteReader()) {
                                    if (reader.Read()) {
                                        pokemon.Species.EvolutionChain.BabyTriggerItem.Category = new Category {
                                            Id = reader.CheckValue<int>("id"),
                                            Pocket = new Pocket {
                                                Id = reader.CheckValue<int>("id")
                                            },
                                            Identifier = reader.CheckObject<string>("identifier")
                                        };
                                    }
                                }
                            } // Command

                            if (pokemon.Species.EvolutionChain.BabyTriggerItem.Category.Pocket != null) {
                                using (IDbCommand command = database.CreateCommand()) {
                                    command.Connection = connection;
                                    command.CommandText = Query.GetSpecificPocket;
                                    command.Prepare();
                                    command.AddWithValue("@pocket_id", pokemon.Species.EvolutionChain.BabyTriggerItem.Category.Pocket.Id);
                                    using (IDataReader reader = command.ExecuteReader()) {
                                        if (reader.Read()) {
                                            pokemon.Species.EvolutionChain.BabyTriggerItem.Category.Pocket = new Pocket {
                                                Id = reader.CheckValue<int>("id"),
                                                Identifier = reader.CheckObject<string>("identifier")
                                            };
                                        }
                                    }
                                } // Command
                            }
                        }

                        if (pokemon.Species.EvolutionChain.BabyTriggerItem.FlingEffect != null) {
                            using (IDbCommand command = database.CreateCommand()) {
                                command.Connection = connection;
                                command.CommandText = Query.GetSpecificFlingEffect;
                                command.Prepare();
                                command.AddWithValue("@fling_effect_id", pokemon.Species.EvolutionChain.BabyTriggerItem.FlingEffect.Id);
                                using (IDataReader reader = command.ExecuteReader()) {
                                    if (reader.Read()) {
                                        pokemon.Species.EvolutionChain.BabyTriggerItem.FlingEffect = new FlingEffects {
                                            Id = reader.CheckValue<int>("id")
                                        };
                                    }
                                }
                            } // Command
                        }
                    }
                }
                connection.Close();
            } // Connection
            return pokemon;
        }
    }
}