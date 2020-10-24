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

	[Table("contest_effect_prose")]
	public partial class ContestEffectProse : BusinessData
	{
		[Column("contest_effect_id"), PrimaryKey(1), NotNull] public int    ContestEffectId { get; set; } // int(11)
		[Column("local_language_id"), PrimaryKey(2), NotNull] public int    LocalLanguageId { get; set; } // int(11)
		[Column("flavor_text"),          Nullable           ] public string FlavorText      { get; set; } // text
		[Column("effect"),               Nullable           ] public string Effect          { get; set; } // text

		#region Associations

		/// <summary>
		/// contest_effect_prose_ibfk_1
		/// </summary>
		[Association(ThisKey="ContestEffectId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="contest_effect_prose_ibfk_1", BackReferenceName="Contesteffectproseibfks")]
		public ContestEffect ContestEffect { get; set; }

		/// <summary>
		/// contest_effect_prose_ibfk_2
		/// </summary>
		[Association(ThisKey="LocalLanguageId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="contest_effect_prose_ibfk_2", BackReferenceName="Contesteffectproseibfks")]
		public Language LocalLanguage { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
