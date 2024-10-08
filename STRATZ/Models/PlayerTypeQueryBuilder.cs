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
    public partial class PlayerTypeQueryBuilder : GraphQlQueryBuilder<PlayerTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccountId" },
                new GraphQlFieldMetadata { Name = "identity", IsComplex = true, QueryBuilderType = typeof(CaptainJackIdentityPublicProfileTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "imp" },
                new GraphQlFieldMetadata { Name = "firstMatchDate" },
                new GraphQlFieldMetadata { Name = "lastMatchDate" },
                new GraphQlFieldMetadata { Name = "lastMatchRegionId" },
                new GraphQlFieldMetadata { Name = "ranks", IsComplex = true, QueryBuilderType = typeof(SteamAccountSeasonRankTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "leaderboardRanks", IsComplex = true, QueryBuilderType = typeof(SteamAccountSeasonLeaderBoardRankTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "badges", IsComplex = true, QueryBuilderType = typeof(PlayerBadgeTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "names", IsComplex = true, QueryBuilderType = typeof(SteamAccountNameTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "behaviorScore" },
                new GraphQlFieldMetadata { Name = "team", IsComplex = true, QueryBuilderType = typeof(SteamAccountTeamMemberTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "guildMember", IsComplex = true, QueryBuilderType = typeof(GuildMemberTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "activity", IsComplex = true, QueryBuilderType = typeof(PlayerActivitySummaryTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "isFollowed" },
                new GraphQlFieldMetadata { Name = "simpleSummary", IsComplex = true, QueryBuilderType = typeof(PlayerCardHoverTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "performance", IsComplex = true, QueryBuilderType = typeof(PlayerPerformanceTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroPerformance", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(PlayerPerformanceTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroesPerformance", IsComplex = true, QueryBuilderType = typeof(PlayerHeroesPerformanceTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matches", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matchesGroupBy", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MatchGroupByTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "dotaPlus", IsComplex = true, QueryBuilderType = typeof(HeroDotaPlusLeaderboardRankTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroStreaks", IsComplex = true, QueryBuilderType = typeof(PlayerHeroPerformanceLongestStreakTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "feats", IsComplex = true, QueryBuilderType = typeof(FeatTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "PlayerType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public PlayerTypeQueryBuilder WithIdentity(CaptainJackIdentityPublicProfileTypeQueryBuilder captainJackIdentityPublicProfileTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("identity", alias, captainJackIdentityPublicProfileTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptIdentity()
        {
            return ExceptField("identity");
        }

        public PlayerTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public PlayerTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public PlayerTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public PlayerTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }

        public PlayerTypeQueryBuilder WithFirstMatchDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDate", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptFirstMatchDate()
        {
            return ExceptField("firstMatchDate");
        }

        public PlayerTypeQueryBuilder WithLastMatchDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDate", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptLastMatchDate()
        {
            return ExceptField("lastMatchDate");
        }

        public PlayerTypeQueryBuilder WithLastMatchRegionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchRegionId", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptLastMatchRegionId()
        {
            return ExceptField("lastMatchRegionId");
        }

        public PlayerTypeQueryBuilder WithRanks(SteamAccountSeasonRankTypeQueryBuilder steamAccountSeasonRankTypeQueryBuilder, QueryBuilderParameter<IEnumerable<byte?>> seasonRankIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (seasonRankIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "seasonRankIds", ArgumentValue = seasonRankIds} );

            return WithObjectField("ranks", alias, steamAccountSeasonRankTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlayerTypeQueryBuilder ExceptRanks()
        {
            return ExceptField("ranks");
        }

        public PlayerTypeQueryBuilder WithLeaderboardRanks(SteamAccountSeasonLeaderBoardRankTypeQueryBuilder steamAccountSeasonLeaderBoardRankTypeQueryBuilder, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("leaderboardRanks", alias, steamAccountSeasonLeaderBoardRankTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public PlayerTypeQueryBuilder ExceptLeaderboardRanks()
        {
            return ExceptField("leaderboardRanks");
        }

        public PlayerTypeQueryBuilder WithBadges(PlayerBadgeTypeQueryBuilder playerBadgeTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("badges", alias, playerBadgeTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptBadges()
        {
            return ExceptField("badges");
        }

        public PlayerTypeQueryBuilder WithNames(SteamAccountNameTypeQueryBuilder steamAccountNameTypeQueryBuilder, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("names", alias, steamAccountNameTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public PlayerTypeQueryBuilder ExceptNames()
        {
            return ExceptField("names");
        }

        public PlayerTypeQueryBuilder WithBehaviorScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("behaviorScore", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptBehaviorScore()
        {
            return ExceptField("behaviorScore");
        }

        public PlayerTypeQueryBuilder WithTeam(SteamAccountTeamMemberTypeQueryBuilder steamAccountTeamMemberTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("team", alias, steamAccountTeamMemberTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptTeam()
        {
            return ExceptField("team");
        }

        public PlayerTypeQueryBuilder WithGuildMember(GuildMemberTypeQueryBuilder guildMemberTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("guildMember", alias, guildMemberTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptGuildMember()
        {
            return ExceptField("guildMember");
        }

        public PlayerTypeQueryBuilder WithActivity(PlayerActivitySummaryTypeQueryBuilder playerActivitySummaryTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("activity", alias, playerActivitySummaryTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptActivity()
        {
            return ExceptField("activity");
        }

        public PlayerTypeQueryBuilder WithIsFollowed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isFollowed", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptIsFollowed()
        {
            return ExceptField("isFollowed");
        }

        public PlayerTypeQueryBuilder WithSimpleSummary(PlayerCardHoverTypeQueryBuilder playerCardHoverTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("simpleSummary", alias, playerCardHoverTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptSimpleSummary()
        {
            return ExceptField("simpleSummary");
        }

        public PlayerTypeQueryBuilder WithPerformance(PlayerPerformanceTypeQueryBuilder playerPerformanceTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("performance", alias, playerPerformanceTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptPerformance()
        {
            return ExceptField("performance");
        }

        public PlayerTypeQueryBuilder WithHeroPerformance(PlayerPerformanceTypeQueryBuilder playerPerformanceTypeQueryBuilder, QueryBuilderParameter<short?> heroId, QueryBuilderParameter<PlayerHeroPerformanceMatchesRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("heroPerformance", alias, playerPerformanceTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlayerTypeQueryBuilder ExceptHeroPerformance()
        {
            return ExceptField("heroPerformance");
        }

        public PlayerTypeQueryBuilder WithHeroesPerformance(PlayerHeroesPerformanceTypeQueryBuilder playerHeroesPerformanceTypeQueryBuilder, QueryBuilderParameter<PlayerHeroPerformanceMatchesRequestType> request = null, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (request != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            return WithObjectField("heroesPerformance", alias, playerHeroesPerformanceTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public PlayerTypeQueryBuilder ExceptHeroesPerformance()
        {
            return ExceptField("heroesPerformance");
        }

        public PlayerTypeQueryBuilder WithMatches(MatchTypeQueryBuilder matchTypeQueryBuilder, QueryBuilderParameter<PlayerMatchesRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("matches", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlayerTypeQueryBuilder ExceptMatches()
        {
            return ExceptField("matches");
        }

        public PlayerTypeQueryBuilder WithMatchesGroupBy(MatchGroupByTypeQueryBuilder matchGroupByTypeQueryBuilder, QueryBuilderParameter<PlayerMatchesGroupByRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("matchesGroupBy", alias, matchGroupByTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlayerTypeQueryBuilder ExceptMatchesGroupBy()
        {
            return ExceptField("matchesGroupBy");
        }

        public PlayerTypeQueryBuilder WithDotaPlus(HeroDotaPlusLeaderboardRankTypeQueryBuilder heroDotaPlusLeaderboardRankTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("dotaPlus", alias, heroDotaPlusLeaderboardRankTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerTypeQueryBuilder ExceptDotaPlus()
        {
            return ExceptField("dotaPlus");
        }

        public PlayerTypeQueryBuilder WithHeroStreaks(PlayerHeroPerformanceLongestStreakTypeQueryBuilder playerHeroPerformanceLongestStreakTypeQueryBuilder, QueryBuilderParameter<PlayerMatchesRequestType> request = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (request != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );

            return WithObjectField("heroStreaks", alias, playerHeroPerformanceLongestStreakTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PlayerTypeQueryBuilder ExceptHeroStreaks()
        {
            return ExceptField("heroStreaks");
        }

        public PlayerTypeQueryBuilder WithFeats(FeatTypeQueryBuilder featTypeQueryBuilder, QueryBuilderParameter<int?> take = null, QueryBuilderParameter<int?> skip = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            return WithObjectField("feats", alias, featTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public PlayerTypeQueryBuilder ExceptFeats()
        {
            return ExceptField("feats");
        }
    }
}
