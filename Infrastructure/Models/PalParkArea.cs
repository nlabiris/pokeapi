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

	[Table("pal_park_areas")]
	public partial class PalParkArea : BusinessData
	{
		[Column("id"),         PrimaryKey, NotNull] public int    Id         { get; set; } // int(11)
		[Column("identifier"),             NotNull] public string Identifier { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// pal_park_area_names_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PalParkAreaId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PalParkAreaName> Palparkareanamesibfks { get; set; }

		/// <summary>
		/// pal_park_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="AreaId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PalPark> Palparkibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
