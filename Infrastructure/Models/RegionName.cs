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

	[Table("region_names")]
	public partial class RegionName : BusinessData
	{
		[Column("region_id"),         PrimaryKey(1), NotNull] public int    RegionId        { get; set; } // int(11)
		[Column("local_language_id"), PrimaryKey(2), NotNull] public int    LocalLanguageId { get; set; } // int(11)
		[Column("name"),                             NotNull] public string Name            { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// region_names_ibfk_2
		/// </summary>
		[Association(ThisKey="LocalLanguageId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="region_names_ibfk_2", BackReferenceName="Regionnamesibfks")]
		public Language LocalLanguage { get; set; }

		/// <summary>
		/// region_names_ibfk_1
		/// </summary>
		[Association(ThisKey="RegionId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="region_names_ibfk_1", BackReferenceName="Regionnamesibfks")]
		public Region Region { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
