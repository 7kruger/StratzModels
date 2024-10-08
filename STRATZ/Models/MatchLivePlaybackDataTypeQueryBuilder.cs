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
    public partial class MatchLivePlaybackDataTypeQueryBuilder : GraphQlQueryBuilder<MatchLivePlaybackDataTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "roshanEvents", IsComplex = true, QueryBuilderType = typeof(MatchLiveRoshanDetailTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "buildingEvents", IsComplex = true, QueryBuilderType = typeof(MatchLiveBuildingDetailTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "pickBans", IsComplex = true, QueryBuilderType = typeof(MatchLivePickBanTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "radiantScore", IsComplex = true, QueryBuilderType = typeof(MatchLiveTeamScoreDetailTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "direScore", IsComplex = true, QueryBuilderType = typeof(MatchLiveTeamScoreDetailTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchLivePlaybackDataType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchLivePlaybackDataTypeQueryBuilder WithRoshanEvents(MatchLiveRoshanDetailTypeQueryBuilder matchLiveRoshanDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("roshanEvents", alias, matchLiveRoshanDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlaybackDataTypeQueryBuilder ExceptRoshanEvents()
        {
            return ExceptField("roshanEvents");
        }

        public MatchLivePlaybackDataTypeQueryBuilder WithBuildingEvents(MatchLiveBuildingDetailTypeQueryBuilder matchLiveBuildingDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("buildingEvents", alias, matchLiveBuildingDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlaybackDataTypeQueryBuilder ExceptBuildingEvents()
        {
            return ExceptField("buildingEvents");
        }

        public MatchLivePlaybackDataTypeQueryBuilder WithPickBans(MatchLivePickBanTypeQueryBuilder matchLivePickBanTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("pickBans", alias, matchLivePickBanTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlaybackDataTypeQueryBuilder ExceptPickBans()
        {
            return ExceptField("pickBans");
        }

        public MatchLivePlaybackDataTypeQueryBuilder WithRadiantScore(MatchLiveTeamScoreDetailTypeQueryBuilder matchLiveTeamScoreDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("radiantScore", alias, matchLiveTeamScoreDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlaybackDataTypeQueryBuilder ExceptRadiantScore()
        {
            return ExceptField("radiantScore");
        }

        public MatchLivePlaybackDataTypeQueryBuilder WithDireScore(MatchLiveTeamScoreDetailTypeQueryBuilder matchLiveTeamScoreDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("direScore", alias, matchLiveTeamScoreDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlaybackDataTypeQueryBuilder ExceptDireScore()
        {
            return ExceptField("direScore");
        }
    }
}
