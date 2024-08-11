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
    public partial class HeroDotaPlusLeaderboardRankTopTypeQueryBuilder : GraphQlQueryBuilder<HeroDotaPlusLeaderboardRankTopTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "steamAccountId" },
                new GraphQlFieldMetadata { Name = "level" },
                new GraphQlFieldMetadata { Name = "createdDateTime" },
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "HeroDotaPlusLeaderboardRankTopType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder WithCreatedDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("createdDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder ExceptCreatedDateTime()
        {
            return ExceptField("createdDateTime");
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public HeroDotaPlusLeaderboardRankTopTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }
    }
}