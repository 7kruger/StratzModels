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
    public partial class AghanimLabHeroCompositionType
    {
        public AghanimLabMatchDifficultyEnum? Difficulty { get; set; }
        public short? HeroId1 { get; set; }
        public short? HeroId2 { get; set; }
        public short? HeroId3 { get; set; }
        public short? HeroId4 { get; set; }
        public int? MatchCount { get; set; }
        public int? WinCount { get; set; }
        public int? Duration { get; set; }
        public double? WilsonScore { get; set; }
    }
}
