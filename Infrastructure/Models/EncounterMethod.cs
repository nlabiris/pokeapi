//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    With additional support for multiple files.
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591

namespace Infrastructure.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Infrastructure.Core.Business.Data;

	using LinqToDB;
	using LinqToDB.Mapping;

	[Table("encounter_methods")]
	public partial class EncounterMethod : BusinessData
	{
		[Column("id"),         PrimaryKey, NotNull] public int    Id         { get; set; } // int(11)
		[Column("identifier"),             NotNull] public string Identifier { get; set; } // varchar(79)
		[Column("order"),                  NotNull] public int    Order      { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// encounter_method_prose_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EncounterMethodId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<EncounterMethodProse> Encountermethodproseibfks { get; set; }

		/// <summary>
		/// encounter_slots_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EncounterMethodId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<EncounterSlot> Encounterslotsibfks { get; set; }

		/// <summary>
		/// location_area_encounter_rates_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EncounterMethodId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<LocationAreaEncounterRate> Locationareaencounterratesibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
