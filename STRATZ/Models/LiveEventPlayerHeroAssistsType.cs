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
    public partial class LiveEventPlayerHeroAssistsType : ILiveEventType
    {
        public SteamAccountType SteamAccount { get; set; }
        public MatchType Match { get; set; }
        public short? HeroId { get; set; }
        public byte? AssistCount { get; set; }
    }
}
