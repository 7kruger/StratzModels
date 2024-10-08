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
    public partial class MatchesGameVersionTypeQueryBuilder : GraphQlQueryBuilder<MatchesGameVersionTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "gameVersionId" },
                new GraphQlFieldMetadata { Name = "matchCount" }
            };

        protected override string TypeName { get { return "MatchesGameVersionType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchesGameVersionTypeQueryBuilder WithGameVersionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gameVersionId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchesGameVersionTypeQueryBuilder ExceptGameVersionId()
        {
            return ExceptField("gameVersionId");
        }

        public MatchesGameVersionTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchesGameVersionTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }
    }
}
