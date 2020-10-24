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

	[Table("move_effects")]
	public partial class MoveEffect : BusinessData
	{
		[Column("id"), PrimaryKey, NotNull] public int Id { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// move_changelog_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EffectId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<MoveChangelog> Movechangelogibfks { get; set; }

		/// <summary>
		/// move_effect_changelog_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EffectId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<MoveEffectChangelog> Moveeffectchangelogibfks { get; set; }

		/// <summary>
		/// move_effect_prose_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="MoveEffectId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<MoveEffectProse> Moveeffectproseibfks { get; set; }

		/// <summary>
		/// moves_ibfk_5_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EffectId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Move> Movesibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591