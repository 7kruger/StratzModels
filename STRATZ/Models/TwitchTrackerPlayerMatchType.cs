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
    public partial class TwitchTrackerPlayerMatchType
    {
        public long? MatchId { get; set; }
        public int? HeroId { get; set; }
        public MatchLaneType? Lane { get; set; }
        public MatchPlayerRoleType? Role { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
        public short? KillCount { get; set; }
        public short? DeathCount { get; set; }
        public short? AssistCount { get; set; }
        public long? EndDateTime { get; set; }
        public bool? IsVictory { get; set; }
        public byte? Award { get; set; }
    }
}
