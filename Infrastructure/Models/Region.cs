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

	[Table("regions")]
	public partial class Region : BusinessData
	{
		[Column("id"),         PrimaryKey, NotNull] public int    Id         { get; set; } // int(11)
		[Column("identifier"),             NotNull] public string Identifier { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// generations_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="MainRegionId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Generation> Generationsibfks { get; set; }

		/// <summary>
		/// locations_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="RegionId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Location> Locationsibfks { get; set; }

		/// <summary>
		/// pokedexes_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="RegionId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Pokedex> Pokedexesibfks { get; set; }

		/// <summary>
		/// region_names_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="RegionId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<RegionName> Regionnamesibfks { get; set; }

		/// <summary>
		/// version_group_regions_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="RegionId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<VersionGroupRegion> Versiongroupibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
