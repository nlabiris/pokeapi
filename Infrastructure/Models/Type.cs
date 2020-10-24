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

	[Table("types")]
	public partial class Type : BusinessData
	{
		[Column("id"),              PrimaryKey,  NotNull] public int    Id            { get; set; } // int(11)
		[Column("identifier"),                   NotNull] public string Identifier    { get; set; } // varchar(79)
		[Column("generation_id"),                NotNull] public int    GenerationId  { get; set; } // int(11)
		[Column("damage_class_id"),    Nullable         ] public int?   DamageClassId { get; set; } // int(11)
		[Column("image"),              Nullable         ] public byte[] Image         { get; set; } // blob
		[Column("color"),                        NotNull] public string Color         { get; set; } // varchar(10)

		#region Associations

		/// <summary>
		/// berries_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="NaturalGiftTypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Berry> Berriesibfks { get; set; }

		/// <summary>
		/// conquest_kingdoms_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestKingdom> Conquestkingdomsibfks { get; set; }

		/// <summary>
		/// conquest_warrior_specialties_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestWarriorSpecialty> Conquestwarriorspecialtiesibfks { get; set; }

		/// <summary>
		/// conquest_warrior_transformation_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="CollectionTypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestWarriorTransformation> Conquestwarriortransformationibfks { get; set; }

		/// <summary>
		/// types_ibfk_2
		/// </summary>
		[Association(ThisKey="DamageClassId", OtherKey="Id", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="types_ibfk_2", BackReferenceName="Typesibfks")]
		public MoveDamageClass DamageClass { get; set; }

		/// <summary>
		/// types_ibfk_1
		/// </summary>
		[Association(ThisKey="GenerationId", OtherKey="Id", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="types_ibfk_1", BackReferenceName="Typesibfks")]
		public Generation Generation { get; set; }

		/// <summary>
		/// move_changelog_ibfk_4_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<MoveChangelog> Movechangelogibfks { get; set; }

		/// <summary>
		/// moves_ibfk_6_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Move> Movesibfks { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_10_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="PartyTypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonEvolution> PokemonEvolutionIbfk10BackReferences { get; set; }

		/// <summary>
		/// pokemon_evolution_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="KnownMoveTypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonEvolution> Pokemonevolutionibfks { get; set; }

		/// <summary>
		/// pokemon_types_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<PokemonType> Pokemonibfks { get; set; }

		/// <summary>
		/// type_efficacy_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="DamageTypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<TypeEfficacy> TypeEfficacyIbfk2BackReferences { get; set; }

		/// <summary>
		/// type_efficacy_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TargetTypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<TypeEfficacy> Typeefficacyibfks { get; set; }

		/// <summary>
		/// type_game_indices_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<TypeGameIndex> Typegameindicesibfks { get; set; }

		/// <summary>
		/// type_names_ibfk_2_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="TypeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<TypeName> Typenamesibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591
