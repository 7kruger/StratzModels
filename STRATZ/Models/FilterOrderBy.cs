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
    public enum FilterOrderBy
    {
        [EnumMember(Value = "LAST_MATCH_TIME")] LastMatchTime,
        [EnumMember(Value = "ID")] Id,
        [EnumMember(Value = "NONE")] None,
        [EnumMember(Value = "START_DATE_THEN_TIER")] StartDateThenTier,
        [EnumMember(Value = "LAST_MATCH_TIME_THEN_TIER")] LastMatchTimeThenTier
    }
}
