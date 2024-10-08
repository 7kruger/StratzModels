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
    public partial class LeagueTableTeamHeroesObjectTypeQueryBuilder : GraphQlQueryBuilder<LeagueTableTeamHeroesObjectTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "matchWins" },
                new GraphQlFieldMetadata { Name = "imp" },
                new GraphQlFieldMetadata { Name = "banCount" }
            };

        protected override string TypeName { get { return "LeagueTableTeamHeroesObjectType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithMatchWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchWins", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptMatchWins()
        {
            return ExceptField("matchWins");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithBanCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("banCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptBanCount()
        {
            return ExceptField("banCount");
        }
    }
}
