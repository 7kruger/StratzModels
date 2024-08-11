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
    public partial class MatchPlaybackDataTowerDeathEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlaybackDataTowerDeathEventTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "radiant" },
                new GraphQlFieldMetadata { Name = "dire" }
            };

        protected override string TypeName { get { return "MatchPlaybackDataTowerDeathEventType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlaybackDataTowerDeathEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTowerDeathEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlaybackDataTowerDeathEventTypeQueryBuilder WithRadiant(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("radiant", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTowerDeathEventTypeQueryBuilder ExceptRadiant()
        {
            return ExceptField("radiant");
        }

        public MatchPlaybackDataTowerDeathEventTypeQueryBuilder WithDire(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dire", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTowerDeathEventTypeQueryBuilder ExceptDire()
        {
            return ExceptField("dire");
        }
    }
}
