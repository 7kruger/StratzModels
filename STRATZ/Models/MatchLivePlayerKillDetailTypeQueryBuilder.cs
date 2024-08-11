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
    public partial class MatchLivePlayerKillDetailTypeQueryBuilder : GraphQlQueryBuilder<MatchLivePlayerKillDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "positionX" },
                new GraphQlFieldMetadata { Name = "positionY" }
            };

        protected override string TypeName { get { return "MatchLivePlayerKillDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchLivePlayerKillDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerKillDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchLivePlayerKillDetailTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerKillDetailTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchLivePlayerKillDetailTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerKillDetailTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }
    }
}
