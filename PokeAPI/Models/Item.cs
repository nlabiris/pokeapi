using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class Item {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Category Category { get; set; }
        public int Cost { get; set; }
        public int FlingPower { get; set; }
        public FlingEffects FlingEffect { get; set; }
    }
}