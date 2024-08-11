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
    public partial class LeagueTablePlayerHeroesObjectTypeQueryBuilder : GraphQlQueryBuilder<LeagueTablePlayerHeroesObjectTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "matchWins" },
                new GraphQlFieldMetadata { Name = "imp" }
            };

        protected override string TypeName { get { return "LeagueTablePlayerHeroesObjectType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder WithMatchWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchWins", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder ExceptMatchWins()
        {
            return ExceptField("matchWins");
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerHeroesObjectTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }
    }
}