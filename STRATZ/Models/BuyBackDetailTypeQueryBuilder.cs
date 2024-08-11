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
    public partial class BuyBackDetailTypeQueryBuilder : GraphQlQueryBuilder<BuyBackDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "deathTimeRemaining" },
                new GraphQlFieldMetadata { Name = "cost" }
            };

        protected override string TypeName { get { return "BuyBackDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public BuyBackDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public BuyBackDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public BuyBackDetailTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public BuyBackDetailTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public BuyBackDetailTypeQueryBuilder WithDeathTimeRemaining(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deathTimeRemaining", alias, new GraphQlDirective[] { include, skip });
        }

        public BuyBackDetailTypeQueryBuilder ExceptDeathTimeRemaining()
        {
            return ExceptField("deathTimeRemaining");
        }

        public BuyBackDetailTypeQueryBuilder WithCost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cost", alias, new GraphQlDirective[] { include, skip });
        }

        public BuyBackDetailTypeQueryBuilder ExceptCost()
        {
            return ExceptField("cost");
        }
    }
}