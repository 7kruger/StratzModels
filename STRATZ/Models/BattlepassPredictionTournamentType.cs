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
    public partial class BattlepassPredictionTournamentType
    {
        public ICollection<BattlepassPredictionIdValueType> HeroesPicked { get; set; }
        public ICollection<BattlepassPredictionIdValueType> HeroesBanned { get; set; }
        public ICollection<BattlepassPredictionIdValueType> TotalKills { get; set; }
        public ICollection<BattlepassPredictionIdValueType> LongestGame { get; set; }
        public ICollection<BattlepassPredictionIdValueType> SoloKills { get; set; }
        public ICollection<BattlepassPredictionIdValueType> SoloDeaths { get; set; }
        public ICollection<BattlepassPredictionIdValueType> SoloAssists { get; set; }
        public ICollection<BattlepassPredictionIdValueType> SoloGoldPerMinute { get; set; }
    }
}
