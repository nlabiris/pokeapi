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

	[Table("conquest_warrior_specialties")]
	public partial class ConquestWarriorSpecialty : BusinessData
	{
		[Column("warrior_id"), PrimaryKey(1), NotNull] public int WarriorId { get; set; } // int(11)
		[Column("type_id"),    PrimaryKey(2), NotNull] public int TypeId    { get; set; } // int(11)
		[Column("slot"),       PrimaryKey(3), NotNull] public int Slot      { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// conquest_warrior_specialties_ibfk_2
		/// </summary>
		[Association(ThisKey="TypeId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="conquest_warrior_specialties_ibfk_2", BackReferenceName="Conquestwarriorspecialtiesibfks")]
		public Type Type { get; set; }

		/// <summary>
		/// conquest_warrior_specialties_ibfk_1
		/// </summary>
		[Association(ThisKey="WarriorId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="conquest_warrior_specialties_ibfk_1", BackReferenceName="Conquestwarriorspecialtiesibfks")]
		public ConquestWarrior Warrior { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
