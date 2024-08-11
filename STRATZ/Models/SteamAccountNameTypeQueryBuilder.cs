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
    public partial class SteamAccountNameTypeQueryBuilder : GraphQlQueryBuilder<SteamAccountNameTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "name" },
                new GraphQlFieldMetadata { Name = "lastSeenDateTime" }
            };

        protected override string TypeName { get { return "SteamAccountNameType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamAccountNameTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountNameTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public SteamAccountNameTypeQueryBuilder WithLastSeenDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastSeenDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountNameTypeQueryBuilder ExceptLastSeenDateTime()
        {
            return ExceptField("lastSeenDateTime");
        }
    }
}