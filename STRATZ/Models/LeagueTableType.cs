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
    public partial class LeagueTableType
    {
        public int? LeagueId { get; set; }
        public ICollection<LeagueTableTeamType> TableTeams { get; set; }
        public ICollection<LeagueTableHeroType> TableHeroes { get; set; }
        public ICollection<LeagueTablePlayerType> TablePlayers { get; set; }
    }
}
