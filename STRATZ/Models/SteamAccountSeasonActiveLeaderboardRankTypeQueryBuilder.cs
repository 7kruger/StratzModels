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
    public partial class SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder : GraphQlQueryBuilder<SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccountId" },
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "avgImp" },
                new GraphQlFieldMetadata { Name = "divisionId" },
                new GraphQlFieldMetadata { Name = "lastUpdateDateTime" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "position" },
                new GraphQlFieldMetadata { Name = "positionValue" },
                new GraphQlFieldMetadata { Name = "rank" },
                new GraphQlFieldMetadata { Name = "rankShift" },
                new GraphQlFieldMetadata { Name = "topHeroOne" },
                new GraphQlFieldMetadata { Name = "topHeroTwo" },
                new GraphQlFieldMetadata { Name = "topHeroThree" },
                new GraphQlFieldMetadata { Name = "winRate" }
            };

        protected override string TypeName { get { return "SteamAccountSeasonActiveLeaderboardRankType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithDivisionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("divisionId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptDivisionId()
        {
            return ExceptField("divisionId");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithLastUpdateDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastUpdateDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptLastUpdateDateTime()
        {
            return ExceptField("lastUpdateDateTime");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithPositionValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionValue", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptPositionValue()
        {
            return ExceptField("positionValue");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rank", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptRank()
        {
            return ExceptField("rank");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithRankShift(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rankShift", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptRankShift()
        {
            return ExceptField("rankShift");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithTopHeroOne(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("topHeroOne", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptTopHeroOne()
        {
            return ExceptField("topHeroOne");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithTopHeroTwo(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("topHeroTwo", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptTopHeroTwo()
        {
            return ExceptField("topHeroTwo");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithTopHeroThree(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("topHeroThree", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptTopHeroThree()
        {
            return ExceptField("topHeroThree");
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder WithWinRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winRate", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonActiveLeaderboardRankTypeQueryBuilder ExceptWinRate()
        {
            return ExceptField("winRate");
        }
    }
}
