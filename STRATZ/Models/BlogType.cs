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
    public partial class BlogType
    {
        public byte? Id { get; set; }
        public Guid? CaptainJackIdentityId { get; set; }
        public string Title { get; set; }
        public string BannerImageUrl { get; set; }
        public string Data { get; set; }
        public DateTime? LiveDateTime { get; set; }
        public string Link { get; set; }
    }
}
