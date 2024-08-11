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
    public partial class LanguageTypeQueryBuilder : GraphQlQueryBuilder<LanguageTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "languageCode" },
                new GraphQlFieldMetadata { Name = "displaLanguageNameyName" }
            };

        protected override string TypeName { get { return "LanguageType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LanguageTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public LanguageTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public LanguageTypeQueryBuilder WithLanguageCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("languageCode", alias, new GraphQlDirective[] { include, skip });
        }

        public LanguageTypeQueryBuilder ExceptLanguageCode()
        {
            return ExceptField("languageCode");
        }

        public LanguageTypeQueryBuilder WithDisplaLanguageNameyName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displaLanguageNameyName", alias, new GraphQlDirective[] { include, skip });
        }

        public LanguageTypeQueryBuilder ExceptDisplaLanguageNameyName()
        {
            return ExceptField("displaLanguageNameyName");
        }
    }
}