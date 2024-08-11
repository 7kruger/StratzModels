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
    public partial class TopPlayersByHeroTypeQueryBuilder : GraphQlQueryBuilder<TopPlayersByHeroTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(PlayerLeaderBoardByHeroTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "TopPlayersByHeroType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public TopPlayersByHeroTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public TopPlayersByHeroTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public TopPlayersByHeroTypeQueryBuilder WithPlayers(PlayerLeaderBoardByHeroTypeQueryBuilder playerLeaderBoardByHeroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("players", alias, playerLeaderBoardByHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public TopPlayersByHeroTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }
    }
}
