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
    public partial class DeathDetailTypeQueryBuilder : GraphQlQueryBuilder<DeathDetailTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "time" },
                new GraphQlFieldMetadata { Name = "attacker" },
                new GraphQlFieldMetadata { Name = "isFromIllusion" },
                new GraphQlFieldMetadata { Name = "target" },
                new GraphQlFieldMetadata { Name = "byAbility" },
                new GraphQlFieldMetadata { Name = "byItem" },
                new GraphQlFieldMetadata { Name = "goldFed" },
                new GraphQlFieldMetadata { Name = "xpFed" },
                new GraphQlFieldMetadata { Name = "timeDead" },
                new GraphQlFieldMetadata { Name = "reliableGold" },
                new GraphQlFieldMetadata { Name = "unreliableGold" },
                new GraphQlFieldMetadata { Name = "positionX" },
                new GraphQlFieldMetadata { Name = "positionY" },
                new GraphQlFieldMetadata { Name = "goldLost" },
                new GraphQlFieldMetadata { Name = "assist", IsComplex = true },
                new GraphQlFieldMetadata { Name = "isWardWalkThrough" },
                new GraphQlFieldMetadata { Name = "isAttemptTpOut" },
                new GraphQlFieldMetadata { Name = "isDieBack" },
                new GraphQlFieldMetadata { Name = "isBurst" },
                new GraphQlFieldMetadata { Name = "isEngagedOnDeath" },
                new GraphQlFieldMetadata { Name = "hasHealAvailable" },
                new GraphQlFieldMetadata { Name = "isTracked" },
                new GraphQlFieldMetadata { Name = "isFeed" }
            };

        protected override string TypeName { get { return "DeathDetailType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public DeathDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public DeathDetailTypeQueryBuilder WithAttacker(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attacker", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptAttacker()
        {
            return ExceptField("attacker");
        }

        public DeathDetailTypeQueryBuilder WithIsFromIllusion(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isFromIllusion", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsFromIllusion()
        {
            return ExceptField("isFromIllusion");
        }

        public DeathDetailTypeQueryBuilder WithTarget(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("target", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptTarget()
        {
            return ExceptField("target");
        }

        public DeathDetailTypeQueryBuilder WithByAbility(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byAbility", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptByAbility()
        {
            return ExceptField("byAbility");
        }

        public DeathDetailTypeQueryBuilder WithByItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("byItem", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptByItem()
        {
            return ExceptField("byItem");
        }

        public DeathDetailTypeQueryBuilder WithGoldFed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldFed", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptGoldFed()
        {
            return ExceptField("goldFed");
        }

        public DeathDetailTypeQueryBuilder WithXpFed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("xpFed", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptXpFed()
        {
            return ExceptField("xpFed");
        }

        public DeathDetailTypeQueryBuilder WithTimeDead(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("timeDead", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptTimeDead()
        {
            return ExceptField("timeDead");
        }

        public DeathDetailTypeQueryBuilder WithReliableGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("reliableGold", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptReliableGold()
        {
            return ExceptField("reliableGold");
        }

        public DeathDetailTypeQueryBuilder WithUnreliableGold(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unreliableGold", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptUnreliableGold()
        {
            return ExceptField("unreliableGold");
        }

        public DeathDetailTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public DeathDetailTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }

        public DeathDetailTypeQueryBuilder WithGoldLost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldLost", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptGoldLost()
        {
            return ExceptField("goldLost");
        }

        public DeathDetailTypeQueryBuilder WithAssist(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("assist", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptAssist()
        {
            return ExceptField("assist");
        }

        public DeathDetailTypeQueryBuilder WithIsWardWalkThrough(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isWardWalkThrough", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsWardWalkThrough()
        {
            return ExceptField("isWardWalkThrough");
        }

        public DeathDetailTypeQueryBuilder WithIsAttemptTpOut(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isAttemptTpOut", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsAttemptTpOut()
        {
            return ExceptField("isAttemptTpOut");
        }

        public DeathDetailTypeQueryBuilder WithIsDieBack(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isDieBack", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsDieBack()
        {
            return ExceptField("isDieBack");
        }

        public DeathDetailTypeQueryBuilder WithIsBurst(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isBurst", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsBurst()
        {
            return ExceptField("isBurst");
        }

        public DeathDetailTypeQueryBuilder WithIsEngagedOnDeath(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isEngagedOnDeath", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsEngagedOnDeath()
        {
            return ExceptField("isEngagedOnDeath");
        }

        public DeathDetailTypeQueryBuilder WithHasHealAvailable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hasHealAvailable", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptHasHealAvailable()
        {
            return ExceptField("hasHealAvailable");
        }

        public DeathDetailTypeQueryBuilder WithIsTracked(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isTracked", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsTracked()
        {
            return ExceptField("isTracked");
        }

        public DeathDetailTypeQueryBuilder WithIsFeed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isFeed", alias, new GraphQlDirective[] { include, skip });
        }

        public DeathDetailTypeQueryBuilder ExceptIsFeed()
        {
            return ExceptField("isFeed");
        }
    }
}