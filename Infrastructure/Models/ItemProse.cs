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

	[Table("item_prose")]
	public partial class ItemProse : BusinessData
	{
		[Column("item_id"),           PrimaryKey(1), NotNull] public int    ItemId          { get; set; } // int(11)
		[Column("local_language_id"), PrimaryKey(2), NotNull] public int    LocalLanguageId { get; set; } // int(11)
		[Column("short_effect"),         Nullable           ] public string ShortEffect     { get; set; } // text
		[Column("effect"),               Nullable           ] public string Effect          { get; set; } // text

		#region Associations

		/// <summary>
		/// item_prose_ibfk_2
		/// </summary>
		[Association(ThisKey="ItemId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="item_prose_ibfk_2", BackReferenceName="Itemproseibfks")]
		public Item Item { get; set; }

		/// <summary>
		/// item_prose_ibfk_1
		/// </summary>
		[Association(ThisKey="LocalLanguageId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="item_prose_ibfk_1", BackReferenceName="Itemproseibfks")]
		public Language LocalLanguage { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
