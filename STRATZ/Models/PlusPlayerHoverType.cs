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
    public partial class PlusPlayerHoverType
    {
        public SteamAccountType SteamAccount { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? CoreCount { get; set; }
        public int? SupportCount { get; set; }
        public int? Imp { get; set; }
        public ICollection<PlusPlayerHoverHeroType> Heroes { get; set; }
        public byte? Activity { get; set; }
        public ICollection<string> LanguageCode { get; set; }
        public ICollection<PlusPlayerHoverPlayerType> Friends { get; set; }
        public ICollection<PlusPlayerHoverPlayerType> Enemies { get; set; }
        public long? LastMatchDateTime { get; set; }
        public ICollection<short> HeroesExperience { get; set; }
        public short? BehaviorScore { get; set; }
    }
}
