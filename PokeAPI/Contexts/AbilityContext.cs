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
                    foreach (AbilityChangelog ac in a.AbilityChangelog) {
                        if (ac != null && ac.ChangedInVersionGroup != null) {
                            ac.ChangedInVersionGroup = VM_VersionGroups.RetrieveSpecificVersionGroups(connection, ac.ChangedInVersionGroup.Id);
                            ac.AbilityChangelogProse = VM_Ability.RetrieveSpecificAbilityChangelogProse(connection, ac.Id);
                            foreach (AbilityChangelogProse acp in ac.AbilityChangelogProse) {
                                acp.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, acp.LocalLanguage.Id);
                            }

                            if (ac.ChangedInVersionGroup.Generation != null) {
                                ac.ChangedInVersionGroup.Generation = VM_Generation.RetrieveSpecificGeneration(connection, ac.ChangedInVersionGroup.Generation.Id);

                                if (ac.ChangedInVersionGroup.Generation.MainRegion != null) {
                                    ac.ChangedInVersionGroup.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, ac.ChangedInVersionGroup.Generation.MainRegion.Id);
                                }
                            }
                        }
                    }

                    a.AbilityName = VM_Ability.RetrieveSpecificAbilityName(connection, a.Id);
                    foreach (AbilityName an in a.AbilityName) {
                        if (an != null && an.LocalLanguage != null) {
                            an.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, an.LocalLanguage.Id);
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
                ability = VM_Ability.RetrieveSpecificAbility(connection, ability_id);
                if (ability == null) {
                    return ability;
                }
                ability.Generation = VM_Generation.RetrieveSpecificGeneration(connection, ability.Generation.Id);
                    
                if (ability.Generation != null && ability.Generation.MainRegion != null) {
                    ability.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, ability.Generation.MainRegion.Id);
                }

                ability.AbilityChangelog = VM_Ability.RetrieveSpecificAbilityChangelog(connection, ability.Id);
                foreach (AbilityChangelog ac in ability.AbilityChangelog) {
                    if (ac != null && ac.ChangedInVersionGroup != null) {
                        ac.ChangedInVersionGroup = VM_VersionGroups.RetrieveSpecificVersionGroups(connection, ac.ChangedInVersionGroup.Id);
                        ac.AbilityChangelogProse = VM_Ability.RetrieveSpecificAbilityChangelogProse(connection, ac.Id);
                        foreach (AbilityChangelogProse acp in ac.AbilityChangelogProse) {
                            acp.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, acp.LocalLanguage.Id);
                        }

                        if (ac.ChangedInVersionGroup.Generation != null) {
                            ac.ChangedInVersionGroup.Generation = VM_Generation.RetrieveSpecificGeneration(connection, ac.ChangedInVersionGroup.Generation.Id);

                            if (ac.ChangedInVersionGroup.Generation.MainRegion != null) {
                                ac.ChangedInVersionGroup.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, ac.ChangedInVersionGroup.Generation.MainRegion.Id);
                            }
                        }
                    }
                }

                ability.AbilityName = VM_Ability.RetrieveSpecificAbilityName(connection, ability_id);
                foreach (AbilityName an in ability.AbilityName) {
                    if (an != null && an.LocalLanguage != null) {
                        an.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, an.LocalLanguage.Id);
                    }
                }
                connection.Close();
            } // Connection
            return ability;
        }
    } //class
} // namespace