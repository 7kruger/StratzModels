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
    public partial class ConstantQuery
    {
        public HeroType Hero { get; set; }
        public ICollection<HeroType> Heroes { get; set; }
        public ICollection<RoleType> Roles { get; set; }
        public ItemType Item { get; set; }
        public ICollection<ItemType> Items { get; set; }
        public AbilityType Ability { get; set; }
        public ICollection<AbilityType> Abilities { get; set; }
        public ICollection<GameModeType> GameModes { get; set; }
        public ICollection<LobbyTypeType> LobbyTypes { get; set; }
        public ICollection<ClusterType> Clusters { get; set; }
        public ICollection<RegionType> Regions { get; set; }
        public GameVersionType GameVersion { get; set; }
        public ICollection<GameVersionType> GameVersions { get; set; }
        public NpcType Npc { get; set; }
        public ICollection<NpcType> Npcs { get; set; }
        public ICollection<PatchNoteLanguageType> PatchNotes { get; set; }
        public ICollection<AbilityCustomGameType> CustomAbilities { get; set; }
        public ICollection<ModifierType> Modifiers { get; set; }
        public ICollection<ProSteamAccountType> ProSteamAccounts { get; set; }
        public ICollection<TeamType> PopularTeamIds { get; set; }
        public ICollection<SteamAccountType> Casters { get; set; }
        public ICollection<SteamAccountType> TiWinners { get; set; }
        public ICollection<FacetType> Facets { get; set; }
    }
}
