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
    public partial class ItemLanguageType
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public ICollection<string> Lore { get; set; }
        public ICollection<string> Notes { get; set; }
        public ICollection<string> Attributes { get; set; }
    }
}
