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
    public partial class HeroDamageDetailTypeQueryBuilder : GraphQlQueryBuilder<HeroDamageDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "attacker" },
                new GraphQlFieldMetadata { Name = "target" },
                new GraphQlFieldMetadata { Name = "value" },
                new GraphQlFieldMetadata { Name = "byAbility" },
                new GraphQlFieldMetadata { Name = "byItem" },
                new GraphQlFieldMetadata { Name = "damageType" },
                new GraphQlFieldMetadata { Name = "fromNpc" },
                new GraphQlFieldMetadata { Name = "toNpc" },
                new GraphQlFieldMetadata { Name = "fromIllusion" },
                new GraphQlFieldMetadata { Name = "toIllusion" },
                new GraphQlFieldMetadata { Name = "isPhysicalAttack" },
                new GraphQlFieldMetadata { Name = "isSourceMainHero" },
                new GraphQlFieldMetadata { Name = "isTargetMainHero" }
            };

        protected override string TypeName { get { return "HeroDamageDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroDamageDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public HeroDamageDetailTypeQueryBuilder WithAttacker(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attacker", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptAttacker()
        {
            return ExceptField("attacker");
        }

        public HeroDamageDetailTypeQueryBuilder WithTarget(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("target", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptTarget()
        {
            return ExceptField("target");
        }

        public HeroDamageDetailTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }

        public HeroDamageDetailTypeQueryBuilder WithByAbility(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byAbility", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptByAbility()
        {
            return ExceptField("byAbility");
        }

        public HeroDamageDetailTypeQueryBuilder WithByItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byItem", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptByItem()
        {
            return ExceptField("byItem");
        }

        public HeroDamageDetailTypeQueryBuilder WithDamageType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damageType", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptDamageType()
        {
            return ExceptField("damageType");
        }

        public HeroDamageDetailTypeQueryBuilder WithFromNpc(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fromNpc", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptFromNpc()
        {
            return ExceptField("fromNpc");
        }

        public HeroDamageDetailTypeQueryBuilder WithToNpc(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("toNpc", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptToNpc()
        {
            return ExceptField("toNpc");
        }

        public HeroDamageDetailTypeQueryBuilder WithFromIllusion(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fromIllusion", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptFromIllusion()
        {
            return ExceptField("fromIllusion");
        }

        public HeroDamageDetailTypeQueryBuilder WithToIllusion(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("toIllusion", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptToIllusion()
        {
            return ExceptField("toIllusion");
        }

        public HeroDamageDetailTypeQueryBuilder WithIsPhysicalAttack(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isPhysicalAttack", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptIsPhysicalAttack()
        {
            return ExceptField("isPhysicalAttack");
        }

        public HeroDamageDetailTypeQueryBuilder WithIsSourceMainHero(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isSourceMainHero", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptIsSourceMainHero()
        {
            return ExceptField("isSourceMainHero");
        }

        public HeroDamageDetailTypeQueryBuilder WithIsTargetMainHero(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isTargetMainHero", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDamageDetailTypeQueryBuilder ExceptIsTargetMainHero()
        {
            return ExceptField("isTargetMainHero");
        }
    }
}
