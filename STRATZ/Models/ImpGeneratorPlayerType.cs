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
    public partial class ImpGeneratorPlayerType
    {
        public ICollection<decimal> WinChance { get; set; }
        public ICollection<ICollection<decimal>> WinRateByPlayerMinuteValues { get; set; }
        public ICollection<ImpGeneratorPlayerEventType> Events { get; set; }
        public ICollection<ICollection<int>> ImpValues { get; set; }
    }
}