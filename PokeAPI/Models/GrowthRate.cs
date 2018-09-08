using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class GrowthRate {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Formula { get; set; }
    }
}