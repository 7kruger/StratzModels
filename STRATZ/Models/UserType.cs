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
    public partial class UserType
    {
        public CaptainJackIdentityPrivateProfileType Profile { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public MatchType RecentMatch { get; set; }
        public int? FollowingCount { get; set; }
        public int? FollowerCount { get; set; }
        public int? FollowingLeagueCount { get; set; }
        public int? FollowingTeamCount { get; set; }
        public ICollection<CaptainJackIdentityApiApplicationType> StratzApiApplications { get; set; }
    }
}
