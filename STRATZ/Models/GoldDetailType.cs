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
    public partial class GoldDetailType
    {
        public int? Time { get; set; }
        public int? Amount { get; set; }
        public GoldReason? Reason { get; set; }
        public int? NpcId { get; set; }
        public bool? IsValidForStats { get; set; }
    }
}
