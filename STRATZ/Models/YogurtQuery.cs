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
    public partial class YogurtQuery
    {
        public MatchReplayUploadTeamType Team { get; set; }
        public ICollection<MatchReplayUploadTeamType> Teams { get; set; }
        public MatchReplayUploadTeamType DefaultTeam { get; set; }
        public ICollection<MatchReplayUploadTeamMemberType> TeamMembers { get; set; }
        public MatchReplayUploadOverviewType Overview { get; set; }
        public ICollection<MatchReplayUploadHeroSummaryType> HeroSummary { get; set; }
    }
}
