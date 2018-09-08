using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class Generation {
        public int Id { get; set; }
        public Region MainRegion { get; set; }
        public string Identifier { get; set; }
    }
}