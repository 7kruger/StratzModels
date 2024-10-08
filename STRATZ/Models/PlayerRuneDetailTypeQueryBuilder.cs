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
    public partial class PlayerRuneDetailTypeQueryBuilder : GraphQlQueryBuilder<PlayerRuneDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "rune" },
                new GraphQlFieldMetadata { Name = "action" },
                new GraphQlFieldMetadata { Name = "gold" },
                new GraphQlFieldMetadata { Name = "positionX" },
                new GraphQlFieldMetadata { Name = "positionY" }
            };

        protected override string TypeName { get { return "PlayerRuneDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerRuneDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerRuneDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public PlayerRuneDetailTypeQueryBuilder WithRune(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rune", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerRuneDetailTypeQueryBuilder ExceptRune()
        {
            return ExceptField("rune");
        }

        public PlayerRuneDetailTypeQueryBuilder WithAction(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("action", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerRuneDetailTypeQueryBuilder ExceptAction()
        {
            return ExceptField("action");
        }

        public PlayerRuneDetailTypeQueryBuilder WithGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("gold", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerRuneDetailTypeQueryBuilder ExceptGold()
        {
            return ExceptField("gold");
        }

        public PlayerRuneDetailTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerRuneDetailTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public PlayerRuneDetailTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerRuneDetailTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }
    }
}
