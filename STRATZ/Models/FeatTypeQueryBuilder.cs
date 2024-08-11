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
    public partial class FeatTypeQueryBuilder : GraphQlQueryBuilder<FeatTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "type" },
                new GraphQlFieldMetadata { Name = "value" },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "hero", IsComplex = true, QueryBuilderType = typeof(HeroTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matchId" },
                new GraphQlFieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "FeatType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public FeatTypeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public FeatTypeQueryBuilder ExceptType()
        {
            return ExceptField("type");
        }

        public FeatTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public FeatTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }

        public FeatTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public FeatTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public FeatTypeQueryBuilder WithHero(HeroTypeQueryBuilder heroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("hero", alias, heroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FeatTypeQueryBuilder ExceptHero()
        {
            return ExceptField("hero");
        }

        public FeatTypeQueryBuilder WithMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchId", alias, new GraphQlDirective[] { include, skip });
        }

        public FeatTypeQueryBuilder ExceptMatchId()
        {
            return ExceptField("matchId");
        }

        public FeatTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public FeatTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }
    }
}