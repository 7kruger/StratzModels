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
    public partial class ItemComponentTypeQueryBuilder : GraphQlQueryBuilder<ItemComponentTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "index" },
                new GraphQlFieldMetadata { Name = "componentId" }
            };

        protected override string TypeName { get { return "ItemComponentType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ItemComponentTypeQueryBuilder WithIndex(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("index", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemComponentTypeQueryBuilder ExceptIndex()
        {
            return ExceptField("index");
        }

        public ItemComponentTypeQueryBuilder WithComponentId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("componentId", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemComponentTypeQueryBuilder ExceptComponentId()
        {
            return ExceptField("componentId");
        }
    }
}
