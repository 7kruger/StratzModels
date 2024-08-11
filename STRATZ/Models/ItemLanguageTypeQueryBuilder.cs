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
    public partial class ItemLanguageTypeQueryBuilder : GraphQlQueryBuilder<ItemLanguageTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "displayName" },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "lore", IsComplex = true },
                new GraphQlFieldMetadata { Name = "notes", IsComplex = true },
                new GraphQlFieldMetadata { Name = "attributes", IsComplex = true }
            };

        protected override string TypeName { get { return "ItemLanguageType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ItemLanguageTypeQueryBuilder WithDisplayName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displayName", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemLanguageTypeQueryBuilder ExceptDisplayName()
        {
            return ExceptField("displayName");
        }

        public ItemLanguageTypeQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemLanguageTypeQueryBuilder ExceptDescription()
        {
            return ExceptField("description");
        }

        public ItemLanguageTypeQueryBuilder WithLore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lore", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemLanguageTypeQueryBuilder ExceptLore()
        {
            return ExceptField("lore");
        }

        public ItemLanguageTypeQueryBuilder WithNotes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("notes", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemLanguageTypeQueryBuilder ExceptNotes()
        {
            return ExceptField("notes");
        }

        public ItemLanguageTypeQueryBuilder WithAttributes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attributes", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemLanguageTypeQueryBuilder ExceptAttributes()
        {
            return ExceptField("attributes");
        }
    }
}