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
    public partial class PlayerUpdateLevelDetailTypeQueryBuilder : GraphQlQueryBuilder<PlayerUpdateLevelDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "level" }
            };

        protected override string TypeName { get { return "PlayerUpdateLevelDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerUpdateLevelDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateLevelDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public PlayerUpdateLevelDetailTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateLevelDetailTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }
    }
}