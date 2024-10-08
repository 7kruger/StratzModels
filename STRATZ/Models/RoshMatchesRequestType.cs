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
    public partial class RoshMatchesRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _startDateTime;
        private InputPropertyInfo _endDateTime;
        private InputPropertyInfo _isUserActionFirst;
        private InputPropertyInfo _isRadiant;
        private InputPropertyInfo _bracketIds;
        private InputPropertyInfo _isCompleted;

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
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> IsUserActionFirst
        {
            get { return (QueryBuilderParameter<bool?>)_isUserActionFirst.Value; }
            set { _isUserActionFirst = new InputPropertyInfo { Name = "isUserActionFirst", Value = value }; }
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
        public QueryBuilderParameter<bool?> IsCompleted
        {
            get { return (QueryBuilderParameter<bool?>)_isCompleted.Value; }
            set { _isCompleted = new InputPropertyInfo { Name = "isCompleted", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_startDateTime.Name != null) yield return _startDateTime;
            if (_endDateTime.Name != null) yield return _endDateTime;
            if (_isUserActionFirst.Name != null) yield return _isUserActionFirst;
            if (_isRadiant.Name != null) yield return _isRadiant;
            if (_bracketIds.Name != null) yield return _bracketIds;
            if (_isCompleted.Name != null) yield return _isCompleted;
        }
    }
}
