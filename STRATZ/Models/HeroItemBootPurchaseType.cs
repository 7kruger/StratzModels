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
    public partial class HeroItemBootPurchaseType
    {
        public int? HeroId { get; set; }
        public int? Week { get; set; }
        public RankBracketBasicEnum? BracketBasicIds { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
        public int? ItemId { get; set; }
        public int? Instance { get; set; }
        public long? Time { get; set; }
        public double? TimeAverage { get; set; }
        public long? MatchCount { get; set; }
        public long? WinCount { get; set; }
        public double? WinAverage { get; set; }
        public long? Kills { get; set; }
        public double? KillsAverage { get; set; }
        public long? Deaths { get; set; }
        public double? DeathsAverage { get; set; }
        public long? Assists { get; set; }
        public double? AssistsAverage { get; set; }
        public long? GoldEarned { get; set; }
        public double? GoldEarnedAverage { get; set; }
        public long? Xp { get; set; }
        public double? XpAverage { get; set; }
        public long? Activations { get; set; }
        public double? ActivationsAverage { get; set; }
        public long? ActivationTime { get; set; }
        public double? ActivationsTimeAverage { get; set; }
    }
}
