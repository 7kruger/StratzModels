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
    public partial class DotaNextQuery
    {
        public ICollection<DotaNextWithAllyType> Enemy { get; set; }
        public ICollection<DotaNextWithAllyType> Ally { get; set; }
        public ICollection<ICollection<MatchPlayerItemPurchaseEventType>> PlayerHero { get; set; }
    }
}
