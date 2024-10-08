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
    public partial class MatchPlaybackDataType
    {
        public ICollection<MatchPlaybackDataCourierEventType> CourierEvents { get; set; }
        public ICollection<MatchPlaybackDataRuneEventType> RuneEvents { get; set; }
        public ICollection<MatchPlaybackDataWardEventType> WardEvents { get; set; }
        public ICollection<MatchPlaybackDataBuildingEventType> BuildingEvents { get; set; }
        public ICollection<MatchPlaybackDataTowerDeathEventType> TowerDeathEvents { get; set; }
        public ICollection<MatchPlaybackDataRoshanEventType> RoshanEvents { get; set; }
        public long? RadiantCaptainHeroId { get; set; }
        public long? DireCaptainHeroId { get; set; }
    }
}
