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
    public partial class LiveEventPlayerHeroDewardTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerHeroDewardTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "dewardCount" }
            };

        protected override string TypeName { get { return "LiveEventPlayerHeroDewardType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerHeroDewardTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder WithDewardCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dewardCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDewardTypeQueryBuilder ExceptDewardCount()
        {
            return ExceptField("dewardCount");
        }
    }
}
