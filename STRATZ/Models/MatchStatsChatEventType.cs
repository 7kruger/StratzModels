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
    public partial class MatchStatsChatEventType
    {
        public int? Time { get; set; }
        public int? Type { get; set; }
        public short? FromHeroId { get; set; }
        public short? ToHeroId { get; set; }
        public short? Value { get; set; }
        public int? PausedTick { get; set; }
        public bool? IsRadiant { get; set; }
    }
}