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
    public partial class PlayerPlayedWithProType
    {
        public int? PlayedCount { get; set; }
        public int? TotalCount { get; set; }
        public ICollection<PlayerPlayedWithProPlayerType> Casters { get; set; }
        public ICollection<PlayerPlayedWithProTeamType> Teams { get; set; }
        public ICollection<PlayerPlayedWithProTeamType> InternationalWinners { get; set; }
    }
}
