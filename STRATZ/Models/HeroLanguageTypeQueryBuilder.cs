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
    public partial class HeroLanguageTypeQueryBuilder : GraphQlQueryBuilder<HeroLanguageTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "displayName" },
                new GraphQlFieldMetadata { Name = "lore" },
                new GraphQlFieldMetadata { Name = "hype" }
            };

        protected override string TypeName { get { return "HeroLanguageType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroLanguageTypeQueryBuilder WithDisplayName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displayName", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLanguageTypeQueryBuilder ExceptDisplayName()
        {
            return ExceptField("displayName");
        }

        public HeroLanguageTypeQueryBuilder WithLore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lore", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLanguageTypeQueryBuilder ExceptLore()
        {
            return ExceptField("lore");
        }

        public HeroLanguageTypeQueryBuilder WithHype(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hype", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroLanguageTypeQueryBuilder ExceptHype()
        {
            return ExceptField("hype");
        }
    }
}
