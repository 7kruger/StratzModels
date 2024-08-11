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
    public partial class PlayerLeaderBoardByHeroType
    {
        public short? HeroId { get; set; }
        public byte? SeasonBracket { get; set; }
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public byte? ImpAverage { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
        public byte? Wins { get; set; }
        public byte? Losses { get; set; }
        public byte? WinStreak { get; set; }
        public byte? RegionId { get; set; }
        public short? ChangeInRanking { get; set; }
        public long? CreatedDateTime { get; set; }
    }
}
