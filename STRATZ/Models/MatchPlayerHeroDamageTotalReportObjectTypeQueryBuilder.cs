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
    public partial class MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "physicalDamage" },
                new GraphQlFieldMetadata { Name = "magicalDamage" },
                new GraphQlFieldMetadata { Name = "pureDamage" },
                new GraphQlFieldMetadata { Name = "selfHeal" },
                new GraphQlFieldMetadata { Name = "allyHeal" },
                new GraphQlFieldMetadata { Name = "stunCount" },
                new GraphQlFieldMetadata { Name = "stunDuration" },
                new GraphQlFieldMetadata { Name = "disableCount" },
                new GraphQlFieldMetadata { Name = "disableDuration" },
                new GraphQlFieldMetadata { Name = "slowCount" },
                new GraphQlFieldMetadata { Name = "slowDuration" }
            };

        protected override string TypeName { get { return "MatchPlayerHeroDamageTotalReportObjectType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithPhysicalDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("physicalDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptPhysicalDamage()
        {
            return ExceptField("physicalDamage");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithMagicalDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("magicalDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptMagicalDamage()
        {
            return ExceptField("magicalDamage");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithPureDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("pureDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptPureDamage()
        {
            return ExceptField("pureDamage");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithSelfHeal(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("selfHeal", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptSelfHeal()
        {
            return ExceptField("selfHeal");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithAllyHeal(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("allyHeal", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptAllyHeal()
        {
            return ExceptField("allyHeal");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithStunCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stunCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptStunCount()
        {
            return ExceptField("stunCount");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithStunDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stunDuration", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptStunDuration()
        {
            return ExceptField("stunDuration");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithDisableCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("disableCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptDisableCount()
        {
            return ExceptField("disableCount");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithDisableDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("disableDuration", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptDisableDuration()
        {
            return ExceptField("disableDuration");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithSlowCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("slowCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptSlowCount()
        {
            return ExceptField("slowCount");
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder WithSlowDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("slowDuration", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerHeroDamageTotalReportObjectTypeQueryBuilder ExceptSlowDuration()
        {
            return ExceptField("slowDuration");
        }
    }
}
