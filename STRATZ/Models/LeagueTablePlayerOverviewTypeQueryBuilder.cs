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
    public partial class LeagueTablePlayerOverviewTypeQueryBuilder : GraphQlQueryBuilder<LeagueTablePlayerOverviewTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "points" },
                new GraphQlFieldMetadata { Name = "earnings" },
                new GraphQlFieldMetadata { Name = "seriesCount" },
                new GraphQlFieldMetadata { Name = "seriesWins" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "matchWins" },
                new GraphQlFieldMetadata { Name = "imp" }
            };

        protected override string TypeName { get { return "LeagueTablePlayerOverviewType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTablePlayerOverviewTypeQueryBuilder WithPoints(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("points", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptPoints()
        {
            return ExceptField("points");
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder WithEarnings(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("earnings", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptEarnings()
        {
            return ExceptField("earnings");
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder WithSeriesCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seriesCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptSeriesCount()
        {
            return ExceptField("seriesCount");
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder WithSeriesWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seriesWins", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptSeriesWins()
        {
            return ExceptField("seriesWins");
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder WithMatchWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchWins", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptMatchWins()
        {
            return ExceptField("matchWins");
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerOverviewTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }
    }
}
