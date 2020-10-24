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

	[Table("conquest_pokemon_abilities")]
	public partial class ConquestPokemonAbility : BusinessData
	{
		[Column("pokemon_species_id"), PrimaryKey(1), NotNull] public int PokemonSpeciesId { get; set; } // int(11)
		[Column("slot"),               PrimaryKey(2), NotNull] public int Slot             { get; set; } // int(11)
		[Column("ability_id"),                        NotNull] public int AbilityId        { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// conquest_pokemon_abilities_ibfk_2
		/// </summary>
		[Association(ThisKey="AbilityId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="conquest_pokemon_abilities_ibfk_2", BackReferenceName="Conquestpokemonibfks")]
		public Ability Ability { get; set; }

		/// <summary>
		/// conquest_pokemon_abilities_ibfk_1
		/// </summary>
		[Association(ThisKey="PokemonSpeciesId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="conquest_pokemon_abilities_ibfk_1", BackReferenceName="Conquestpokemonabilitiesibfks")]
		public PokemonSpecies PokemonSpecies { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
