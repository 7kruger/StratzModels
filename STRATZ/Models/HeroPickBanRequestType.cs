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
    public partial class HeroPickBanRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _matchIds;
        private InputPropertyInfo _leagueId;
        private InputPropertyInfo _seriesId;
        private InputPropertyInfo _teamId;
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
        private InputPropertyInfo _minGameVersionId;
        private InputPropertyInfo _maxGameVersionId;
        private InputPropertyInfo _after;
        private InputPropertyInfo _before;

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

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_matchIds.Name != null) yield return _matchIds;
            if (_leagueId.Name != null) yield return _leagueId;
            if (_seriesId.Name != null) yield return _seriesId;
            if (_teamId.Name != null) yield return _teamId;
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
            if (_minGameVersionId.Name != null) yield return _minGameVersionId;
            if (_maxGameVersionId.Name != null) yield return _maxGameVersionId;
            if (_after.Name != null) yield return _after;
            if (_before.Name != null) yield return _before;
        }
    }
}
