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
    public partial class PageAghanimQuery
    {
        public AghanimLabMatchType Match { get; set; }
        public ICollection<AghanimLabMatchType> Matches { get; set; }
        public ICollection<AghanimLabHeroCompositionType> HeroCompositions { get; set; }
        public AghanimLabHeroCompositionType HeroComposition { get; set; }
        public AghanimLabHeroWinRateType WinRate { get; set; }
        public ICollection<AghanimLabHeroAbilityType> HeroAbility { get; set; }
        public ICollection<AghanimLabRoomType> Room { get; set; }
        public ICollection<Ti2020CustomGameRoomModifierType> RoomModifier { get; set; }
    }
}