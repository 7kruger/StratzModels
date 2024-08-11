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
    public partial class MatchReplayUploadOverviewTypeQueryBuilder : GraphQlQueryBuilder<MatchReplayUploadOverviewTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "matches", IsComplex = true, QueryBuilderType = typeof(MatchReplayUploadMatchTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "MatchReplayUploadOverviewType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchReplayUploadOverviewTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadOverviewTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchReplayUploadOverviewTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadOverviewTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchReplayUploadOverviewTypeQueryBuilder WithMatches(MatchReplayUploadMatchTypeQueryBuilder matchReplayUploadMatchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("matches", alias, matchReplayUploadMatchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchReplayUploadOverviewTypeQueryBuilder ExceptMatches()
        {
            return ExceptField("matches");
        }
    }
}