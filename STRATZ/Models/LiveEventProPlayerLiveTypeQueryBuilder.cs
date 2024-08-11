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
    public partial class LiveEventProPlayerLiveTypeQueryBuilder : GraphQlQueryBuilder<LiveEventProPlayerLiveTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccounts", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchLiveTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LiveEventProPlayerLiveType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventProPlayerLiveTypeQueryBuilder WithSteamAccounts(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccounts", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventProPlayerLiveTypeQueryBuilder ExceptSteamAccounts()
        {
            return ExceptField("steamAccounts");
        }

        public LiveEventProPlayerLiveTypeQueryBuilder WithMatch(MatchLiveTypeQueryBuilder matchLiveTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchLiveTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventProPlayerLiveTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }
    }
}