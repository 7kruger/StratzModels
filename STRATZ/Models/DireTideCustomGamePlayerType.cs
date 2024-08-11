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
    public partial class DireTideCustomGamePlayerType
    {
        public long? MatchId { get; set; }
        public byte? PlayerSlot { get; set; }
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public bool? IsVictory { get; set; }
        public short? HeroId { get; set; }
        public HeroType Hero { get; set; }
        public byte? Kills { get; set; }
        public byte? Deaths { get; set; }
        public byte? Assists { get; set; }
        public byte? LeaverStatus { get; set; }
        public short? NumLastHits { get; set; }
        public short? GoldPerMinute { get; set; }
        public int? GoldSpent { get; set; }
        public byte? Level { get; set; }
        public int? HeroDamage { get; set; }
        public int? HeroHealing { get; set; }
        public int? Networth { get; set; }
        public short? Item0Id { get; set; }
        public short? Item1Id { get; set; }
        public short? Item2Id { get; set; }
        public short? Item3Id { get; set; }
        public short? Item4Id { get; set; }
        public short? Item5Id { get; set; }
        public short? Backpack0Id { get; set; }
        public short? Backpack1Id { get; set; }
        public short? Backpack2Id { get; set; }
        public short? Neutral0Id { get; set; }
        public byte? PartyId { get; set; }
        public short? CandyLost { get; set; }
        public short? CandyPickedUp { get; set; }
        public short? CandyScored { get; set; }
    }
}