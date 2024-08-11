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
    public partial class PlayerCardHoverTypeQueryBuilder : GraphQlQueryBuilder<PlayerCardHoverTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "lastUpdateDateTime" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "coreCount" },
                new GraphQlFieldMetadata { Name = "supportCount" },
                new GraphQlFieldMetadata { Name = "imp" },
                new GraphQlFieldMetadata { Name = "heroes", IsComplex = true, QueryBuilderType = typeof(PlayerCardHoverHeroTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "activity" }
            };

        protected override string TypeName { get { return "PlayerCardHoverType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerCardHoverTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public PlayerCardHoverTypeQueryBuilder WithLastUpdateDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastUpdateDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptLastUpdateDateTime()
        {
            return ExceptField("lastUpdateDateTime");
        }

        public PlayerCardHoverTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public PlayerCardHoverTypeQueryBuilder WithCoreCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("coreCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptCoreCount()
        {
            return ExceptField("coreCount");
        }

        public PlayerCardHoverTypeQueryBuilder WithSupportCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("supportCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptSupportCount()
        {
            return ExceptField("supportCount");
        }

        public PlayerCardHoverTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }

        public PlayerCardHoverTypeQueryBuilder WithHeroes(PlayerCardHoverHeroTypeQueryBuilder playerCardHoverHeroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("heroes", alias, playerCardHoverHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptHeroes()
        {
            return ExceptField("heroes");
        }

        public PlayerCardHoverTypeQueryBuilder WithActivity(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activity", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerCardHoverTypeQueryBuilder ExceptActivity()
        {
            return ExceptField("activity");
        }
    }
}