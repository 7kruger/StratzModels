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
    public partial class PlayerMatchesRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _matchIds;
        private InputPropertyInfo _leagueId;
        private InputPropertyInfo _leagueIds;
        private InputPropertyInfo _seriesId;
        private InputPropertyInfo _teamId;
        private InputPropertyInfo _teamIdSteamAccount;
        private InputPropertyInfo _isParsed;
        private InputPropertyInfo _startDateTime;
        private InputPropertyInfo _endDateTime;
        private InputPropertyInfo _gameModeIds;
        private InputPropertyInfo _lobbyTypeIds;
        private InputPropertyInfo _gameVersionIds;
        private InputPropertyInfo _regionIds;
        private InputPropertyInfo _rankIds;
        private InputPropertyInfo _bracketIds;
        private InputPropertyInfo _isStats;
        private InputPropertyInfo _heroIds;
        private InputPropertyInfo _laneIds;
        private InputPropertyInfo _roleIds;
        private InputPropertyInfo _positionIds;
        private InputPropertyInfo _awardIds;
        private InputPropertyInfo _isParty;
        private InputPropertyInfo _hasAward;
        private InputPropertyInfo _withFriendSteamAccountIds;
        private InputPropertyInfo _withEnemySteamAccountIds;
        private InputPropertyInfo _withFriendHeroIds;
        private InputPropertyInfo _withEnemyHeroIds;
        private InputPropertyInfo _isVictory;
        private InputPropertyInfo _isRadiant;
        private InputPropertyInfo _minGameVersionId;
        private InputPropertyInfo _maxGameVersionId;
        private InputPropertyInfo _minImp;
        private InputPropertyInfo _maxImp;
        private InputPropertyInfo _playerList;
        private InputPropertyInfo _take;
        private InputPropertyInfo _skip;
        private InputPropertyInfo _after;
        private InputPropertyInfo _before;
        private InputPropertyInfo _orderBy;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<long>>))]
        #endif
        public QueryBuilderParameter<ICollection<long>> MatchIds
        {
            get { return (QueryBuilderParameter<ICollection<long>>)_matchIds.Value; }
            set { _matchIds = new InputPropertyInfo { Name = "matchIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> LeagueId
        {
            get { return (QueryBuilderParameter<int?>)_leagueId.Value; }
            set { _leagueId = new InputPropertyInfo { Name = "leagueId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> LeagueIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_leagueIds.Value; }
            set { _leagueIds = new InputPropertyInfo { Name = "leagueIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> SeriesId
        {
            get { return (QueryBuilderParameter<long?>)_seriesId.Value; }
            set { _seriesId = new InputPropertyInfo { Name = "seriesId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> TeamId
        {
            get { return (QueryBuilderParameter<int?>)_teamId.Value; }
            set { _teamId = new InputPropertyInfo { Name = "teamId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> TeamIdSteamAccount
        {
            get { return (QueryBuilderParameter<int?>)_teamIdSteamAccount.Value; }
            set { _teamIdSteamAccount = new InputPropertyInfo { Name = "teamIdSteamAccount", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsParsed
        {
            get { return (QueryBuilderParameter<bool?>)_isParsed.Value; }
            set { _isParsed = new InputPropertyInfo { Name = "isParsed", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> StartDateTime
        {
            get { return (QueryBuilderParameter<long?>)_startDateTime.Value; }
            set { _startDateTime = new InputPropertyInfo { Name = "startDateTime", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> EndDateTime
        {
            get { return (QueryBuilderParameter<long?>)_endDateTime.Value; }
            set { _endDateTime = new InputPropertyInfo { Name = "endDateTime", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<byte>>))]
        #endif
        public QueryBuilderParameter<ICollection<byte>> GameModeIds
        {
            get { return (QueryBuilderParameter<ICollection<byte>>)_gameModeIds.Value; }
            set { _gameModeIds = new InputPropertyInfo { Name = "gameModeIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<byte>>))]
        #endif
        public QueryBuilderParameter<ICollection<byte>> LobbyTypeIds
        {
            get { return (QueryBuilderParameter<ICollection<byte>>)_lobbyTypeIds.Value; }
            set { _lobbyTypeIds = new InputPropertyInfo { Name = "lobbyTypeIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> GameVersionIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_gameVersionIds.Value; }
            set { _gameVersionIds = new InputPropertyInfo { Name = "gameVersionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> RegionIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_regionIds.Value; }
            set { _regionIds = new InputPropertyInfo { Name = "regionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> RankIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_rankIds.Value; }
            set { _rankIds = new InputPropertyInfo { Name = "rankIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> BracketIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_bracketIds.Value; }
            set { _bracketIds = new InputPropertyInfo { Name = "bracketIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsStats
        {
            get { return (QueryBuilderParameter<bool?>)_isStats.Value; }
            set { _isStats = new InputPropertyInfo { Name = "isStats", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<short>>))]
        #endif
        public QueryBuilderParameter<ICollection<short>> HeroIds
        {
            get { return (QueryBuilderParameter<ICollection<short>>)_heroIds.Value; }
            set { _heroIds = new InputPropertyInfo { Name = "heroIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> LaneIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_laneIds.Value; }
            set { _laneIds = new InputPropertyInfo { Name = "laneIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> RoleIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_roleIds.Value; }
            set { _roleIds = new InputPropertyInfo { Name = "roleIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<MatchPlayerPositionType>>))]
        #endif
        public QueryBuilderParameter<ICollection<MatchPlayerPositionType>> PositionIds
        {
            get { return (QueryBuilderParameter<ICollection<MatchPlayerPositionType>>)_positionIds.Value; }
            set { _positionIds = new InputPropertyInfo { Name = "positionIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> AwardIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_awardIds.Value; }
            set { _awardIds = new InputPropertyInfo { Name = "awardIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsParty
        {
            get { return (QueryBuilderParameter<bool?>)_isParty.Value; }
            set { _isParty = new InputPropertyInfo { Name = "isParty", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> HasAward
        {
            get { return (QueryBuilderParameter<bool?>)_hasAward.Value; }
            set { _hasAward = new InputPropertyInfo { Name = "hasAward", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<long>>))]
        #endif
        public QueryBuilderParameter<ICollection<long>> WithFriendSteamAccountIds
        {
            get { return (QueryBuilderParameter<ICollection<long>>)_withFriendSteamAccountIds.Value; }
            set { _withFriendSteamAccountIds = new InputPropertyInfo { Name = "withFriendSteamAccountIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<long>>))]
        #endif
        public QueryBuilderParameter<ICollection<long>> WithEnemySteamAccountIds
        {
            get { return (QueryBuilderParameter<ICollection<long>>)_withEnemySteamAccountIds.Value; }
            set { _withEnemySteamAccountIds = new InputPropertyInfo { Name = "withEnemySteamAccountIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> WithFriendHeroIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_withFriendHeroIds.Value; }
            set { _withFriendHeroIds = new InputPropertyInfo { Name = "withFriendHeroIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<int>>))]
        #endif
        public QueryBuilderParameter<ICollection<int>> WithEnemyHeroIds
        {
            get { return (QueryBuilderParameter<ICollection<int>>)_withEnemyHeroIds.Value; }
            set { _withEnemyHeroIds = new InputPropertyInfo { Name = "withEnemyHeroIds", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsVictory
        {
            get { return (QueryBuilderParameter<bool?>)_isVictory.Value; }
            set { _isVictory = new InputPropertyInfo { Name = "isVictory", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsRadiant
        {
            get { return (QueryBuilderParameter<bool?>)_isRadiant.Value; }
            set { _isRadiant = new InputPropertyInfo { Name = "isRadiant", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MinGameVersionId
        {
            get { return (QueryBuilderParameter<int?>)_minGameVersionId.Value; }
            set { _minGameVersionId = new InputPropertyInfo { Name = "minGameVersionId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MaxGameVersionId
        {
            get { return (QueryBuilderParameter<int?>)_maxGameVersionId.Value; }
            set { _maxGameVersionId = new InputPropertyInfo { Name = "maxGameVersionId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MinImp
        {
            get { return (QueryBuilderParameter<int?>)_minImp.Value; }
            set { _minImp = new InputPropertyInfo { Name = "minImp", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> MaxImp
        {
            get { return (QueryBuilderParameter<int?>)_maxImp.Value; }
            set { _maxImp = new InputPropertyInfo { Name = "maxImp", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<FindMatchPlayerList?>))]
        #endif
        public QueryBuilderParameter<FindMatchPlayerList?> PlayerList
        {
            get { return (QueryBuilderParameter<FindMatchPlayerList?>)_playerList.Value; }
            set { _playerList = new InputPropertyInfo { Name = "playerList", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> Take
        {
            get { return (QueryBuilderParameter<int?>)_take.Value; }
            set { _take = new InputPropertyInfo { Name = "take", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        #endif
        public QueryBuilderParameter<int?> Skip
        {
            get { return (QueryBuilderParameter<int?>)_skip.Value; }
            set { _skip = new InputPropertyInfo { Name = "skip", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> After
        {
            get { return (QueryBuilderParameter<long?>)_after.Value; }
            set { _after = new InputPropertyInfo { Name = "after", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> Before
        {
            get { return (QueryBuilderParameter<long?>)_before.Value; }
            set { _before = new InputPropertyInfo { Name = "before", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<FindMatchPlayerOrderBy?>))]
        #endif
        public QueryBuilderParameter<FindMatchPlayerOrderBy?> OrderBy
        {
            get { return (QueryBuilderParameter<FindMatchPlayerOrderBy?>)_orderBy.Value; }
            set { _orderBy = new InputPropertyInfo { Name = "orderBy", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_matchIds.Name != null) yield return _matchIds;
            if (_leagueId.Name != null) yield return _leagueId;
            if (_leagueIds.Name != null) yield return _leagueIds;
            if (_seriesId.Name != null) yield return _seriesId;
            if (_teamId.Name != null) yield return _teamId;
            if (_teamIdSteamAccount.Name != null) yield return _teamIdSteamAccount;
            if (_isParsed.Name != null) yield return _isParsed;
            if (_startDateTime.Name != null) yield return _startDateTime;
            if (_endDateTime.Name != null) yield return _endDateTime;
            if (_gameModeIds.Name != null) yield return _gameModeIds;
            if (_lobbyTypeIds.Name != null) yield return _lobbyTypeIds;
            if (_gameVersionIds.Name != null) yield return _gameVersionIds;
            if (_regionIds.Name != null) yield return _regionIds;
            if (_rankIds.Name != null) yield return _rankIds;
            if (_bracketIds.Name != null) yield return _bracketIds;
            if (_isStats.Name != null) yield return _isStats;
            if (_heroIds.Name != null) yield return _heroIds;
            if (_laneIds.Name != null) yield return _laneIds;
            if (_roleIds.Name != null) yield return _roleIds;
            if (_positionIds.Name != null) yield return _positionIds;
            if (_awardIds.Name != null) yield return _awardIds;
            if (_isParty.Name != null) yield return _isParty;
            if (_hasAward.Name != null) yield return _hasAward;
            if (_withFriendSteamAccountIds.Name != null) yield return _withFriendSteamAccountIds;
            if (_withEnemySteamAccountIds.Name != null) yield return _withEnemySteamAccountIds;
            if (_withFriendHeroIds.Name != null) yield return _withFriendHeroIds;
            if (_withEnemyHeroIds.Name != null) yield return _withEnemyHeroIds;
            if (_isVictory.Name != null) yield return _isVictory;
            if (_isRadiant.Name != null) yield return _isRadiant;
            if (_minGameVersionId.Name != null) yield return _minGameVersionId;
            if (_maxGameVersionId.Name != null) yield return _maxGameVersionId;
            if (_minImp.Name != null) yield return _minImp;
            if (_maxImp.Name != null) yield return _maxImp;
            if (_playerList.Name != null) yield return _playerList;
            if (_take.Name != null) yield return _take;
            if (_skip.Name != null) yield return _skip;
            if (_after.Name != null) yield return _after;
            if (_before.Name != null) yield return _before;
            if (_orderBy.Name != null) yield return _orderBy;
        }
    }
}
