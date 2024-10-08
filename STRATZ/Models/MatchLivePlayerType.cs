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
    public partial class MatchLivePlayerType
    {
        public long? MatchId { get; set; }
        public short? HeroId { get; set; }
        public HeroType Hero { get; set; }
        public string Name { get; set; }
        public byte? PlayerSlot { get; set; }
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public bool? IsRadiant { get; set; }
        public byte? NumKills { get; set; }
        public byte? NumDeaths { get; set; }
        public byte? NumAssists { get; set; }
        public byte? LeaverStatus { get; set; }
        public ushort? NumLastHits { get; set; }
        public ushort? NumDenies { get; set; }
        public ushort? GoldPerMinute { get; set; }
        public ushort? ExperiencePerMinute { get; set; }
        public byte? Level { get; set; }
        public int? Gold { get; set; }
        public int? GoldSpent { get; set; }
        public int? HeroDamage { get; set; }
        public int? TowerDamage { get; set; }
        public short? ItemId0 { get; set; }
        public short? ItemId1 { get; set; }
        public short? ItemId2 { get; set; }
        public short? ItemId3 { get; set; }
        public short? ItemId4 { get; set; }
        public short? ItemId5 { get; set; }
        public short? BackpackId0 { get; set; }
        public short? BackpackId1 { get; set; }
        public short? BackpackId2 { get; set; }
        public MatchPlayerLivePlaybackDataType PlaybackData { get; set; }
        public int? Networth { get; set; }
        public short? RespawnTimer { get; set; }
        public short? UltimateCooldown { get; set; }
        public short? UltimateState { get; set; }
        public ICollection<MatchLivePlayerImpDetailType> ImpPerMinute { get; set; }
        public short? GameVersionId { get; set; }
        public decimal? BaseWinRateValue { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
    }
}
