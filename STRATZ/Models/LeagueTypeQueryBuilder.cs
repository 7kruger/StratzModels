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
    public partial class LeagueTypeQueryBuilder : GraphQlQueryBuilder<LeagueTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "name" },
                new GraphQlFieldMetadata { Name = "banner" },
                new GraphQlFieldMetadata { Name = "basePrizePool" },
                new GraphQlFieldMetadata { Name = "stopSalesTime" },
                new GraphQlFieldMetadata { Name = "tier" },
                new GraphQlFieldMetadata { Name = "region" },
                new GraphQlFieldMetadata { Name = "private" },
                new GraphQlFieldMetadata { Name = "freeToSpectate" },
                new GraphQlFieldMetadata { Name = "startDateTime" },
                new GraphQlFieldMetadata { Name = "endDateTime" },
                new GraphQlFieldMetadata { Name = "tournamentUrl" },
                new GraphQlFieldMetadata { Name = "lastMatchDate" },
                new GraphQlFieldMetadata { Name = "hasLiveMatches" },
                new GraphQlFieldMetadata { Name = "prizePool" },
                new GraphQlFieldMetadata { Name = "imageUri" },
                new GraphQlFieldMetadata { Name = "displayName" },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "country" },
                new GraphQlFieldMetadata { Name = "venue" },
                new GraphQlFieldMetadata { Name = "isFollowed" },
                new GraphQlFieldMetadata { Name = "nodeGroups", IsComplex = true, QueryBuilderType = typeof(LeagueNodeGroupTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "liveMatches", IsComplex = true, QueryBuilderType = typeof(MatchLiveTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matches", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matchesGroupBy", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MatchGroupByTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "series", IsComplex = true, QueryBuilderType = typeof(SeriesTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "tables", IsComplex = true, QueryBuilderType = typeof(LeagueTableTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "battlePass", IsComplex = true, QueryBuilderType = typeof(LeagueBattlePassTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "stats", IsComplex = true, QueryBuilderType = typeof(LeagueStatTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "prizePoolPercentages", IsComplex = true, QueryBuilderType = typeof(LeaguePrizePoolPercentageTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "standings", IsComplex = true, QueryBuilderType = typeof(TeamPrizeTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "streams", IsComplex = true, QueryBuilderType = typeof(LeagueStreamTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LeagueType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public LeagueTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public LeagueTypeQueryBuilder WithBanner(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("banner", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptBanner()
        {
            return ExceptField("banner");
        }

        public LeagueTypeQueryBuilder WithBasePrizePool(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("basePrizePool", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptBasePrizePool()
        {
            return ExceptField("basePrizePool");
        }

        public LeagueTypeQueryBuilder WithStopSalesTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stopSalesTime", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptStopSalesTime()
        {
            return ExceptField("stopSalesTime");
        }

        public LeagueTypeQueryBuilder WithTier(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("tier", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptTier()
        {
            return ExceptField("tier");
        }

        public LeagueTypeQueryBuilder WithRegion(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("region", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptRegion()
        {
            return ExceptField("region");
        }

        public LeagueTypeQueryBuilder WithPrivate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("private", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptPrivate()
        {
            return ExceptField("private");
        }

        public LeagueTypeQueryBuilder WithFreeToSpectate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("freeToSpectate", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptFreeToSpectate()
        {
            return ExceptField("freeToSpectate");
        }

        public LeagueTypeQueryBuilder WithStartDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("startDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptStartDateTime()
        {
            return ExceptField("startDateTime");
        }

        public LeagueTypeQueryBuilder WithEndDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("endDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptEndDateTime()
        {
            return ExceptField("endDateTime");
        }

        public LeagueTypeQueryBuilder WithTournamentUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("tournamentUrl", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptTournamentUrl()
        {
            return ExceptField("tournamentUrl");
        }

        public LeagueTypeQueryBuilder WithLastMatchDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDate", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptLastMatchDate()
        {
            return ExceptField("lastMatchDate");
        }

        public LeagueTypeQueryBuilder WithHasLiveMatches(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hasLiveMatches", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptHasLiveMatches()
        {
            return ExceptField("hasLiveMatches");
        }

        public LeagueTypeQueryBuilder WithPrizePool(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("prizePool", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptPrizePool()
        {
            return ExceptField("prizePool");
        }

        public LeagueTypeQueryBuilder WithImageUri(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imageUri", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptImageUri()
        {
            return ExceptField("imageUri");
        }

        public LeagueTypeQueryBuilder WithDisplayName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displayName", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptDisplayName()
        {
            return ExceptField("displayName");
        }

        public LeagueTypeQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptDescription()
        {
            return ExceptField("description");
        }

        public LeagueTypeQueryBuilder WithCountry(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("country", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptCountry()
        {
            return ExceptField("country");
        }

        public LeagueTypeQueryBuilder WithVenue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("venue", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptVenue()
        {
            return ExceptField("venue");
        }

        public LeagueTypeQueryBuilder WithIsFollowed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isFollowed", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptIsFollowed()
        {
            return ExceptField("isFollowed");
        }

        public LeagueTypeQueryBuilder WithNodeGroups(LeagueNodeGroupTypeQueryBuilder leagueNodeGroupTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("nodeGroups", alias, leagueNodeGroupTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptNodeGroups()
        {
            return ExceptField("nodeGroups");
        }

        public LeagueTypeQueryBuilder WithLiveMatches(MatchLiveTypeQueryBuilder matchLiveTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("liveMatches", alias, matchLiveTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptLiveMatches()
        {
            return ExceptField("liveMatches");
        }

        public LeagueTypeQueryBuilder WithMatches(MatchTypeQueryBuilder matchTypeQueryBuilder, QueryBuilderParameter<LeagueMatchesRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("matches", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeagueTypeQueryBuilder ExceptMatches()
        {
            return ExceptField("matches");
        }

        public LeagueTypeQueryBuilder WithMatchesGroupBy(MatchGroupByTypeQueryBuilder matchGroupByTypeQueryBuilder, QueryBuilderParameter<PlayerMatchesGroupByRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("matchesGroupBy", alias, matchGroupByTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeagueTypeQueryBuilder ExceptMatchesGroupBy()
        {
            return ExceptField("matchesGroupBy");
        }

        public LeagueTypeQueryBuilder WithSeries(SeriesTypeQueryBuilder seriesTypeQueryBuilder, QueryBuilderParameter<IEnumerable<LeagueStage>> leagueStageTypeIds = null, QueryBuilderParameter<int?> seriesId = null, QueryBuilderParameter<int?> teamId = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (leagueStageTypeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "leagueStageTypeIds", ArgumentValue = leagueStageTypeIds} );

            if (seriesId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "seriesId", ArgumentValue = seriesId} );

            if (teamId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "teamId", ArgumentValue = teamId} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("series", alias, seriesTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public LeagueTypeQueryBuilder ExceptSeries()
        {
            return ExceptField("series");
        }

        public LeagueTypeQueryBuilder WithTables(LeagueTableTypeQueryBuilder leagueTableTypeQueryBuilder, QueryBuilderParameter<IEnumerable<LeagueStage>> leagueStageTypeIds = null, QueryBuilderParameter<TableCalculateEnum> calculateTypeId = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (leagueStageTypeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "leagueStageTypeIds", ArgumentValue = leagueStageTypeIds} );

            if (calculateTypeId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "calculateTypeId", ArgumentValue = calculateTypeId} );

            return WithObjectField("tables", alias, leagueTableTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeagueTypeQueryBuilder ExceptTables()
        {
            return ExceptField("tables");
        }

        public LeagueTypeQueryBuilder WithBattlePass(LeagueBattlePassTypeQueryBuilder leagueBattlePassTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("battlePass", alias, leagueBattlePassTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptBattlePass()
        {
            return ExceptField("battlePass");
        }

        public LeagueTypeQueryBuilder WithStats(LeagueStatTypeQueryBuilder leagueStatTypeQueryBuilder, QueryBuilderParameter<IEnumerable<LeagueStage>> leagueStageTypeIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (leagueStageTypeIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "leagueStageTypeIds", ArgumentValue = leagueStageTypeIds} );

            return WithObjectField("stats", alias, leagueStatTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeagueTypeQueryBuilder ExceptStats()
        {
            return ExceptField("stats");
        }

        public LeagueTypeQueryBuilder WithPrizePoolPercentages(LeaguePrizePoolPercentageTypeQueryBuilder leaguePrizePoolPercentageTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("prizePoolPercentages", alias, leaguePrizePoolPercentageTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptPrizePoolPercentages()
        {
            return ExceptField("prizePoolPercentages");
        }

        public LeagueTypeQueryBuilder WithStandings(TeamPrizeTypeQueryBuilder teamPrizeTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("standings", alias, teamPrizeTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptStandings()
        {
            return ExceptField("standings");
        }

        public LeagueTypeQueryBuilder WithStreams(LeagueStreamTypeQueryBuilder leagueStreamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("streams", alias, leagueStreamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTypeQueryBuilder ExceptStreams()
        {
            return ExceptField("streams");
        }
    }
}