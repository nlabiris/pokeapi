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

	[Table("language_names")]
	public partial class LanguageName : BusinessData
	{
		[Column("language_id"),       PrimaryKey(1), NotNull] public int    LanguageId      { get; set; } // int(11)
		[Column("local_language_id"), PrimaryKey(2), NotNull] public int    LocalLanguageId { get; set; } // int(11)
		[Column("name"),                             NotNull] public string Name            { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// language_names_ibfk_1
		/// </summary>
		[Association(ThisKey="LanguageId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="language_names_ibfk_1", BackReferenceName="Languagenamesibfks")]
		public Language Language { get; set; }

		/// <summary>
		/// language_names_ibfk_2
		/// </summary>
		[Association(ThisKey="LocalLanguageId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="language_names_ibfk_2", BackReferenceName="LanguageNamesIbfk2BackReferences")]
		public Language LocalLanguage { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
