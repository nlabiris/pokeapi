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

	[Table("pokemon_evolution")]
	public partial class PokemonEvolution : BusinessData
	{
		[Column("id"),                      PrimaryKey,  NotNull] public int    Id                    { get; set; } // int(11)
		[Column("evolved_species_id"),                   NotNull] public int    EvolvedSpeciesId      { get; set; } // int(11)
		[Column("evolution_trigger_id"),                 NotNull] public int    EvolutionTriggerId    { get; set; } // int(11)
		[Column("trigger_item_id"),            Nullable         ] public int?   TriggerItemId         { get; set; } // int(11)
		[Column("minimum_level"),              Nullable         ] public int?   MinimumLevel          { get; set; } // int(11)
		[Column("gender_id"),                  Nullable         ] public int?   GenderId              { get; set; } // int(11)
		[Column("location_id"),                Nullable         ] public int?   LocationId            { get; set; } // int(11)
		[Column("held_item_id"),               Nullable         ] public int?   HeldItemId            { get; set; } // int(11)
		[Column("time_of_day"),                Nullable         ] public string TimeOfDay             { get; set; } // varchar(5)
		[Column("known_move_id"),              Nullable         ] public int?   KnownMoveId           { get; set; } // int(11)
		[Column("known_move_type_id"),         Nullable         ] public int?   KnownMoveTypeId       { get; set; } // int(11)
		[Column("minimum_happiness"),          Nullable         ] public int?   MinimumHappiness      { get; set; } // int(11)
		[Column("minimum_beauty"),             Nullable         ] public int?   MinimumBeauty         { get; set; } // int(11)
		[Column("minimum_affection"),          Nullable         ] public int?   MinimumAffection      { get; set; } // int(11)
		[Column("relative_physical_stats"),    Nullable         ] public int?   RelativePhysicalStats { get; set; } // int(11)
		[Column("party_species_id"),           Nullable         ] public int?   PartySpeciesId        { get; set; } // int(11)
		[Column("party_type_id"),              Nullable         ] public int?   PartyTypeId           { get; set; } // int(11)
		[Column("trade_species_id"),           Nullable         ] public int?   TradeSpeciesId        { get; set; } // int(11)
		[Column("needs_overworld_rain"),                 NotNull] public bool   NeedsOverworldRain    { get; set; } // tinyint(1)
		[Column("turn_upside_down"),                     NotNull] public bool   TurnUpsideDown        { get; set; } // tinyint(1)

		#region Associations

		/// <summary>
		/// pokemon_evolution_ibfk_3
		/// </summary>
		[Association(ThisKey="EvolutionTriggerId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_3", BackReferenceName="Pokemonevolutionibfks")]
		public EvolutionTrigger EvolutionTrigger { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_11
		/// </summary>
		[Association(ThisKey="EvolvedSpeciesId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_11", BackReferenceName="Pokemonevolutionibfks")]
		public PokemonSpecies EvolvedSpecies { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_5
		/// </summary>
		[Association(ThisKey="GenderId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_5", BackReferenceName="Pokemonevolutionibfks")]
		public Gender Gender { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_9
		/// </summary>
		[Association(ThisKey="HeldItemId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_9", BackReferenceName="PokemonEvolutionIbfk9BackReferences")]
		public Item HeldItem { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_7
		/// </summary>
		[Association(ThisKey="KnownMoveId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_7", BackReferenceName="Pokemonevolutionibfks")]
		public Move KnownMove { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_1
		/// </summary>
		[Association(ThisKey="KnownMoveTypeId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_1", BackReferenceName="Pokemonevolutionibfks")]
		public Type KnownMoveType { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_4
		/// </summary>
		[Association(ThisKey="LocationId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_4", BackReferenceName="Pokemonevolutionibfks")]
		public Location Location { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_8
		/// </summary>
		[Association(ThisKey="PartySpeciesId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_8", BackReferenceName="PokemonEvolutionIbfk8BackReferences")]
		public PokemonSpecies PartySpecies { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_10
		/// </summary>
		[Association(ThisKey="PartyTypeId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_10", BackReferenceName="PokemonEvolutionIbfk10BackReferences")]
		public Type PartyType { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_2
		/// </summary>
		[Association(ThisKey="TradeSpeciesId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_2", BackReferenceName="PokemonEvolutionIbfk2BackReferences")]
		public PokemonSpecies TradeSpecies { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_6
		/// </summary>
		[Association(ThisKey="TriggerItemId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="pokemon_evolution_ibfk_6", BackReferenceName="Pokemonevolutionibfks")]
		public Item TriggerItem { get; set; }

		#endregion
	}
}

#pragma warning restore 1591