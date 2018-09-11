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
        }

        public IEnumerable<Berry> AllBerries() {
            List<Berry> berries = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                berries = VM_Berry.RetrieveAllBerries(connection);

                foreach (Berry b in berries) {
                    b.Item = VM_Item.RetrieveSpecificItem(connection, b.Item.Id);
                    b.BerryFirmness = VM_Berry.RetrieveSpecificBerryFirmness(connection, b.BerryFirmness.Id);
                    b.NaturalGiftType = VM_Type.RetrieveSpecificType(connection, b.NaturalGiftType.Id);
                }
                connection.Close();
            } // Connection
            return berries;
        }

        public Berry GetBerry(int berry_id) {
            Berry berry = null;
            using (IDbConnection connection = database.CreateOpenConnection()) {
                berry = VM_Berry.RetrieveSpecificBerry(connection, berry_id);

                berry.Item = VM_Item.RetrieveSpecificItem(connection, berry.Item.Id);
                berry.BerryFirmness = VM_Berry.RetrieveSpecificBerryFirmness(connection, berry.BerryFirmness.Id);
                berry.NaturalGiftType = VM_Type.RetrieveSpecificType(connection, berry.NaturalGiftType.Id);
                connection.Close();
            } // Connection
            return berry;
        }
    } //class
} // namespace