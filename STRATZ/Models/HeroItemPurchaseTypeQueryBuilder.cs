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
    public partial class HeroItemPurchaseTypeQueryBuilder : GraphQlQueryBuilder<HeroItemPurchaseTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "heroId" },
                new GraphQlFieldMetadata { Name = "week" },
                new GraphQlFieldMetadata { Name = "bracketBasicIds" },
                new GraphQlFieldMetadata { Name = "position" },
                new GraphQlFieldMetadata { Name = "itemId" },
                new GraphQlFieldMetadata { Name = "instance" },
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "matchCount" },
                new GraphQlFieldMetadata { Name = "winCount" },
                new GraphQlFieldMetadata { Name = "winsAverage" }
            };

        protected override string TypeName { get { return "HeroItemPurchaseType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroItemPurchaseTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroItemPurchaseTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroItemPurchaseTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HeroItemPurchaseTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public HeroItemPurchaseTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public HeroItemPurchaseTypeQueryBuilder WithInstance(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("instance", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptInstance()
        {
            return ExceptField("instance");
        }

        public HeroItemPurchaseTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public HeroItemPurchaseTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public HeroItemPurchaseTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public HeroItemPurchaseTypeQueryBuilder WithWinsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemPurchaseTypeQueryBuilder ExceptWinsAverage()
        {
            return ExceptField("winsAverage");
        }
    }
}
