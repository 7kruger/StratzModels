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
    public partial class HeroAbilityMaxType
    {
        public int? HeroId { get; set; }
        public int? Week { get; set; }
        public RankBracketBasicEnum? BracketBasicIds { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
        public int? AbilityId { get; set; }
        public int? Level { get; set; }
        public long? MatchCount { get; set; }
        public long? WinCount { get; set; }
    }
}
