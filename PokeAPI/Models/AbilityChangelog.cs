using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class AbilityChangelog {
        public int Id { get; set; }
        public VersionGroups ChangedInVersionGroup { get; set; }
        public List<AbilityChangelogProse> AbilityChangelogProse { get; set; }
    }
}