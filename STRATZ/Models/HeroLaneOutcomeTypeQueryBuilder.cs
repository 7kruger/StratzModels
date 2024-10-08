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
    public partial class HeroLaneOutcomeTypeQueryBuilder : GraphQlQueryBuilder<HeroLaneOutcomeTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId1" },
                new GraphQlFieldMetadata { Name = "week" },
                new GraphQlFieldMetadata { Name = "bracketBasicIds" },
                new GraphQlFieldMetadata { Name = "position" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "drawCount" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "lossCount" },
                new GraphQlFieldMetadata { Name = "stompWinCount" },
                new GraphQlFieldMetadata { Name = "stompLossCount" },
                new GraphQlFieldMetadata { Name = "matchWinCount" },
                new GraphQlFieldMetadata { Name = "csCount" },
                new GraphQlFieldMetadata { Name = "heroId2" }
            };

        protected override string TypeName { get { return "HeroLaneOutcomeType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroLaneOutcomeTypeQueryBuilder WithHeroId1(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId1", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptHeroId1()
        {
            return ExceptField("heroId1");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithDrawCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("drawCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptDrawCount()
        {
            return ExceptField("drawCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithLossCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lossCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptLossCount()
        {
            return ExceptField("lossCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithStompWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stompWinCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptStompWinCount()
        {
            return ExceptField("stompWinCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithStompLossCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stompLossCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptStompLossCount()
        {
            return ExceptField("stompLossCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithMatchWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchWinCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptMatchWinCount()
        {
            return ExceptField("matchWinCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithCsCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("csCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptCsCount()
        {
            return ExceptField("csCount");
        }

        public HeroLaneOutcomeTypeQueryBuilder WithHeroId2(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId2", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLaneOutcomeTypeQueryBuilder ExceptHeroId2()
        {
            return ExceptField("heroId2");
        }
    }
}
