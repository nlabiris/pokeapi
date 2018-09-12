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
    public class BerryContext : DataWorker {
        private readonly BerryViewModel VM_Berry = null;
        private readonly ItemViewModel VM_Item = null;
        private readonly TypeViewModel VM_Type = null;
        private readonly CategoryViewModel VM_Category = null;
        private readonly PocketViewModel VM_Pocket = null;
        private readonly GenerationViewModel VM_Generation = null;
        private readonly RegionViewModel VM_Region = null;
        private readonly DamageClassViewModel VM_DamageClass = null;
        private readonly LanguageViewModel VM_Language = null;
        private readonly ContestTypeViewModel VM_ContestType = null;

        public BerryContext() {
            if (VM_Berry == null) {
                VM_Berry = new BerryViewModel();
            }
            if (VM_Item == null) {
                VM_Item = new ItemViewModel();
            }
            if (VM_Type == null) {
                VM_Type = new TypeViewModel();
            }
            if (VM_Category == null) {
                VM_Category = new CategoryViewModel();
            }
            if (VM_Pocket == null) {
                VM_Pocket = new PocketViewModel();
            }
            if (VM_Generation == null) {
                VM_Generation = new GenerationViewModel();
            }
            if (VM_Region == null) {
                VM_Region = new RegionViewModel();
            }
            if (VM_DamageClass == null) {
                VM_DamageClass = new DamageClassViewModel();
            }
            if (VM_Language == null) {
                VM_Language = new LanguageViewModel();
            }
            if (VM_ContestType == null) {
                VM_ContestType = new ContestTypeViewModel();
            }
        }

        public IEnumerable<Berry> AllBerries() {
            List<Berry> berries = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                berries = VM_Berry.RetrieveAllBerries(connection);

                foreach (Berry b in berries) {
                    b.Item = VM_Item.RetrieveSpecificItem(connection, b.Item.Id);
                    if (b.Item != null && b.Item.Category != null) {
                        b.Item.Category = VM_Category.RetrieveSpecificCategory(connection, b.Item.Category.Id);
                        if (b.Item.Category != null && b.Item.Category.Pocket != null) {
                            b.Item.Category.Pocket = VM_Pocket.RetrieveSpecificPocket(connection, b.Item.Category.Pocket.Id);
                        }
                    }
                    b.BerryFirmness = VM_Berry.RetrieveSpecificBerryFirmness(connection, b.BerryFirmness.Id);
                    if (b.BerryFirmness != null) {
                        b.BerryFirmness.BerryFirmnessName = VM_Berry.RetrieveSpecificBerryFirmnessName(connection, b.BerryFirmness.Id);
                        foreach (BerryFirmnessName bfn in b.BerryFirmness.BerryFirmnessName) {
                            bfn.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, bfn.LocalLanguage.Id);
                        }
                    }
                    b.NaturalGiftType = VM_Type.RetrieveSpecificType(connection, b.NaturalGiftType.Id);
                    if (b.NaturalGiftType != null && b.NaturalGiftType.DamageClass != null) {
                        b.NaturalGiftType.Generation = VM_Generation.RetrieveSpecificGeneration(connection, b.NaturalGiftType.Generation.Id);
                        if (b.NaturalGiftType.Generation != null && b.NaturalGiftType.Generation.MainRegion != null) {
                            b.NaturalGiftType.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, b.NaturalGiftType.Generation.MainRegion.Id);
                        }
                        b.NaturalGiftType.DamageClass = VM_DamageClass.RetrieveSpecificDamageClass(connection, b.NaturalGiftType.DamageClass.Id);
                    }
                    b.BerryFlavors = VM_Berry.RetrieveSpecificBerryFlavor(connection, b.Id);
                    foreach (BerryFlavor bf in b.BerryFlavors) {
                        bf.ContestType = VM_ContestType.RetrieveSpecificContestType(connection, bf.ContestType.Id);
                    }
                }
                connection.Close();
            } // Connection
            return berries;
        }

        public Berry GetBerry(int berry_id) {
            Berry berry = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                berry = VM_Berry.RetrieveSpecificBerry(connection, berry_id);

                if (berry == null) {
                    return berry;
                }

                berry.Item = VM_Item.RetrieveSpecificItem(connection, berry.Item.Id);
                if (berry.Item != null && berry.Item.Category != null) {
                    berry.Item.Category = VM_Category.RetrieveSpecificCategory(connection, berry.Item.Category.Id);
                    if (berry.Item.Category != null && berry.Item.Category.Pocket != null) {
                        berry.Item.Category.Pocket = VM_Pocket.RetrieveSpecificPocket(connection, berry.Item.Category.Pocket.Id);
                    }
                }
                berry.BerryFirmness = VM_Berry.RetrieveSpecificBerryFirmness(connection, berry.BerryFirmness.Id);
                if (berry.BerryFirmness != null) {
                    berry.BerryFirmness.BerryFirmnessName = VM_Berry.RetrieveSpecificBerryFirmnessName(connection, berry.BerryFirmness.Id);
                    foreach (BerryFirmnessName bfn in berry.BerryFirmness.BerryFirmnessName) {
                        bfn.LocalLanguage = VM_Language.RetrieveSpecificLanguage(connection, bfn.LocalLanguage.Id);
                    }
                }
                berry.NaturalGiftType = VM_Type.RetrieveSpecificType(connection, berry.NaturalGiftType.Id);
                if (berry.NaturalGiftType != null && berry.NaturalGiftType.DamageClass != null) {
                    berry.NaturalGiftType.Generation = VM_Generation.RetrieveSpecificGeneration(connection, berry.NaturalGiftType.Generation.Id);
                    if (berry.NaturalGiftType.Generation != null && berry.NaturalGiftType.Generation.MainRegion != null) {
                        berry.NaturalGiftType.Generation.MainRegion = VM_Region.RetrieveSpecificRegion(connection, berry.NaturalGiftType.Generation.MainRegion.Id);
                    }
                    berry.NaturalGiftType.DamageClass = VM_DamageClass.RetrieveSpecificDamageClass(connection, berry.NaturalGiftType.DamageClass.Id);
                }
                berry.BerryFlavors = VM_Berry.RetrieveSpecificBerryFlavor(connection, berry_id);
                foreach (BerryFlavor bf in berry.BerryFlavors) {
                    bf.ContestType = VM_ContestType.RetrieveSpecificContestType(connection, bf.ContestType.Id);
                }
                connection.Close();
            } // Connection
            return berry;
        }
    } //class
} // namespace