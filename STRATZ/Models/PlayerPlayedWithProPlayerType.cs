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
    public partial class PlayerPlayedWithProPlayerType
    {
        public long? SteamId { get; set; }
        public SteamAccountType SteamAccount { get; set; }
        public PlayerPlayedWithProPlayerMatchType With { get; set; }
        public PlayerPlayedWithProPlayerMatchType Vs { get; set; }
    }
}
