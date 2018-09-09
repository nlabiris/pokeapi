using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class VersionGroups {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Generation Generation { get; set; }
        public int Order { get; set; }
    }
}