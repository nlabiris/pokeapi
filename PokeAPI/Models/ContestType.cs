using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class ContestType {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string Color { get; set; }
    }
}