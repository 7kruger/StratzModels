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
    public partial class PlayerBreakdownType
    {
        public PlayerBreakdownObjectType Matches { get; set; }
        public ICollection<PlayerBreakdownObjectType> IsStatsMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> RankMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> LobbyMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> GameModeMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> FactionMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> RegionMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> LaneMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> RoleMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> PartyMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> ImpMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> DurationMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> HeroAttributeMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> DayOfWeekMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> TimeOfDayMatches { get; set; }
        public ICollection<PlayerBreakdownObjectType> WeekEndMatches { get; set; }
    }
}
