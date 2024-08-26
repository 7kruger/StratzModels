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
    public partial class AbilityStatType
    {
        public short? AbilityId { get; set; }
        public int? Type { get; set; }
        public long? Behavior { get; set; }
        public long? UnitTargetType { get; set; }
        public int? UnitTargetTeam { get; set; }
        public long? UnitTargetFlags { get; set; }
        public int? UnitDamageType { get; set; }
        public int? SpellImmunity { get; set; }
        public decimal? ModifierSupportValue { get; set; }
        public short? ModifierSupportBonus { get; set; }
        public bool? IsOnCastbar { get; set; }
        public bool? IsOnLearnbar { get; set; }
        public short? FightRecapLevel { get; set; }
        public bool? IsGrantedByScepter { get; set; }
        public bool? HasScepterUpgrade { get; set; }
        public byte? MaxLevel { get; set; }
        public byte? LevelsBetweenUpgrades { get; set; }
        public byte? RequiredLevel { get; set; }
        public string HotKeyOverride { get; set; }
        public bool? DisplayAdditionalHeroes { get; set; }
        public ICollection<int> CastRange { get; set; }
        public ICollection<int> CastRangeBuffer { get; set; }
        public ICollection<decimal> CastPoint { get; set; }
        public ICollection<decimal> ChannelTime { get; set; }
        public ICollection<decimal> Cooldown { get; set; }
        public ICollection<decimal> Damage { get; set; }
        public ICollection<decimal> ManaCost { get; set; }
        public bool? IsUltimate { get; set; }
        public string Duration { get; set; }
        public string Charges { get; set; }
        public string ChargeRestoreTime { get; set; }
        public bool? HasShardUpgrade { get; set; }
        public bool? IsGrantedByShard { get; set; }
        public AbilityDispellEnum? Dispellable { get; set; }
        public short? LinkedAbilityId { get; set; }
        public bool? IsInnate { get; set; }
    }
}
