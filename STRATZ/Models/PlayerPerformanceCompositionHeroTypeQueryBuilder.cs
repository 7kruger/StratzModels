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
    public partial class PlayerPerformanceCompositionHeroTypeQueryBuilder : GraphQlQueryBuilder<PlayerPerformanceCompositionHeroTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" }
            };

        protected override string TypeName { get { return "PlayerPerformanceCompositionHeroType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerPerformanceCompositionHeroTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformanceCompositionHeroTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public PlayerPerformanceCompositionHeroTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformanceCompositionHeroTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public PlayerPerformanceCompositionHeroTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformanceCompositionHeroTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }
    }
}
