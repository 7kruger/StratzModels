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
    public partial class PageQuery
    {
        public PagePlayerQuery Player { get; set; }
        public PagePlayersQuery Players { get; set; }
        public PageMatchesQuery Matches { get; set; }
        public PageLeaguesQuery Leagues { get; set; }
        public PageAghanimQuery Aghanim { get; set; }
        public ImpQuery Imp { get; set; }
        public PageDireTideQuery DireTide { get; set; }
        public PageBattlepassQuery BattlePass { get; set; }
        public RoshQuery Rosh { get; set; }
    }
}
