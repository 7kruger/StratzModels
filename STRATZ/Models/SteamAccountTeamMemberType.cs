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
    public partial class SteamAccountTeamMemberType
    {
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public PlayerType Player { get; set; }
        public int? TeamId { get; set; }
        public long? FirstMatchId { get; set; }
        public long? FirstMatchDateTime { get; set; }
        public long? LastMatchId { get; set; }
        public long? LastMatchDateTime { get; set; }
        public TeamType Team { get; set; }
    }
}
