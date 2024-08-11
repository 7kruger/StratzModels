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
    public partial class MatchLiveRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _heroId;
        private InputPropertyInfo _leagueId;
        private InputPropertyInfo _isParsing;
        private InputPropertyInfo _isCompleted;
        private InputPropertyInfo _leagueIds;
        private InputPropertyInfo _gameStates;
        private InputPropertyInfo _tiers;
        private InputPropertyInfo _lastPlaybackEventOnly;
        private InputPropertyInfo _orderBy;
        private InputPropertyInfo _isLeague;
        private InputPropertyInfo _take;
        private InputPropertyInfo _skip;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<short?>))]
        #endif
        public QueryBuilderParameter<short?> HeroId
        {
            get { return (QueryBuilderParameter<short?>)_heroId.Value; }
            set { _heroId = new InputPropertyInfo { Name = "heroId", Value = value }; }
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
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsParsing
        {
            get { return (QueryBuilderParameter<bool?>)_isParsing.Value; }
            set { _isParsing = new InputPropertyInfo { Name = "isParsing", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsCompleted
        {
            get { return (QueryBuilderParameter<bool?>)_isCompleted.Value; }
            set { _isCompleted = new InputPropertyInfo { Name = "isCompleted", Value = value }; }
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
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<MatchLiveGameState>>))]
        #endif
        public QueryBuilderParameter<ICollection<MatchLiveGameState>> GameStates
        {
            get { return (QueryBuilderParameter<ICollection<MatchLiveGameState>>)_gameStates.Value; }
            set { _gameStates = new InputPropertyInfo { Name = "gameStates", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<LeagueTier>>))]
        #endif
        public QueryBuilderParameter<ICollection<LeagueTier>> Tiers
        {
            get { return (QueryBuilderParameter<ICollection<LeagueTier>>)_tiers.Value; }
            set { _tiers = new InputPropertyInfo { Name = "tiers", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> LastPlaybackEventOnly
        {
            get { return (QueryBuilderParameter<bool?>)_lastPlaybackEventOnly.Value; }
            set { _lastPlaybackEventOnly = new InputPropertyInfo { Name = "lastPlaybackEventOnly", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<MatchLiveRequestOrderBy?>))]
        #endif
        public QueryBuilderParameter<MatchLiveRequestOrderBy?> OrderBy
        {
            get { return (QueryBuilderParameter<MatchLiveRequestOrderBy?>)_orderBy.Value; }
            set { _orderBy = new InputPropertyInfo { Name = "orderBy", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsLeague
        {
            get { return (QueryBuilderParameter<bool?>)_isLeague.Value; }
            set { _isLeague = new InputPropertyInfo { Name = "isLeague", Value = value }; }
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

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_heroId.Name != null) yield return _heroId;
            if (_leagueId.Name != null) yield return _leagueId;
            if (_isParsing.Name != null) yield return _isParsing;
            if (_isCompleted.Name != null) yield return _isCompleted;
            if (_leagueIds.Name != null) yield return _leagueIds;
            if (_gameStates.Name != null) yield return _gameStates;
            if (_tiers.Name != null) yield return _tiers;
            if (_lastPlaybackEventOnly.Name != null) yield return _lastPlaybackEventOnly;
            if (_orderBy.Name != null) yield return _orderBy;
            if (_isLeague.Name != null) yield return _isLeague;
            if (_take.Name != null) yield return _take;
            if (_skip.Name != null) yield return _skip;
        }
    }
}
