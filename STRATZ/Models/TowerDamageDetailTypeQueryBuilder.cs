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
    public partial class TowerDamageDetailTypeQueryBuilder : GraphQlQueryBuilder<TowerDamageDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "attacker" },
                new GraphQlFieldMetadata { Name = "npcId" },
                new GraphQlFieldMetadata { Name = "damage" },
                new GraphQlFieldMetadata { Name = "byAbility" },
                new GraphQlFieldMetadata { Name = "byItem" },
                new GraphQlFieldMetadata { Name = "fromNpc" }
            };

        protected override string TypeName { get { return "TowerDamageDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public TowerDamageDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public TowerDamageDetailTypeQueryBuilder WithAttacker(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attacker", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptAttacker()
        {
            return ExceptField("attacker");
        }

        public TowerDamageDetailTypeQueryBuilder WithNpcId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("npcId", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptNpcId()
        {
            return ExceptField("npcId");
        }

        public TowerDamageDetailTypeQueryBuilder WithDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damage", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptDamage()
        {
            return ExceptField("damage");
        }

        public TowerDamageDetailTypeQueryBuilder WithByAbility(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byAbility", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptByAbility()
        {
            return ExceptField("byAbility");
        }

        public TowerDamageDetailTypeQueryBuilder WithByItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byItem", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptByItem()
        {
            return ExceptField("byItem");
        }

        public TowerDamageDetailTypeQueryBuilder WithFromNpc(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fromNpc", alias, new GraphQlDirective[] { include, skip });
        }

        public TowerDamageDetailTypeQueryBuilder ExceptFromNpc()
        {
            return ExceptField("fromNpc");
        }
    }
}
