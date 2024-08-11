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
    public partial class PageAghanimQueryQueryBuilder : GraphQlQueryBuilder<PageAghanimQueryQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "match", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AghanimLabMatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "matches", IsComplex = true, QueryBuilderType = typeof(AghanimLabMatchTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroCompositions", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AghanimLabHeroCompositionTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroComposition", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AghanimLabHeroCompositionTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "winRate", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AghanimLabHeroWinRateTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "heroAbility", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AghanimLabHeroAbilityTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "room", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AghanimLabRoomTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "roomModifier", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(Ti2020CustomGameRoomModifierTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "PageAghanimQuery"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PageAghanimQueryQueryBuilder WithMatch(AghanimLabMatchTypeQueryBuilder aghanimLabMatchTypeQueryBuilder, QueryBuilderParameter<long?> id, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id} );
            return WithObjectField("match", alias, aghanimLabMatchTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public PageAghanimQueryQueryBuilder WithMatches(AghanimLabMatchTypeQueryBuilder aghanimLabMatchTypeQueryBuilder, QueryBuilderParameter<FilterAghanimLabMatchRequestType> request = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (request != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );

            return WithObjectField("matches", alias, aghanimLabMatchTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptMatches()
        {
            return ExceptField("matches");
        }

        public PageAghanimQueryQueryBuilder WithHeroCompositions(AghanimLabHeroCompositionTypeQueryBuilder aghanimLabHeroCompositionTypeQueryBuilder, QueryBuilderParameter<FilterAghanimLabHeroCompositionRequestType> request, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );
            return WithObjectField("heroCompositions", alias, aghanimLabHeroCompositionTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptHeroCompositions()
        {
            return ExceptField("heroCompositions");
        }

        public PageAghanimQueryQueryBuilder WithHeroComposition(AghanimLabHeroCompositionTypeQueryBuilder aghanimLabHeroCompositionTypeQueryBuilder, QueryBuilderParameter<IEnumerable<short?>> heroIds, QueryBuilderParameter<AghanimLabMatchDifficultyEnum?> difficulty, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroIds", ArgumentValue = heroIds} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "difficulty", ArgumentValue = difficulty} );
            return WithObjectField("heroComposition", alias, aghanimLabHeroCompositionTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptHeroComposition()
        {
            return ExceptField("heroComposition");
        }

        public PageAghanimQueryQueryBuilder WithWinRate(AghanimLabHeroWinRateTypeQueryBuilder aghanimLabHeroWinRateTypeQueryBuilder, QueryBuilderParameter<AghanimLabMatchDifficultyEnum?> difficulty, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "difficulty", ArgumentValue = difficulty} );
            return WithObjectField("winRate", alias, aghanimLabHeroWinRateTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptWinRate()
        {
            return ExceptField("winRate");
        }

        public PageAghanimQueryQueryBuilder WithHeroAbility(AghanimLabHeroAbilityTypeQueryBuilder aghanimLabHeroAbilityTypeQueryBuilder, QueryBuilderParameter<AghanimLabMatchDifficultyEnum?> difficulty, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "difficulty", ArgumentValue = difficulty} );
            return WithObjectField("heroAbility", alias, aghanimLabHeroAbilityTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptHeroAbility()
        {
            return ExceptField("heroAbility");
        }

        public PageAghanimQueryQueryBuilder WithRoom(AghanimLabRoomTypeQueryBuilder aghanimLabRoomTypeQueryBuilder, QueryBuilderParameter<AghanimLabMatchDifficultyEnum?> difficulty, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "difficulty", ArgumentValue = difficulty} );
            return WithObjectField("room", alias, aghanimLabRoomTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptRoom()
        {
            return ExceptField("room");
        }

        public PageAghanimQueryQueryBuilder WithRoomModifier(Ti2020CustomGameRoomModifierTypeQueryBuilder ti2020CustomGameRoomModifierTypeQueryBuilder, QueryBuilderParameter<AghanimLabMatchDifficultyEnum?> difficulty, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "difficulty", ArgumentValue = difficulty} );
            return WithObjectField("roomModifier", alias, ti2020CustomGameRoomModifierTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public PageAghanimQueryQueryBuilder ExceptRoomModifier()
        {
            return ExceptField("roomModifier");
        }
    }
}
