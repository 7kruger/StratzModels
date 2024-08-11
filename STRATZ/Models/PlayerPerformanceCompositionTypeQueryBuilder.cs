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
    public partial class PlayerPerformanceCompositionTypeQueryBuilder : GraphQlQueryBuilder<PlayerPerformanceCompositionTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "allies", IsComplex = true, QueryBuilderType = typeof(PlayerPerformanceCompositionHeroTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "foes", IsComplex = true, QueryBuilderType = typeof(PlayerPerformanceCompositionHeroTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "PlayerPerformanceCompositionType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerPerformanceCompositionTypeQueryBuilder WithAllies(PlayerPerformanceCompositionHeroTypeQueryBuilder playerPerformanceCompositionHeroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("allies", alias, playerPerformanceCompositionHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformanceCompositionTypeQueryBuilder ExceptAllies()
        {
            return ExceptField("allies");
        }

        public PlayerPerformanceCompositionTypeQueryBuilder WithFoes(PlayerPerformanceCompositionHeroTypeQueryBuilder playerPerformanceCompositionHeroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("foes", alias, playerPerformanceCompositionHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformanceCompositionTypeQueryBuilder ExceptFoes()
        {
            return ExceptField("foes");
        }
    }
}
