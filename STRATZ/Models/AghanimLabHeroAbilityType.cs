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
    public partial class AghanimLabHeroAbilityType
    {
        public AghanimLabMatchDifficultyEnum? Difficulty { get; set; }
        public short? HeroId { get; set; }
        public short? CustomAbilityId { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? PickCount { get; set; }
    }
}