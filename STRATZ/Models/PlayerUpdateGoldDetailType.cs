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
    public partial class PlayerUpdateGoldDetailType
    {
        public int? Time { get; set; }
        public int? Gold { get; set; }
        public int? UnreliableGold { get; set; }
        public int? Networth { get; set; }
        public int? NetworthDifference { get; set; }
    }
}
