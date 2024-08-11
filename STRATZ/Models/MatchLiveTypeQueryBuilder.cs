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
    public partial class MatchLiveTypeQueryBuilder : GraphQlQueryBuilder<MatchLiveTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "matchId" },
                new GraphQlFieldMetadata { Name = "radiantScore" },
                new GraphQlFieldMetadata { Name = "direScore" },
                new GraphQlFieldMetadata { Name = "leagueId" },
                new GraphQlFieldMetadata { Name = "league", IsComplex = true, QueryBuilderType = typeof(LeagueTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "delay" },
                new GraphQlFieldMetadata { Name = "spectators" },
                new GraphQlFieldMetadata { Name = "averageRank" },
                new GraphQlFieldMetadata { Name = "buildingState" },
                new GraphQlFieldMetadata { Name = "radiantLead" },
                new GraphQlFieldMetadata { Name = "lobbyId" },
                new GraphQlFieldMetadata { Name = "lobbyType" },
                new GraphQlFieldMetadata { Name = "serverSteamId" },
                new GraphQlFieldMetadata { Name = "gameTime" },
                new GraphQlFieldMetadata { Name = "completed" },
                new GraphQlFieldMetadata { Name = "isUpdating" },
                new GraphQlFieldMetadata { Name = "isParsing" },
                new GraphQlFieldMetadata { Name = "radiantTeamId" },
                new GraphQlFieldMetadata { Name = "direTeamId" },
                new GraphQlFieldMetadata { Name = "radiantTeam", IsComplex = true, QueryBuilderType = typeof(TeamTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "direTeam", IsComplex = true, QueryBuilderType = typeof(TeamTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "parseBeginGameTime" },
                new GraphQlFieldMetadata { Name = "numHumanPlayers" },
                new GraphQlFieldMetadata { Name = "gameMode" },
                new GraphQlFieldMetadata { Name = "playbackData", IsComplex = true, QueryBuilderType = typeof(MatchLivePlaybackDataTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "gameState" },
                new GraphQlFieldMetadata { Name = "gameMinute" },
                new GraphQlFieldMetadata { Name = "players", IsComplex = true, QueryBuilderType = typeof(MatchLivePlayerTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "createdDateTime" },
                new GraphQlFieldMetadata { Name = "modifiedDateTime" },
                new GraphQlFieldMetadata { Name = "insight", IsComplex = true, QueryBuilderType = typeof(MatchLiveInsightTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "winRateValues", IsComplex = true },
                new GraphQlFieldMetadata { Name = "durationValues", IsComplex = true },
                new GraphQlFieldMetadata { Name = "liveWinRateValues", IsComplex = true, QueryBuilderType = typeof(MatchLiveWinRateDetailTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchLiveType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchLiveTypeQueryBuilder WithMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptMatchId()
        {
            return ExceptField("matchId");
        }

        public MatchLiveTypeQueryBuilder WithRadiantScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("radiantScore", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptRadiantScore()
        {
            return ExceptField("radiantScore");
        }

        public MatchLiveTypeQueryBuilder WithDireScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("direScore", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptDireScore()
        {
            return ExceptField("direScore");
        }

        public MatchLiveTypeQueryBuilder WithLeagueId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leagueId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptLeagueId()
        {
            return ExceptField("leagueId");
        }

        public MatchLiveTypeQueryBuilder WithLeague(LeagueTypeQueryBuilder leagueTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("league", alias, leagueTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptLeague()
        {
            return ExceptField("league");
        }

        public MatchLiveTypeQueryBuilder WithDelay(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("delay", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptDelay()
        {
            return ExceptField("delay");
        }

        public MatchLiveTypeQueryBuilder WithSpectators(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("spectators", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptSpectators()
        {
            return ExceptField("spectators");
        }

        public MatchLiveTypeQueryBuilder WithAverageRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("averageRank", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptAverageRank()
        {
            return ExceptField("averageRank");
        }

        public MatchLiveTypeQueryBuilder WithBuildingState(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("buildingState", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptBuildingState()
        {
            return ExceptField("buildingState");
        }

        public MatchLiveTypeQueryBuilder WithRadiantLead(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("radiantLead", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptRadiantLead()
        {
            return ExceptField("radiantLead");
        }

        public MatchLiveTypeQueryBuilder WithLobbyId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lobbyId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptLobbyId()
        {
            return ExceptField("lobbyId");
        }

        public MatchLiveTypeQueryBuilder WithLobbyType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lobbyType", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptLobbyType()
        {
            return ExceptField("lobbyType");
        }

        public MatchLiveTypeQueryBuilder WithServerSteamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("serverSteamId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptServerSteamId()
        {
            return ExceptField("serverSteamId");
        }

        public MatchLiveTypeQueryBuilder WithGameTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptGameTime()
        {
            return ExceptField("gameTime");
        }

        public MatchLiveTypeQueryBuilder WithCompleted(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("completed", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptCompleted()
        {
            return ExceptField("completed");
        }

        public MatchLiveTypeQueryBuilder WithIsUpdating(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isUpdating", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptIsUpdating()
        {
            return ExceptField("isUpdating");
        }

        public MatchLiveTypeQueryBuilder WithIsParsing(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isParsing", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptIsParsing()
        {
            return ExceptField("isParsing");
        }

        public MatchLiveTypeQueryBuilder WithRadiantTeamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("radiantTeamId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptRadiantTeamId()
        {
            return ExceptField("radiantTeamId");
        }

        public MatchLiveTypeQueryBuilder WithDireTeamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("direTeamId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptDireTeamId()
        {
            return ExceptField("direTeamId");
        }

        public MatchLiveTypeQueryBuilder WithRadiantTeam(TeamTypeQueryBuilder teamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("radiantTeam", alias, teamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptRadiantTeam()
        {
            return ExceptField("radiantTeam");
        }

        public MatchLiveTypeQueryBuilder WithDireTeam(TeamTypeQueryBuilder teamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("direTeam", alias, teamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptDireTeam()
        {
            return ExceptField("direTeam");
        }

        public MatchLiveTypeQueryBuilder WithParseBeginGameTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("parseBeginGameTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptParseBeginGameTime()
        {
            return ExceptField("parseBeginGameTime");
        }

        public MatchLiveTypeQueryBuilder WithNumHumanPlayers(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("numHumanPlayers", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptNumHumanPlayers()
        {
            return ExceptField("numHumanPlayers");
        }

        public MatchLiveTypeQueryBuilder WithGameMode(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameMode", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptGameMode()
        {
            return ExceptField("gameMode");
        }

        public MatchLiveTypeQueryBuilder WithPlaybackData(MatchLivePlaybackDataTypeQueryBuilder matchLivePlaybackDataTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("playbackData", alias, matchLivePlaybackDataTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptPlaybackData()
        {
            return ExceptField("playbackData");
        }

        public MatchLiveTypeQueryBuilder WithGameState(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameState", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptGameState()
        {
            return ExceptField("gameState");
        }

        public MatchLiveTypeQueryBuilder WithGameMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptGameMinute()
        {
            return ExceptField("gameMinute");
        }

        public MatchLiveTypeQueryBuilder WithPlayers(MatchLivePlayerTypeQueryBuilder matchLivePlayerTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("players", alias, matchLivePlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptPlayers()
        {
            return ExceptField("players");
        }

        public MatchLiveTypeQueryBuilder WithCreatedDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("createdDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptCreatedDateTime()
        {
            return ExceptField("createdDateTime");
        }

        public MatchLiveTypeQueryBuilder WithModifiedDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("modifiedDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptModifiedDateTime()
        {
            return ExceptField("modifiedDateTime");
        }

        public MatchLiveTypeQueryBuilder WithInsight(MatchLiveInsightTypeQueryBuilder matchLiveInsightTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("insight", alias, matchLiveInsightTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptInsight()
        {
            return ExceptField("insight");
        }

        public MatchLiveTypeQueryBuilder WithWinRateValues(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winRateValues", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptWinRateValues()
        {
            return ExceptField("winRateValues");
        }

        public MatchLiveTypeQueryBuilder WithDurationValues(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("durationValues", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptDurationValues()
        {
            return ExceptField("durationValues");
        }

        public MatchLiveTypeQueryBuilder WithLiveWinRateValues(MatchLiveWinRateDetailTypeQueryBuilder matchLiveWinRateDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("liveWinRateValues", alias, matchLiveWinRateDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveTypeQueryBuilder ExceptLiveWinRateValues()
        {
            return ExceptField("liveWinRateValues");
        }
    }
}
