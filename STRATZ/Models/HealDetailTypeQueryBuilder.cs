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
    public partial class HealDetailTypeQueryBuilder : GraphQlQueryBuilder<HealDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "attacker" },
                new GraphQlFieldMetadata { Name = "target" },
                new GraphQlFieldMetadata { Name = "value" },
                new GraphQlFieldMetadata { Name = "byAbility" },
                new GraphQlFieldMetadata { Name = "byItem" }
            };

        protected override string TypeName { get { return "HealDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HealDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public HealDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public HealDetailTypeQueryBuilder WithAttacker(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attacker", alias, new GraphQlDirective[] { include, skip });
        }

        public HealDetailTypeQueryBuilder ExceptAttacker()
        {
            return ExceptField("attacker");
        }

        public HealDetailTypeQueryBuilder WithTarget(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("target", alias, new GraphQlDirective[] { include, skip });
        }

        public HealDetailTypeQueryBuilder ExceptTarget()
        {
            return ExceptField("target");
        }

        public HealDetailTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public HealDetailTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }

        public HealDetailTypeQueryBuilder WithByAbility(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byAbility", alias, new GraphQlDirective[] { include, skip });
        }

        public HealDetailTypeQueryBuilder ExceptByAbility()
        {
            return ExceptField("byAbility");
        }

        public HealDetailTypeQueryBuilder WithByItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byItem", alias, new GraphQlDirective[] { include, skip });
        }

        public HealDetailTypeQueryBuilder ExceptByItem()
        {
            return ExceptField("byItem");
        }
    }
}
