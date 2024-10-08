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
    public partial class MatchPlayerStatsRuneEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerStatsRuneEventTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "rune" },
                new GraphQlFieldMetadata { Name = "action" },
                new GraphQlFieldMetadata { Name = "gold" },
                new GraphQlFieldMetadata { Name = "positionX" },
                new GraphQlFieldMetadata { Name = "positionY" }
            };

        protected override string TypeName { get { return "MatchPlayerStatsRuneEventType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerStatsRuneEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder WithRune(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rune", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder ExceptRune()
        {
            return ExceptField("rune");
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder WithAction(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("action", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder ExceptAction()
        {
            return ExceptField("action");
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder WithGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gold", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder ExceptGold()
        {
            return ExceptField("gold");
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsRuneEventTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }
    }
}
