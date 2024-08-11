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
    public partial class GameVersionTypeQueryBuilder : GraphQlQueryBuilder<GameVersionTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "name" },
                new GraphQlFieldMetadata { Name = "asOfDateTime" }
            };

        protected override string TypeName { get { return "GameVersionType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public GameVersionTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public GameVersionTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public GameVersionTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public GameVersionTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public GameVersionTypeQueryBuilder WithAsOfDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("asOfDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public GameVersionTypeQueryBuilder ExceptAsOfDateTime()
        {
            return ExceptField("asOfDateTime");
        }
    }
}
