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
    public partial class ServerStatusType
    {
        public bool? IsRedisOnline { get; set; }
        public SteamApiDetailType SteamApiDetail { get; set; }
        public RabbitDetailType RabbitDetail { get; set; }
    }
}
