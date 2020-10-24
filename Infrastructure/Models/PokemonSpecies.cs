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

	[Table("pokemon_species")]
	public partial class PokemonSpecies : BusinessData
	{
		[Column("id"),                      PrimaryKey,  NotNull] public int    Id                   { get; set; } // int(11)
		[Column("identifier"),                           NotNull] public string Identifier           { get; set; } // varchar(79)
		[Column("generation_id"),              Nullable         ] public int?   GenerationId         { get; set; } // int(11)
		[Column("evolves_from_species_id"),    Nullable         ] public int?   EvolvesFromSpeciesId { get; set; } // int(11)
		[Column("evolution_chain_id"),         Nullable         ] public int?   EvolutionChainId     { get; set; } // int(11)
		[Column("color_id"),                             NotNull] public int    ColorId              { get; set; } // int(11)
		[Column("shape_id"),                             NotNull] public int    ShapeId              { get; set; } // int(11)
		[Column("habitat_id"),                 Nullable         ] public int?   HabitatId            { get; set; } // int(11)
		[Column("gender_rate"),                          NotNull] public int    GenderRate           { get; set; } // int(11)
		[Column("capture_rate"),                         NotNull] public int    CaptureRate          { get; set; } // int(11)
		[Column("base_happiness"),                       NotNull] public int    BaseHappiness        { get; set; } // int(11)
		[Column("is_baby"),                              NotNull] public bool   IsBaby               { get; set; } // tinyint(1)
		[Column("hatch_counter"),                        NotNull] public int    HatchCounter         { get; set; } // int(11)
		[Column("has_gender_differences"),               NotNull] public bool   HasGenderDifferences { get; set; } // tinyint(1)
		[Column("growth_rate_id"),                       NotNull] public int    GrowthRateId         { get; set; } // int(11)
		[Column("forms_switchable"),                     NotNull] public bool   FormsSwitchable      { get; set; } // tinyint(1)
		[Column("order"),                                NotNull] public int    Order                { get; set; } // int(11)
		[Column("conquest_order"),             Nullable         ] public int?   ConquestOrder        { get; set; } // int(11)
		[Column("footprint"),                  Nullable         ] public byte[] Footprint            { get; set; } // blob

		#region Associations

		/// <summary>
		/// pokemon_species_ibfk_3
		/// </summary>
		[Association(ThisKey="ColorId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_species_ibfk_3", BackReferenceName="Pokemonspeciesibfks")]
		public PokemonColor Color { get; set; }

		/// <summary>
		/// conquest_max_links_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestMaxLink> Conquestmaxlinksibfks { get; set; }

		/// <summary>
		/// conquest_pokemon_abilities_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestPokemonAbility> Conquestpokemonabilitiesibfks { get; set; }

		/// <summary>
		/// conquest_pokemon_evolution_ibfk_4_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EvolvedSpeciesId", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public ConquestPokemonEvolution Conquestpokemonevolutionibfk { get; set; }

		/// <summary>
		/// conquest_pokemon_moves_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public ConquestPokemonMove Conquestpokemonmovesibfk { get; set; }

		/// <summary>
		/// conquest_pokemon_stats_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestPokemonStat> Conquestpokemonstatsibfks { get; set; }

		/// <summary>
		/// conquest_transformation_pokemon_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestTransformationPokemon> Conquesttransformationpokemonibfks { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_1
		/// </summary>
		[Association(ThisKey="EvolutionChainId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_species_ibfk_1", BackReferenceName="Pokemonspeciesibfks")]
		public EvolutionChain EvolutionChain { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_5
		/// </summary>
		[Association(ThisKey="GenerationId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_species_ibfk_5", BackReferenceName="Pokemonspeciesibfks")]
		public Generation Generation { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_7
		/// </summary>
		[Association(ThisKey="GrowthRateId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_species_ibfk_7", BackReferenceName="Pokemonspeciesibfks")]
		public GrowthRate GrowthRate { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_6
		/// </summary>
		[Association(ThisKey="HabitatId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_species_ibfk_6", BackReferenceName="Pokemonspeciesibfks")]
		public PokemonHabitat Habitat { get; set; }

		/// <summary>
		/// pal_park_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SpeciesId", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public PalPark Palparkibfk { get; set; }

		/// <summary>
		/// pokemon_dex_numbers_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonDexNumber> Pokemondexnumbersibfks { get; set; }

		/// <summary>
		/// pokemon_egg_groups_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonEggGroup> Pokemonegggroupsibfks { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TradeSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonEvolution> PokemonEvolutionIbfk2BackReferences { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_8_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PartySpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonEvolution> PokemonEvolutionIbfk8BackReferences { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_11_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EvolvedSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonEvolution> Pokemonevolutionibfks { get; set; }

		/// <summary>
		/// pokemon_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Pokemon> Pokemonibfks { get; set; }

		/// <summary>
		/// pokemon_species_flavor_summaries_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonSpeciesFlavorSummary> Pokemonspeciesflavorsummariesibfks { get; set; }

		/// <summary>
		/// pokemon_species_flavor_text_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonSpeciesFlavorText> Pokemonspeciesflavortextibfks { get; set; }

		/// <summary>
		/// pokemon_species_names_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonSpeciesName> Pokemonspeciesnamesibfks { get; set; }

		/// <summary>
		/// pokemon_species_prose_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PokemonSpeciesId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonSpeciesProse> Pokemonspeciesproseibfks { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_4
		/// </summary>
		[Association(ThisKey="ShapeId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_species_ibfk_4", BackReferenceName="Pokemonspeciesibfks")]
		public PokemonShape Shape { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
