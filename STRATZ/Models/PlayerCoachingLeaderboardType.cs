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
    public partial class PlayerCoachingLeaderboardType
    {
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public int? Rating { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public long? FirstMatchDateTime { get; set; }
        public long? LastMatchDateTime { get; set; }
    }
}
