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
    public partial class MatchPlayerPlaybackDataType
    {
        public ICollection<AbilityLearnEventsType> AbilityLearnEvents { get; set; }
        public ICollection<AbilityUsedEventsType> AbilityUsedEvents { get; set; }
        public ICollection<AbilityActiveListType> AbilityActiveLists { get; set; }
        public ICollection<ItemUsedEventType> ItemUsedEvents { get; set; }
        public ICollection<PlayerUpdatePositionDetailType> PlayerUpdatePositionEvents { get; set; }
        public ICollection<PlayerUpdateGoldDetailType> PlayerUpdateGoldEvents { get; set; }
        public ICollection<PlayerUpdateAttributeDetailType> PlayerUpdateAttributeEvents { get; set; }
        public ICollection<PlayerUpdateLevelDetailType> PlayerUpdateLevelEvents { get; set; }
        public ICollection<PlayerUpdateHealthDetailType> PlayerUpdateHealthEvents { get; set; }
        public ICollection<PlayerUpdateBattleDetailType> PlayerUpdateBattleEvents { get; set; }
        public ICollection<KillDetailType> KillEvents { get; set; }
        public ICollection<DeathDetailType> DeathEvents { get; set; }
        public ICollection<AssistDetailType> AssistEvents { get; set; }
        public ICollection<LastHitDetailType> CsEvents { get; set; }
        public ICollection<GoldDetailType> GoldEvents { get; set; }
        public ICollection<ExperienceDetailType> ExperienceEvents { get; set; }
        public ICollection<HealDetailType> HealEvents { get; set; }
        public ICollection<HeroDamageDetailType> HeroDamageEvents { get; set; }
        public ICollection<TowerDamageDetailType> TowerDamageEvents { get; set; }
        public ICollection<InventoryType> InventoryEvents { get; set; }
        public ICollection<ItemPurchaseType> PurchaseEvents { get; set; }
        public ICollection<BuyBackDetailType> BuyBackEvents { get; set; }
        public ICollection<StreakEventType> StreakEvents { get; set; }
        public ICollection<PlayerRuneDetailType> RuneEvents { get; set; }
        public ICollection<SpiritBearInventoryType> SpiritBearInventoryEvents { get; set; }
    }
}
