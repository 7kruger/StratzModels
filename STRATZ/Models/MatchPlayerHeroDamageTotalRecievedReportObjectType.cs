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
    public partial class MatchPlayerHeroDamageTotalRecievedReportObjectType
    {
        public int? PhysicalDamage { get; set; }
        public int? MagicalDamage { get; set; }
        public int? PureDamage { get; set; }
        public int? Heal { get; set; }
        public int? StunCount { get; set; }
        public int? StunDuration { get; set; }
        public int? DisableCount { get; set; }
        public int? DisableDuration { get; set; }
        public int? SlowCount { get; set; }
        public int? SlowDuration { get; set; }
    }
}
