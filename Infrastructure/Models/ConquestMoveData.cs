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

	[Table("conquest_move_data")]
	public partial class ConquestMoveData : BusinessData
	{
		[Column("move_id"),         PrimaryKey,  NotNull] public int  MoveId         { get; set; } // int(11)
		[Column("power"),              Nullable         ] public int? Power          { get; set; } // int(11)
		[Column("accuracy"),           Nullable         ] public int? Accuracy       { get; set; } // int(11)
		[Column("effect_chance"),      Nullable         ] public int? EffectChance   { get; set; } // int(11)
		[Column("effect_id"),                    NotNull] public int  EffectId       { get; set; } // int(11)
		[Column("range_id"),                     NotNull] public int  RangeId        { get; set; } // int(11)
		[Column("displacement_id"),    Nullable         ] public int? DisplacementId { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// conquest_move_data_ibfk_3
		/// </summary>
		[Association(ThisKey="DisplacementId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="conquest_move_data_ibfk_3", BackReferenceName="Conquestmovedataibfks")]
		public ConquestMoveDisplacement Displacement { get; set; }

		/// <summary>
		/// conquest_move_data_ibfk_2
		/// </summary>
		[Association(ThisKey="EffectId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="conquest_move_data_ibfk_2", BackReferenceName="Conquestmovedataibfks")]
		public ConquestMoveEffect Effect { get; set; }

		/// <summary>
		/// conquest_move_data_ibfk_1
		/// </summary>
		[Association(ThisKey="MoveId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="conquest_move_data_ibfk_1", BackReferenceName="Conquestmovedataibfk")]
		public Move Move { get; set; }

		/// <summary>
		/// conquest_move_data_ibfk_4
		/// </summary>
		[Association(ThisKey="RangeId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="conquest_move_data_ibfk_4", BackReferenceName="Conquestmovedataibfks")]
		public ConquestMoveRange Range { get; set; }

		#endregion
	}
}

#pragma warning restore 1591