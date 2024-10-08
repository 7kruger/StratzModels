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
    public partial class NpcStatTypeQueryBuilder : GraphQlQueryBuilder<NpcStatTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "level" },
                new GraphQlFieldMetadata { Name = "statusHealth" },
                new GraphQlFieldMetadata { Name = "statusHealthRegen" },
                new GraphQlFieldMetadata { Name = "statusMana" },
                new GraphQlFieldMetadata { Name = "statusManaRegen" },
                new GraphQlFieldMetadata { Name = "movementSpeed" },
                new GraphQlFieldMetadata { Name = "movementTurnRate" },
                new GraphQlFieldMetadata { Name = "dayTimeVision" },
                new GraphQlFieldMetadata { Name = "nightTimeVision" },
                new GraphQlFieldMetadata { Name = "attackRangeBuffer" },
                new GraphQlFieldMetadata { Name = "attackRange" },
                new GraphQlFieldMetadata { Name = "isNeutralUnitType" },
                new GraphQlFieldMetadata { Name = "isAncient" },
                new GraphQlFieldMetadata { Name = "canBeDominated" },
                new GraphQlFieldMetadata { Name = "autoAttacksByDefault" },
                new GraphQlFieldMetadata { Name = "attackDamageMin" },
                new GraphQlFieldMetadata { Name = "attackDamageMax" },
                new GraphQlFieldMetadata { Name = "attackRate" },
                new GraphQlFieldMetadata { Name = "attackAnimationPoint" },
                new GraphQlFieldMetadata { Name = "projectileSpeed" },
                new GraphQlFieldMetadata { Name = "teamName" },
                new GraphQlFieldMetadata { Name = "combatClassAttack" },
                new GraphQlFieldMetadata { Name = "combatClassDefend" },
                new GraphQlFieldMetadata { Name = "unitRelationshipClass" },
                new GraphQlFieldMetadata { Name = "attackDesire" },
                new GraphQlFieldMetadata { Name = "hasInventory" },
                new GraphQlFieldMetadata { Name = "wakesNeutrals" }
            };

        protected override string TypeName { get { return "NpcStatType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public NpcStatTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }

        public NpcStatTypeQueryBuilder WithStatusHealth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("statusHealth", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptStatusHealth()
        {
            return ExceptField("statusHealth");
        }

        public NpcStatTypeQueryBuilder WithStatusHealthRegen(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("statusHealthRegen", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptStatusHealthRegen()
        {
            return ExceptField("statusHealthRegen");
        }

        public NpcStatTypeQueryBuilder WithStatusMana(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("statusMana", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptStatusMana()
        {
            return ExceptField("statusMana");
        }

        public NpcStatTypeQueryBuilder WithStatusManaRegen(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("statusManaRegen", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptStatusManaRegen()
        {
            return ExceptField("statusManaRegen");
        }

        public NpcStatTypeQueryBuilder WithMovementSpeed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("movementSpeed", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptMovementSpeed()
        {
            return ExceptField("movementSpeed");
        }

        public NpcStatTypeQueryBuilder WithMovementTurnRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("movementTurnRate", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptMovementTurnRate()
        {
            return ExceptField("movementTurnRate");
        }

        public NpcStatTypeQueryBuilder WithDayTimeVision(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dayTimeVision", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptDayTimeVision()
        {
            return ExceptField("dayTimeVision");
        }

        public NpcStatTypeQueryBuilder WithNightTimeVision(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("nightTimeVision", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptNightTimeVision()
        {
            return ExceptField("nightTimeVision");
        }

        public NpcStatTypeQueryBuilder WithAttackRangeBuffer(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackRangeBuffer", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackRangeBuffer()
        {
            return ExceptField("attackRangeBuffer");
        }

        public NpcStatTypeQueryBuilder WithAttackRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackRange", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackRange()
        {
            return ExceptField("attackRange");
        }

        public NpcStatTypeQueryBuilder WithIsNeutralUnitType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isNeutralUnitType", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptIsNeutralUnitType()
        {
            return ExceptField("isNeutralUnitType");
        }

        public NpcStatTypeQueryBuilder WithIsAncient(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isAncient", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptIsAncient()
        {
            return ExceptField("isAncient");
        }

        public NpcStatTypeQueryBuilder WithCanBeDominated(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("canBeDominated", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptCanBeDominated()
        {
            return ExceptField("canBeDominated");
        }

        public NpcStatTypeQueryBuilder WithAutoAttacksByDefault(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("autoAttacksByDefault", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAutoAttacksByDefault()
        {
            return ExceptField("autoAttacksByDefault");
        }

        public NpcStatTypeQueryBuilder WithAttackDamageMin(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackDamageMin", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackDamageMin()
        {
            return ExceptField("attackDamageMin");
        }

        public NpcStatTypeQueryBuilder WithAttackDamageMax(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackDamageMax", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackDamageMax()
        {
            return ExceptField("attackDamageMax");
        }

        public NpcStatTypeQueryBuilder WithAttackRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackRate", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackRate()
        {
            return ExceptField("attackRate");
        }

        public NpcStatTypeQueryBuilder WithAttackAnimationPoint(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackAnimationPoint", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackAnimationPoint()
        {
            return ExceptField("attackAnimationPoint");
        }

        public NpcStatTypeQueryBuilder WithProjectileSpeed(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("projectileSpeed", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptProjectileSpeed()
        {
            return ExceptField("projectileSpeed");
        }

        public NpcStatTypeQueryBuilder WithTeamName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamName", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptTeamName()
        {
            return ExceptField("teamName");
        }

        public NpcStatTypeQueryBuilder WithCombatClassAttack(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("combatClassAttack", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptCombatClassAttack()
        {
            return ExceptField("combatClassAttack");
        }

        public NpcStatTypeQueryBuilder WithCombatClassDefend(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("combatClassDefend", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptCombatClassDefend()
        {
            return ExceptField("combatClassDefend");
        }

        public NpcStatTypeQueryBuilder WithUnitRelationshipClass(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitRelationshipClass", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptUnitRelationshipClass()
        {
            return ExceptField("unitRelationshipClass");
        }

        public NpcStatTypeQueryBuilder WithAttackDesire(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attackDesire", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptAttackDesire()
        {
            return ExceptField("attackDesire");
        }

        public NpcStatTypeQueryBuilder WithHasInventory(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hasInventory", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptHasInventory()
        {
            return ExceptField("hasInventory");
        }

        public NpcStatTypeQueryBuilder WithWakesNeutrals(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("wakesNeutrals", alias, new GraphQlDirective[] { include, skip });
        }

        public NpcStatTypeQueryBuilder ExceptWakesNeutrals()
        {
            return ExceptField("wakesNeutrals");
        }
    }
}
