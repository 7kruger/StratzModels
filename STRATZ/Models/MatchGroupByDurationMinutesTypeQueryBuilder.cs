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
    public partial class MatchGroupByDurationMinutesTypeQueryBuilder : GraphQlQueryBuilder<MatchGroupByDurationMinutesTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "durationMinutes" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "avgImp" },
                new GraphQlFieldMetadata { Name = "avgGoldPerMinute" },
                new GraphQlFieldMetadata { Name = "avgExperiencePerMinute" },
                new GraphQlFieldMetadata { Name = "avgKDA" },
                new GraphQlFieldMetadata { Name = "avgKills" },
                new GraphQlFieldMetadata { Name = "avgDeaths" },
                new GraphQlFieldMetadata { Name = "avgAssists" },
                new GraphQlFieldMetadata { Name = "avgTowerDamage" },
                new GraphQlFieldMetadata { Name = "lastMatchDateTime" },
                new GraphQlFieldMetadata { Name = "firstMatchDateTime" }
            };

        protected override string TypeName { get { return "MatchGroupByDurationMinutesType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchGroupByDurationMinutesTypeQueryBuilder WithDurationMinutes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationMinutes", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptDurationMinutes()
        {
            return ExceptField("durationMinutes");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgGoldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgGoldPerMinute()
        {
            return ExceptField("avgGoldPerMinute");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgExperiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgExperiencePerMinute()
        {
            return ExceptField("avgExperiencePerMinute");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgKda(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKDA", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgKda()
        {
            return ExceptField("avgKDA");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgKills()
        {
            return ExceptField("avgKills");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgDeaths()
        {
            return ExceptField("avgDeaths");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgAssists()
        {
            return ExceptField("avgAssists");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithAvgTowerDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgTowerDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptAvgTowerDamage()
        {
            return ExceptField("avgTowerDamage");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByDurationMinutesTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }
    }
}