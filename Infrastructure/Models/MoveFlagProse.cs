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

	[Table("move_flag_prose")]
	public partial class MoveFlagProse : BusinessData
	{
		[Column("move_flag_id"),      PrimaryKey(1), NotNull] public int    MoveFlagId      { get; set; } // int(11)
		[Column("local_language_id"), PrimaryKey(2), NotNull] public int    LocalLanguageId { get; set; } // int(11)
		[Column("name"),                 Nullable           ] public string Name            { get; set; } // varchar(79)
		[Column("description"),          Nullable           ] public string Description     { get; set; } // text

		#region Associations

		/// <summary>
		/// move_flag_prose_ibfk_1
		/// </summary>
		[Association(ThisKey="LocalLanguageId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="move_flag_prose_ibfk_1", BackReferenceName="Moveflagproseibfks")]
		public Language LocalLanguage { get; set; }

		/// <summary>
		/// move_flag_prose_ibfk_2
		/// </summary>
		[Association(ThisKey="MoveFlagId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="move_flag_prose_ibfk_2", BackReferenceName="Moveflagproseibfks")]
		public MoveFlag MoveFlag { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
