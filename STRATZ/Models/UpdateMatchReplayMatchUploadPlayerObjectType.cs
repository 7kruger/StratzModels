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
    public partial class UpdateMatchReplayMatchUploadPlayerObjectType : IGraphQlInputObject
    {
        private InputPropertyInfo _steamAccountId;
        private InputPropertyInfo _position;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<long?>))]
        #endif
        public QueryBuilderParameter<long?> SteamAccountId
        {
            get { return (QueryBuilderParameter<long?>)_steamAccountId.Value; }
            set { _steamAccountId = new InputPropertyInfo { Name = "steamAccountId", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<MatchPlayerPositionType?>))]
        #endif
        public QueryBuilderParameter<MatchPlayerPositionType?> Position
        {
            get { return (QueryBuilderParameter<MatchPlayerPositionType?>)_position.Value; }
            set { _position = new InputPropertyInfo { Name = "position", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_steamAccountId.Name != null) yield return _steamAccountId;
            if (_position.Name != null) yield return _position;
        }
    }
}
