// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class PlayerCoachingLeaderboardResponseTypeQueryBuilder : GraphQlQueryBuilder<PlayerCoachingLeaderboardResponseTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(PlayerCoachingLeaderboardTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "levels", IsComplex = true }
            };

        protected override string TypeName { get { return "PlayerCoachingLeaderboardResponseType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerCoachingLeaderboardResponseTypeQueryBuilder WithPlayers(PlayerCoachingLeaderboardTypeQueryBuilder playerCoachingLeaderboardTypeQueryBuilder, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            return WithObjectField("players", alias, playerCoachingLeaderboardTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public PlayerCoachingLeaderboardResponseTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }

        public PlayerCoachingLeaderboardResponseTypeQueryBuilder WithLevels(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("levels", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCoachingLeaderboardResponseTypeQueryBuilder ExceptLevels()
        {
            return ExceptField("levels");
        }
    }
}
