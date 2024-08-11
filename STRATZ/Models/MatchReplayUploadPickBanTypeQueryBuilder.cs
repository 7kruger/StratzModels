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
    public partial class MatchReplayUploadPickBanTypeQueryBuilder : GraphQlQueryBuilder<MatchReplayUploadPickBanTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "playerSlot" },
                new GraphQlFieldMetadata { Name = "isPick" },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "bannedHeroId" },
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "isRadiant" },
                new GraphQlFieldMetadata { Name = "order" },
                new GraphQlFieldMetadata { Name = "wasBannedSuccessfully" }
            };

        protected override string TypeName { get { return "MatchReplayUploadPickBanType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchReplayUploadPickBanTypeQueryBuilder WithPlayerSlot(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("playerSlot", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptPlayerSlot()
        {
            return ExceptField("playerSlot");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithIsPick(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isPick", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptIsPick()
        {
            return ExceptField("isPick");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithBannedHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bannedHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptBannedHeroId()
        {
            return ExceptField("bannedHeroId");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithIsRadiant(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRadiant", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptIsRadiant()
        {
            return ExceptField("isRadiant");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithOrder(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("order", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptOrder()
        {
            return ExceptField("order");
        }

        public MatchReplayUploadPickBanTypeQueryBuilder WithWasBannedSuccessfully(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wasBannedSuccessfully", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadPickBanTypeQueryBuilder ExceptWasBannedSuccessfully()
        {
            return ExceptField("wasBannedSuccessfully");
        }
    }
}