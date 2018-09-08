using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class Species {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Generation Generation { get; set; }
        public int EvolvesFromSpecies { get; set; }
        public EvolutionChain EvolutionChain { get; set; }
        public Color Color { get; set; }
        public Shape Shape { get; set; }
        public Habitat Habitat { get; set; }
        public int GenderRate { get; set; }
        public int CaptureRate { get; set; }
        public int BaseHappiness { get; set; }
        public bool IsBaby { get; set; }
        public int HatchCounter { get; set; }
        public bool HasGenderDifferences { get; set; }
        public GrowthRate GrowthRate { get; set; }
        public bool FormsSwitchable { get; set; }
        public int Order { get; set; }
        public int ConquestOrder { get; set; }
    }
}