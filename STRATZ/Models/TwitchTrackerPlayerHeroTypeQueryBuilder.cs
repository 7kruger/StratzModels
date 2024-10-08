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
    public partial class TwitchTrackerPlayerHeroTypeQueryBuilder : GraphQlQueryBuilder<TwitchTrackerPlayerHeroTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" }
            };

        protected override string TypeName { get { return "TwitchTrackerPlayerHeroType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public TwitchTrackerPlayerHeroTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerHeroTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public TwitchTrackerPlayerHeroTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerHeroTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public TwitchTrackerPlayerHeroTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public TwitchTrackerPlayerHeroTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }
    }
}
