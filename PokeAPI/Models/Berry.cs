using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class Berry {
        public int Id { get; set; }
        public Item Item { get; set; }
        public BerryFirmness BerryFirmness { get; set; }
        public int NaturalGiftPower { get; set; }
        public Type NaturalGiftType { get; set; }
        public int Size { get; set; }
        public int MaxHarvest { get; set; }
        public int GrowthTime { get; set; }
        public int SoilDryness { get; set; }
        public int Smoothness { get; set; }
    }
}