﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using JetBrains.Annotations;

namespace AspNet.Security.OAuth.<%= name %> {
    public class <%= name %>AuthenticationMiddleware : OAuthMiddleware<<%= name %>AuthenticationOptions> {
        public <%= name %>AuthenticationMiddleware(
            [NotNull] RequestDelegate next,
            [NotNull] IOptions<<%= name %>AuthenticationOptions> options,
            [NotNull] IDataProtectionProvider dataProtectionProvider,
            [NotNull] ILoggerFactory loggerFactory,
            [NotNull] UrlEncoder encoder,
            [NotNull] IOptions<SharedAuthenticationOptions> externalOptions)
            : base(next, dataProtectionProvider, loggerFactory, encoder, externalOptions, options) {
        }

        protected override AuthenticationHandler<<%= name %>AuthenticationOptions> CreateHandler() {
            return new <%= name %>AuthenticationHandler(Backchannel);
        }
    }
}
