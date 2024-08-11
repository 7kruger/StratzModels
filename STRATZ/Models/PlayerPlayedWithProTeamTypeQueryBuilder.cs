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
    public partial class PlayerPlayedWithProTeamTypeQueryBuilder : GraphQlQueryBuilder<PlayerPlayedWithProTeamTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "teamId" },
                new GraphQlFieldMetadata { Name = "teamLogo" },
                new GraphQlFieldMetadata { Name = "teamName" },
                new GraphQlFieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(PlayerPlayedWithProPlayerTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "PlayerPlayedWithProTeamType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerPlayedWithProTeamTypeQueryBuilder WithTeamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamId", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder ExceptTeamId()
        {
            return ExceptField("teamId");
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder WithTeamLogo(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamLogo", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder ExceptTeamLogo()
        {
            return ExceptField("teamLogo");
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder WithTeamName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamName", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder ExceptTeamName()
        {
            return ExceptField("teamName");
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder WithPlayers(PlayerPlayedWithProPlayerTypeQueryBuilder playerPlayedWithProPlayerTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("players", alias, playerPlayedWithProPlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerPlayedWithProTeamTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }
    }
}
