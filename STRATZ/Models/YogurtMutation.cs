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
    public partial class YogurtMutation
    {
        public MatchReplayUploadTeamType CreateTeam { get; set; }
        public bool? UpdateTeam { get; set; }
        public bool? AddTeamMember { get; set; }
        public bool? UpdateTeamMember { get; set; }
        public bool? SetTeamMemberDefaultTeam { get; set; }
        public bool? RemoveTeamMember { get; set; }
        public bool? Update { get; set; }
        public bool? Validate { get; set; }
        public bool? Invalidate { get; set; }
        public bool? Delete { get; set; }
        public bool? LinkSeriesId { get; set; }
        public bool? RemoveSeriesId { get; set; }
        public bool? ImportMatch { get; set; }
        public bool? ImportPickBans { get; set; }
    }
}
