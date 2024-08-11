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
    public partial class MatchStatsLaneReportTypeQueryBuilder : GraphQlQueryBuilder<MatchStatsLaneReportTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "radiant", IsComplex = true, QueryBuilderType = typeof(MatchStatsLaneReportFactionObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "dire", IsComplex = true, QueryBuilderType = typeof(MatchStatsLaneReportFactionObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchStatsLaneReportType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchStatsLaneReportTypeQueryBuilder WithRadiant(MatchStatsLaneReportFactionObjectTypeQueryBuilder matchStatsLaneReportFactionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("radiant", alias, matchStatsLaneReportFactionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsLaneReportTypeQueryBuilder ExceptRadiant()
        {
            return ExceptField("radiant");
        }

        public MatchStatsLaneReportTypeQueryBuilder WithDire(MatchStatsLaneReportFactionObjectTypeQueryBuilder matchStatsLaneReportFactionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("dire", alias, matchStatsLaneReportFactionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchStatsLaneReportTypeQueryBuilder ExceptDire()
        {
            return ExceptField("dire");
        }
    }
}
