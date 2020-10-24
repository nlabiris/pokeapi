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

	[Table("pokemon_habitats")]
	public partial class PokemonHabitat : BusinessData
	{
		[Column("id"),         PrimaryKey,  NotNull] public int    Id         { get; set; } // int(11)
		[Column("identifier"),              NotNull] public string Identifier { get; set; } // varchar(79)
		[Column("image"),         Nullable         ] public byte[] Image      { get; set; } // blob

		#region Associations

		/// <summary>
		/// pokemon_habitat_names_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonHabitatId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonHabitatName> Pokemonhabitatnamesibfks { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_6_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="HabitatId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonSpecies> Pokemonspeciesibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
