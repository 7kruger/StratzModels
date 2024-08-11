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
    public partial class ProPlayerFollowTypeQueryBuilder : GraphQlQueryBuilder<ProPlayerFollowTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "steamAccountId" },
                new GraphQlFieldMetadata { Name = "activity" },
                new GraphQlFieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "ProPlayerFollowType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ProPlayerFollowTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public ProPlayerFollowTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public ProPlayerFollowTypeQueryBuilder WithActivity(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activity", alias, new GraphQlDirective[] { include, skip });
        }

        public ProPlayerFollowTypeQueryBuilder ExceptActivity()
        {
            return ExceptField("activity");
        }

        public ProPlayerFollowTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ProPlayerFollowTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }
    }
}
