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
    public partial class LiveEventPlayerDireTideCandyScoredTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerDireTideCandyScoredTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(DireTideCustomGameMatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "candyScored" }
            };

        protected override string TypeName { get { return "LiveEventPlayerDireTideCandyScoredType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder WithMatch(DireTideCustomGameMatchTypeQueryBuilder direTideCustomGameMatchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, direTideCustomGameMatchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder WithCandyScored(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyScored", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTideCandyScoredTypeQueryBuilder ExceptCandyScored()
        {
            return ExceptField("candyScored");
        }
    }
}