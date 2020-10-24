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

	[Table("item_categories")]
	public partial class ItemCategory : BusinessData
	{
		[Column("id"),         PrimaryKey, NotNull] public int    Id         { get; set; } // int(11)
		[Column("pocket_id"),              NotNull] public int    PocketId   { get; set; } // int(11)
		[Column("identifier"),             NotNull] public string Identifier { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// item_category_prose_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="ItemCategoryId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ItemCategoryProse> Itemcategoryproseibfks { get; set; }

		/// <summary>
		/// items_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="CategoryId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Item> Itemsibfks { get; set; }

		/// <summary>
		/// item_categories_ibfk_1
		/// </summary>
		[Association(ThisKey="PocketId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="item_categories_ibfk_1", BackReferenceName="Itemcategoriesibfks")]
		public ItemPocket Pocket { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
