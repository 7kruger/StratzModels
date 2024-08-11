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
    public partial class LiveEventPlayerHeroHeroDamageTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerHeroHeroDamageTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "heroDamage" }
            };

        protected override string TypeName { get { return "LiveEventPlayerHeroHeroDamageType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder WithHeroDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHeroDamageTypeQueryBuilder ExceptHeroDamage()
        {
            return ExceptField("heroDamage");
        }
    }
}