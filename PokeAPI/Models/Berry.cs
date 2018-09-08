using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPI.Models {
    public class Berry {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int FirmnessId { get; set; }
        public int NaturalGiftPower { get; set; }
        public int NaturalGiftType { get; set; }
        public int Size { get; set; }
        public int MaxHarvest { get; set; }
        public int GrowthTime { get; set; }
        public int SoilDryness { get; set; }
        public int Smoothness { get; set; }
        public int ContestTypeId { get; set; }
        public int Flavor { get; set; }
    }
}