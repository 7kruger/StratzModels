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
    public partial class AghanimLabHeroCompositionTypeQueryBuilder : GraphQlQueryBuilder<AghanimLabHeroCompositionTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "difficulty" },
                new GraphQlFieldMetadata { Name = "heroId1" },
                new GraphQlFieldMetadata { Name = "heroId2" },
                new GraphQlFieldMetadata { Name = "heroId3" },
                new GraphQlFieldMetadata { Name = "heroId4" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "duration" },
                new GraphQlFieldMetadata { Name = "wilsonScore" }
            };

        protected override string TypeName { get { return "AghanimLabHeroCompositionType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AghanimLabHeroCompositionTypeQueryBuilder WithDifficulty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("difficulty", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptDifficulty()
        {
            return ExceptField("difficulty");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithHeroId1(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId1", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptHeroId1()
        {
            return ExceptField("heroId1");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithHeroId2(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId2", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptHeroId2()
        {
            return ExceptField("heroId2");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithHeroId3(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId3", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptHeroId3()
        {
            return ExceptField("heroId3");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithHeroId4(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId4", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptHeroId4()
        {
            return ExceptField("heroId4");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("duration", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptDuration()
        {
            return ExceptField("duration");
        }

        public AghanimLabHeroCompositionTypeQueryBuilder WithWilsonScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wilsonScore", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroCompositionTypeQueryBuilder ExceptWilsonScore()
        {
            return ExceptField("wilsonScore");
        }
    }
}
