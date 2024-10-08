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
    public partial class PlayerPerformancePositionObjectTypeQueryBuilder : GraphQlQueryBuilder<PlayerPerformancePositionObjectTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "laneType" },
                new GraphQlFieldMetadata { Name = "laneMatchCount" },
                new GraphQlFieldMetadata { Name = "laneWinCount" }
            };

        protected override string TypeName { get { return "PlayerPerformancePositionObjectType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerPerformancePositionObjectTypeQueryBuilder WithLaneType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("laneType", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionObjectTypeQueryBuilder ExceptLaneType()
        {
            return ExceptField("laneType");
        }

        public PlayerPerformancePositionObjectTypeQueryBuilder WithLaneMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("laneMatchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionObjectTypeQueryBuilder ExceptLaneMatchCount()
        {
            return ExceptField("laneMatchCount");
        }

        public PlayerPerformancePositionObjectTypeQueryBuilder WithLaneWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("laneWinCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionObjectTypeQueryBuilder ExceptLaneWinCount()
        {
            return ExceptField("laneWinCount");
        }
    }
}
