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

	[Table("conquest_move_ranges")]
	public partial class ConquestMoveRange : BusinessData
	{
		[Column("id"),         PrimaryKey, NotNull] public int    Id         { get; set; } // int(11)
		[Column("identifier"),             NotNull] public string Identifier { get; set; } // varchar(79)
		[Column("targets"),                NotNull] public int    Targets    { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// conquest_move_data_ibfk_4_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="RangeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestMoveData> Conquestmovedataibfks { get; set; }

		/// <summary>
		/// conquest_move_range_prose_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="ConquestMoveRangeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestMoveRangeProse> Conquestmoverangeproseibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591