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
    public partial class AghanimLabPlayerBlessingObjectTypeQueryBuilder : GraphQlQueryBuilder<AghanimLabPlayerBlessingObjectTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "type" },
                new GraphQlFieldMetadata { Name = "value" }
            };

        protected override string TypeName { get { return "AghanimLabPlayerBlessingObjectType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AghanimLabPlayerBlessingObjectTypeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerBlessingObjectTypeQueryBuilder ExceptType()
        {
            return ExceptField("type");
        }

        public AghanimLabPlayerBlessingObjectTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabPlayerBlessingObjectTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }
    }
}