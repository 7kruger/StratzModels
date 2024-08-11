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
    public partial class LeagueMetaTypeQueryBuilder : GraphQlQueryBuilder<LeagueMetaTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "leagueId" },
                new GraphQlFieldMetadata { Name = "bestRecord", IsComplex = true, QueryBuilderType = typeof(LeagueMetaDetailTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "mostPicked", IsComplex = true, QueryBuilderType = typeof(LeagueMetaDetailTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "mostBanned", IsComplex = true, QueryBuilderType = typeof(LeagueMetaDetailTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "missingMatchCount" },
                new GraphQlFieldMetadata { Name = "totalMatchCount" },
                new GraphQlFieldMetadata { Name = "league", IsComplex = true, QueryBuilderType = typeof(LeagueTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LeagueMetaType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueMetaTypeQueryBuilder WithLeagueId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leagueId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptLeagueId()
        {
            return ExceptField("leagueId");
        }

        public LeagueMetaTypeQueryBuilder WithBestRecord(LeagueMetaDetailTypeQueryBuilder leagueMetaDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("bestRecord", alias, leagueMetaDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptBestRecord()
        {
            return ExceptField("bestRecord");
        }

        public LeagueMetaTypeQueryBuilder WithMostPicked(LeagueMetaDetailTypeQueryBuilder leagueMetaDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("mostPicked", alias, leagueMetaDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptMostPicked()
        {
            return ExceptField("mostPicked");
        }

        public LeagueMetaTypeQueryBuilder WithMostBanned(LeagueMetaDetailTypeQueryBuilder leagueMetaDetailTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("mostBanned", alias, leagueMetaDetailTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptMostBanned()
        {
            return ExceptField("mostBanned");
        }

        public LeagueMetaTypeQueryBuilder WithMissingMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("missingMatchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptMissingMatchCount()
        {
            return ExceptField("missingMatchCount");
        }

        public LeagueMetaTypeQueryBuilder WithTotalMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("totalMatchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptTotalMatchCount()
        {
            return ExceptField("totalMatchCount");
        }

        public LeagueMetaTypeQueryBuilder WithLeague(LeagueTypeQueryBuilder leagueTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("league", alias, leagueTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueMetaTypeQueryBuilder ExceptLeague()
        {
            return ExceptField("league");
        }
    }
}
