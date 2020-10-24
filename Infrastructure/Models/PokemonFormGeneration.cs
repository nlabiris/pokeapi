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

	[Table("pokemon_form_generations")]
	public partial class PokemonFormGeneration : BusinessData
	{
		[Column("pokemon_form_id"), PrimaryKey(1), NotNull] public int PokemonFormId { get; set; } // int(11)
		[Column("generation_id"),   PrimaryKey(2), NotNull] public int GenerationId  { get; set; } // int(11)
		[Column("game_index"),                     NotNull] public int GameIndex     { get; set; } // int(11)

		#region Associations

		/// <summary>
		/// pokemon_form_generations_ibfk_2
		/// </summary>
		[Association(ThisKey="GenerationId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_form_generations_ibfk_2", BackReferenceName="Pokemonformibfks")]
		public Generation Generation { get; set; }

		/// <summary>
		/// pokemon_form_generations_ibfk_1
		/// </summary>
		[Association(ThisKey="PokemonFormId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_form_generations_ibfk_1", BackReferenceName="Pokemonformgenerationsibfks")]
		public PokemonForm PokemonForm { get; set; }

		#endregion
	}
}

#pragma warning restore 1591