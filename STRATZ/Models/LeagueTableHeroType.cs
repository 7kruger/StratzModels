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
    public partial class LeagueTableHeroType
    {
        public short? HeroId { get; set; }
        public LeagueTableHeroOverviewType Overview { get; set; }
        public LeagueTableHeroStatsType Stats { get; set; }
        public ICollection<LeagueTableHeroPlayersObjectType> Heroes { get; set; }
        public ICollection<LeagueTableHeroLanesObjectType> Lanes { get; set; }
    }
}
