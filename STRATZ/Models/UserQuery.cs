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
    public partial class UserQuery
    {
        public UserType Profile { get; set; }
        public UserHomepageType Homepage { get; set; }
        public ICollection<FollowerType> Followers { get; set; }
        public ICollection<FollowerType> Following { get; set; }
        public FeedResponseType Feed { get; set; }
    }
}
