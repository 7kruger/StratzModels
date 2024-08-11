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
    public partial class GoldDetailTypeQueryBuilder : GraphQlQueryBuilder<GoldDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "amount" },
                new GraphQlFieldMetadata { Name = "reason" },
                new GraphQlFieldMetadata { Name = "npcId" },
                new GraphQlFieldMetadata { Name = "isValidForStats" }
            };

        protected override string TypeName { get { return "GoldDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public GoldDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public GoldDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public GoldDetailTypeQueryBuilder WithAmount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("amount", alias, new GraphQlDirective[] { include, skip });
        }

        public GoldDetailTypeQueryBuilder ExceptAmount()
        {
            return ExceptField("amount");
        }

        public GoldDetailTypeQueryBuilder WithReason(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("reason", alias, new GraphQlDirective[] { include, skip });
        }

        public GoldDetailTypeQueryBuilder ExceptReason()
        {
            return ExceptField("reason");
        }

        public GoldDetailTypeQueryBuilder WithNpcId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("npcId", alias, new GraphQlDirective[] { include, skip });
        }

        public GoldDetailTypeQueryBuilder ExceptNpcId()
        {
            return ExceptField("npcId");
        }

        public GoldDetailTypeQueryBuilder WithIsValidForStats(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isValidForStats", alias, new GraphQlDirective[] { include, skip });
        }

        public GoldDetailTypeQueryBuilder ExceptIsValidForStats()
        {
            return ExceptField("isValidForStats");
        }
    }
}