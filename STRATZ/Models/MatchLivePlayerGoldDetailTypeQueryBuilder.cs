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
    public partial class MatchLivePlayerGoldDetailTypeQueryBuilder : GraphQlQueryBuilder<MatchLivePlayerGoldDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "gold" },
                new GraphQlFieldMetadata { Name = "networth" },
                new GraphQlFieldMetadata { Name = "networthDifference" },
                new GraphQlFieldMetadata { Name = "goldPerMinute" }
            };

        protected override string TypeName { get { return "MatchLivePlayerGoldDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchLivePlayerGoldDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder WithGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gold", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder ExceptGold()
        {
            return ExceptField("gold");
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder WithNetworth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("networth", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder ExceptNetworth()
        {
            return ExceptField("networth");
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder WithNetworthDifference(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("networthDifference", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder ExceptNetworthDifference()
        {
            return ExceptField("networthDifference");
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder WithGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLivePlayerGoldDetailTypeQueryBuilder ExceptGoldPerMinute()
        {
            return ExceptField("goldPerMinute");
        }
    }
}
