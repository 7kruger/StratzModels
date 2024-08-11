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
    public partial class FollowerType
    {
        public Guid? CaptainJackIdentityId { get; set; }
        public CaptainJackIdentityPublicProfileType CaptainJackIdentityProfile { get; set; }
        public long? SteamAccountId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public byte? FeedLevel { get; set; }
        public byte? EmailLevel { get; set; }
        public bool? DailyEmail { get; set; }
        public bool? WeeklyEmail { get; set; }
        public bool? MonthlyEmail { get; set; }
        public bool? IsFavorite { get; set; }
        public long? LastEmail { get; set; }
        public bool? DidManualUpdate { get; set; }
    }
}
