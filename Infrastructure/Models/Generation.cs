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

	[Table("generations")]
	public partial class Generation : BusinessData
	{
		[Column("id"),             PrimaryKey, NotNull] public int    Id           { get; set; } // int(11)
		[Column("main_region_id"),             NotNull] public int    MainRegionId { get; set; } // int(11)
		[Column("identifier"),                 NotNull] public string Identifier   { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// abilities_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Ability> Abilitiesibfks { get; set; }

		/// <summary>
		/// generation_names_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<GenerationName> Generationnamesibfks { get; set; }

		/// <summary>
		/// item_game_indices_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ItemGameIndex> Itemgameindicesibfks { get; set; }

		/// <summary>
		/// location_game_indices_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<LocationGameIndex> Locationgameindicesibfks { get; set; }

		/// <summary>
		/// generations_ibfk_1
		/// </summary>
		[Association(ThisKey="MainRegionId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="generations_ibfk_1", BackReferenceName="Generationsibfks")]
		public Region MainRegion { get; set; }

		/// <summary>
		/// moves_ibfk_7_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Move> Movesibfks { get; set; }

		/// <summary>
		/// pokemon_form_generations_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonFormGeneration> Pokemonformibfks { get; set; }

		/// <summary>
		/// pokemon_species_ibfk_5_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonSpecies> Pokemonspeciesibfks { get; set; }

		/// <summary>
		/// type_game_indices_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<TypeGameIndex> Typegameindicesibfks { get; set; }

		/// <summary>
		/// types_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Type> Typesibfks { get; set; }

		/// <summary>
		/// version_groups_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="GenerationId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<VersionGroup> Versiongroupsibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
