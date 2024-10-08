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
    public partial class UpdateFollowerRequestType : IGraphQlInputObject
    {
        private InputPropertyInfo _feedLevel;
        private InputPropertyInfo _emailLevel;
        private InputPropertyInfo _dailyEmail;
        private InputPropertyInfo _weeklyEmail;
        private InputPropertyInfo _monthlyEmail;
        private InputPropertyInfo _overrideAllUsers;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<byte?>))]
        #endif
        public QueryBuilderParameter<byte?> FeedLevel
        {
            get { return (QueryBuilderParameter<byte?>)_feedLevel.Value; }
            set { _feedLevel = new InputPropertyInfo { Name = "feedLevel", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<byte?>))]
        #endif
        public QueryBuilderParameter<byte?> EmailLevel
        {
            get { return (QueryBuilderParameter<byte?>)_emailLevel.Value; }
            set { _emailLevel = new InputPropertyInfo { Name = "emailLevel", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> DailyEmail
        {
            get { return (QueryBuilderParameter<bool?>)_dailyEmail.Value; }
            set { _dailyEmail = new InputPropertyInfo { Name = "dailyEmail", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> WeeklyEmail
        {
            get { return (QueryBuilderParameter<bool?>)_weeklyEmail.Value; }
            set { _weeklyEmail = new InputPropertyInfo { Name = "weeklyEmail", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> MonthlyEmail
        {
            get { return (QueryBuilderParameter<bool?>)_monthlyEmail.Value; }
            set { _monthlyEmail = new InputPropertyInfo { Name = "monthlyEmail", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        #endif
        public QueryBuilderParameter<bool?> OverrideAllUsers
        {
            get { return (QueryBuilderParameter<bool?>)_overrideAllUsers.Value; }
            set { _overrideAllUsers = new InputPropertyInfo { Name = "overrideAllUsers", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_feedLevel.Name != null) yield return _feedLevel;
            if (_emailLevel.Name != null) yield return _emailLevel;
            if (_dailyEmail.Name != null) yield return _dailyEmail;
            if (_weeklyEmail.Name != null) yield return _weeklyEmail;
            if (_monthlyEmail.Name != null) yield return _monthlyEmail;
            if (_overrideAllUsers.Name != null) yield return _overrideAllUsers;
        }
    }
}
