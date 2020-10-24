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

	[Table("conquest_episodes")]
	public partial class ConquestEpisode : BusinessData
	{
		[Column("id"),         PrimaryKey, NotNull] public int    Id         { get; set; } // int(11)
		[Column("identifier"),             NotNull] public string Identifier { get; set; } // varchar(79)

		#region Associations

		/// <summary>
		/// conquest_episode_names_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EpisodeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestEpisodeName> Conquestepisodenamesibfks { get; set; }

		/// <summary>
		/// conquest_episode_warriors_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="EpisodeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestEpisodeWarrior> Conquestepisodewarriorsibfks { get; set; }

		/// <summary>
		/// conquest_warrior_transformation_ibfk_3_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="CurrentEpisodeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestWarriorTransformation> ConquestWarriorTransformationIbfk3BackReferences { get; set; }

		/// <summary>
		/// conquest_warrior_transformation_ibfk_1_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="CompletedEpisodeId", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ConquestWarriorTransformation> Conquestwarriortransformationibfks { get; set; }

		#endregion
	}
}

#pragma warning restore 1591