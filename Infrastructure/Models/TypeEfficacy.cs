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

	[Table("type_efficacy")]
	public partial class TypeEfficacy : BusinessData
	{
		[Column("damage_type_id"), PrimaryKey(1), NotNull] public int DamageTypeId { get; set; } // int(11)
		[Column("target_type_id"), PrimaryKey(2), NotNull] public int TargetTypeId { get; set; } // int(11)
		[Column("damage_factor"),                 NotNull] public int DamageFactor { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// type_efficacy_ibfk_2
		/// </summary>
		[Association(ThisKey="DamageTypeId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="type_efficacy_ibfk_2", BackReferenceName="TypeEfficacyIbfk2BackReferences")]
		public Type DamageType { get; set; }

		/// <summary>
		/// type_efficacy_ibfk_1
		/// </summary>
		[Association(ThisKey="TargetTypeId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="type_efficacy_ibfk_1", BackReferenceName="Typeefficacyibfks")]
		public Type TargetType { get; set; }

		#endregion
	}
}

#pragma warning restore 1591