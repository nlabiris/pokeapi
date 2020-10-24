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

	[Table("move_meta_stat_changes")]
	public partial class MoveMetaStatChange : BusinessData
	{
		[Column("move_id"), PrimaryKey(1), NotNull] public int MoveId { get; set; } // int(11)
		[Column("stat_id"), PrimaryKey(2), NotNull] public int StatId { get; set; } // int(11)
		[Column("change"),                 NotNull] public int Change { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// move_meta_stat_changes_ibfk_2
		/// </summary>
		[Association(ThisKey="MoveId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="move_meta_stat_changes_ibfk_2", BackReferenceName="Movemetastatchangesibfks")]
		public Move Move { get; set; }

		/// <summary>
		/// move_meta_stat_changes_ibfk_1
		/// </summary>
		[Association(ThisKey="StatId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="move_meta_stat_changes_ibfk_1", BackReferenceName="Movemetastatchangesibfks")]
		public Stat Stat { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
