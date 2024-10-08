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
    public partial class HeroStatsHeroDryadTypeQueryBuilder : GraphQlQueryBuilder<HeroStatsHeroDryadTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId1" },
                new GraphQlFieldMetadata { Name = "heroId2" },
                new GraphQlFieldMetadata { Name = "week" },
                new GraphQlFieldMetadata { Name = "bracketBasicIds" },
                new GraphQlFieldMetadata { Name = "kills" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "deaths" },
                new GraphQlFieldMetadata { Name = "assists" },
                new GraphQlFieldMetadata { Name = "networth" },
                new GraphQlFieldMetadata { Name = "duration" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "firstBloodTime" },
                new GraphQlFieldMetadata { Name = "cs" },
                new GraphQlFieldMetadata { Name = "dn" },
                new GraphQlFieldMetadata { Name = "goldEarned" },
                new GraphQlFieldMetadata { Name = "xp" },
                new GraphQlFieldMetadata { Name = "heroDamage" },
                new GraphQlFieldMetadata { Name = "towerDamage" },
                new GraphQlFieldMetadata { Name = "heroHealing" },
                new GraphQlFieldMetadata { Name = "level" },
                new GraphQlFieldMetadata { Name = "synergy" },
                new GraphQlFieldMetadata { Name = "winRateHeroId1" },
                new GraphQlFieldMetadata { Name = "winRateHeroId2" },
                new GraphQlFieldMetadata { Name = "winsAverage" }
            };

        protected override string TypeName { get { return "HeroStatsHeroDryadType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroStatsHeroDryadTypeQueryBuilder WithHeroId1(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId1", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptHeroId1()
        {
            return ExceptField("heroId1");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithHeroId2(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId2", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptHeroId2()
        {
            return ExceptField("heroId2");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("kills", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptKills()
        {
            return ExceptField("kills");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deaths", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptDeaths()
        {
            return ExceptField("deaths");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("assists", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptAssists()
        {
            return ExceptField("assists");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithNetworth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("networth", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptNetworth()
        {
            return ExceptField("networth");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("duration", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptDuration()
        {
            return ExceptField("duration");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithFirstBloodTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstBloodTime", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptFirstBloodTime()
        {
            return ExceptField("firstBloodTime");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithCs(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cs", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptCs()
        {
            return ExceptField("cs");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithDn(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dn", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptDn()
        {
            return ExceptField("dn");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithGoldEarned(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldEarned", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptGoldEarned()
        {
            return ExceptField("goldEarned");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithXp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("xp", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptXp()
        {
            return ExceptField("xp");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithHeroDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptHeroDamage()
        {
            return ExceptField("heroDamage");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithTowerDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("towerDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptTowerDamage()
        {
            return ExceptField("towerDamage");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithHeroHealing(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroHealing", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptHeroHealing()
        {
            return ExceptField("heroHealing");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithSynergy(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("synergy", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptSynergy()
        {
            return ExceptField("synergy");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithWinRateHeroId1(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winRateHeroId1", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptWinRateHeroId1()
        {
            return ExceptField("winRateHeroId1");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithWinRateHeroId2(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winRateHeroId2", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptWinRateHeroId2()
        {
            return ExceptField("winRateHeroId2");
        }

        public HeroStatsHeroDryadTypeQueryBuilder WithWinsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroStatsHeroDryadTypeQueryBuilder ExceptWinsAverage()
        {
            return ExceptField("winsAverage");
        }
    }
}
