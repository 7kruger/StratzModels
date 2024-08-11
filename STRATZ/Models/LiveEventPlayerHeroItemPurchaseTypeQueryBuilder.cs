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
    public partial class LiveEventPlayerHeroItemPurchaseTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerHeroItemPurchaseTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "itemId" },
                new GraphQlFieldMetadata { Name = "itemCount" }
            };

        protected override string TypeName { get { return "LiveEventPlayerHeroItemPurchaseType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder WithItemCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroItemPurchaseTypeQueryBuilder ExceptItemCount()
        {
            return ExceptField("itemCount");
        }
    }
}
