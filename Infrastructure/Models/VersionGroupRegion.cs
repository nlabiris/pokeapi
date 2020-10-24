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

	[Table("version_group_regions")]
	public partial class VersionGroupRegion : BusinessData
	{
		[Column("version_group_id"), PrimaryKey(1), NotNull] public int VersionGroupId { get; set; } // int(11)
		[Column("region_id"),        PrimaryKey(2), NotNull] public int RegionId       { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// version_group_regions_ibfk_2
		/// </summary>
		[Association(ThisKey="RegionId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="version_group_regions_ibfk_2", BackReferenceName="Versiongroupibfks")]
		public Region Region { get; set; }

		/// <summary>
		/// version_group_regions_ibfk_1
		/// </summary>
		[Association(ThisKey="VersionGroupId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="version_group_regions_ibfk_1", BackReferenceName="Versiongroupregionsibfks")]
		public VersionGroup VersionGroup { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
