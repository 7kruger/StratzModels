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
    public partial class MatchesDayTypeQueryBuilder : GraphQlQueryBuilder<MatchesDayTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "day" },
                new GraphQlFieldMetadata { Name = "matchCount" }
            };

        protected override string TypeName { get { return "MatchesDayType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchesDayTypeQueryBuilder WithDay(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("day", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchesDayTypeQueryBuilder ExceptDay()
        {
            return ExceptField("day");
        }

        public MatchesDayTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchesDayTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }
    }
}