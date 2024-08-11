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
    public partial class CaptainJackIdentityApiApplicationTypeQueryBuilder : GraphQlQueryBuilder<CaptainJackIdentityApiApplicationTypeQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "captainJackIdentityId" },
                new GraphQlFieldMetadata { Name = "tokenType" },
                new GraphQlFieldMetadata { Name = "emailAddress" },
                new GraphQlFieldMetadata { Name = "discordAddress" },
                new GraphQlFieldMetadata { Name = "websiteAddress" },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "isApproved" },
                new GraphQlFieldMetadata { Name = "apiKey" },
                new GraphQlFieldMetadata { Name = "secretKey" },
                new GraphQlFieldMetadata { Name = "issuer" },
                new GraphQlFieldMetadata { Name = "matomoReferenceToken" }
            };

        protected override string TypeName { get { return "CaptainJackIdentityApiApplicationType"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithCaptainJackIdentityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("captainJackIdentityId", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptCaptainJackIdentityId()
        {
            return ExceptField("captainJackIdentityId");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithTokenType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("tokenType", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptTokenType()
        {
            return ExceptField("tokenType");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithEmailAddress(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("emailAddress", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptEmailAddress()
        {
            return ExceptField("emailAddress");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithDiscordAddress(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("discordAddress", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptDiscordAddress()
        {
            return ExceptField("discordAddress");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithWebsiteAddress(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("websiteAddress", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptWebsiteAddress()
        {
            return ExceptField("websiteAddress");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptDescription()
        {
            return ExceptField("description");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithIsApproved(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isApproved", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptIsApproved()
        {
            return ExceptField("isApproved");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithApiKey(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("apiKey", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptApiKey()
        {
            return ExceptField("apiKey");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithSecretKey(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("secretKey", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptSecretKey()
        {
            return ExceptField("secretKey");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithIssuer(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("issuer", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptIssuer()
        {
            return ExceptField("issuer");
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder WithMatomoReferenceToken(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matomoReferenceToken", alias, new GraphQlDirective[] { include, skip });
        }

        public CaptainJackIdentityApiApplicationTypeQueryBuilder ExceptMatomoReferenceToken()
        {
            return ExceptField("matomoReferenceToken");
        }
    }
}