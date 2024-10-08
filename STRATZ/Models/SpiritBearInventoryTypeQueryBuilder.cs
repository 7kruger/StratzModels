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
    public partial class SpiritBearInventoryTypeQueryBuilder : GraphQlQueryBuilder<SpiritBearInventoryTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "item0", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "item1", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "item2", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "item3", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "item4", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "item5", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "backPack0", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "backPack1", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "backPack2", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "teleport0", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "neutral0", IsComplex = true, QueryBuilderType = typeof(SpiritBearInventoryObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "SpiritBearInventoryType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SpiritBearInventoryTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public SpiritBearInventoryTypeQueryBuilder WithItem0(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item0", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptItem0()
        {
            return ExceptField("item0");
        }

        public SpiritBearInventoryTypeQueryBuilder WithItem1(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item1", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptItem1()
        {
            return ExceptField("item1");
        }

        public SpiritBearInventoryTypeQueryBuilder WithItem2(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item2", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptItem2()
        {
            return ExceptField("item2");
        }

        public SpiritBearInventoryTypeQueryBuilder WithItem3(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item3", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptItem3()
        {
            return ExceptField("item3");
        }

        public SpiritBearInventoryTypeQueryBuilder WithItem4(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item4", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptItem4()
        {
            return ExceptField("item4");
        }

        public SpiritBearInventoryTypeQueryBuilder WithItem5(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("item5", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptItem5()
        {
            return ExceptField("item5");
        }

        public SpiritBearInventoryTypeQueryBuilder WithBackPack0(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("backPack0", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptBackPack0()
        {
            return ExceptField("backPack0");
        }

        public SpiritBearInventoryTypeQueryBuilder WithBackPack1(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("backPack1", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptBackPack1()
        {
            return ExceptField("backPack1");
        }

        public SpiritBearInventoryTypeQueryBuilder WithBackPack2(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("backPack2", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptBackPack2()
        {
            return ExceptField("backPack2");
        }

        public SpiritBearInventoryTypeQueryBuilder WithTeleport0(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("teleport0", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptTeleport0()
        {
            return ExceptField("teleport0");
        }

        public SpiritBearInventoryTypeQueryBuilder WithNeutral0(SpiritBearInventoryObjectTypeQueryBuilder spiritBearInventoryObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("neutral0", alias, spiritBearInventoryObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SpiritBearInventoryTypeQueryBuilder ExceptNeutral0()
        {
            return ExceptField("neutral0");
        }
    }
}
