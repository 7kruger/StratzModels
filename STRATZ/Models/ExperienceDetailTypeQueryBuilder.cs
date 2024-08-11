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
    public partial class ExperienceDetailTypeQueryBuilder : GraphQlQueryBuilder<ExperienceDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "amount" },
                new GraphQlFieldMetadata { Name = "reason" },
                new GraphQlFieldMetadata { Name = "positionX" },
                new GraphQlFieldMetadata { Name = "positionY" }
            };

        protected override string TypeName { get { return "ExperienceDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ExperienceDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public ExperienceDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public ExperienceDetailTypeQueryBuilder WithAmount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("amount", alias, new GraphQlDirective[] { include, skip });
        }

        public ExperienceDetailTypeQueryBuilder ExceptAmount()
        {
            return ExceptField("amount");
        }

        public ExperienceDetailTypeQueryBuilder WithReason(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("reason", alias, new GraphQlDirective[] { include, skip });
        }

        public ExperienceDetailTypeQueryBuilder ExceptReason()
        {
            return ExceptField("reason");
        }

        public ExperienceDetailTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public ExperienceDetailTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public ExperienceDetailTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public ExperienceDetailTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }
    }
}
