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
    public partial class MatchLivePlayerDenyDetailTypeQueryBuilder : GraphQlQueryBuilder<MatchLivePlayerDenyDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "positionX" },
                new GraphQlFieldMetadata { Name = "positionY" }
            };

        protected override string TypeName { get { return "MatchLivePlayerDenyDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchLivePlayerDenyDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerDenyDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchLivePlayerDenyDetailTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerDenyDetailTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchLivePlayerDenyDetailTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerDenyDetailTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }
    }
}
