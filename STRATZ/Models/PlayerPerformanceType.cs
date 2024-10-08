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
    public partial class PlayerPerformanceType
    {
        public ICollection<short> HeroId { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? Streak { get; set; }
        public int? MaxStreak { get; set; }
        public int? Imp { get; set; }
        public int? Rank { get; set; }
        public int? MmrTier { get; set; }
        public int? MmrBracket { get; set; }
        public int? AwardMatchCount { get; set; }
        public int? MvpCount { get; set; }
        public int? TopCoreCount { get; set; }
        public int? TopSupportCount { get; set; }
        public int? Kills { get; set; }
        public double? KillsAverage { get; set; }
        public int? Deaths { get; set; }
        public double? DeathsAverage { get; set; }
        public int? Assists { get; set; }
        public double? AssistsAverage { get; set; }
        public int? Cs { get; set; }
        public double? CsAverage { get; set; }
        public int? Gpm { get; set; }
        public double? GpmAverage { get; set; }
        public int? Xpm { get; set; }
        public double? XpmAverage { get; set; }
        public PlayerPerformanceCompositionType Composition { get; set; }
        public ICollection<PlayerPerformancePositionType> Position { get; set; }
        public ICollection<int> PickOrder { get; set; }
    }
}
