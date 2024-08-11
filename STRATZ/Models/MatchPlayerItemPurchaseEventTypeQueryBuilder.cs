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
    public partial class MatchPlayerItemPurchaseEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerItemPurchaseEventTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "itemId" }
            };

        protected override string TypeName { get { return "MatchPlayerItemPurchaseEventType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerItemPurchaseEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerItemPurchaseEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlayerItemPurchaseEventTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerItemPurchaseEventTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }
    }
}