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
    public partial class GuildType
    {
        public int? Id { get; set; }
        public string Motd { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public long? CreatedDateTime { get; set; }
        public byte? Language { get; set; }
        public int? Flags { get; set; }
        public string Logo { get; set; }
        public byte? Region { get; set; }
        public string Description { get; set; }
        public byte? RequiredRank { get; set; }
        public byte? PrimaryColor { get; set; }
        public byte? SecondaryColor { get; set; }
        public byte? Pattern { get; set; }
        public int? Points { get; set; }
        public int? PastWeeklyRank { get; set; }
        public byte? PastWeeklyPercentile { get; set; }
        public byte? CurrentPercentile { get; set; }
        public long? LastUpdateDateTime { get; set; }
        public ICollection<GuildMemberType> Members { get; set; }
        public ICollection<MatchType> Matches { get; set; }
        public byte? MemberCount { get; set; }
        public int? TotalBattlePassLevels { get; set; }
        public byte? Rank { get; set; }
    }
}
