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
    public partial class LobbyTypeTypeQueryBuilder : GraphQlQueryBuilder<LobbyTypeTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "name" }
            };

        protected override string TypeName { get { return "LobbyTypeType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LobbyTypeTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public LobbyTypeTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public LobbyTypeTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public LobbyTypeTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }
    }
}
