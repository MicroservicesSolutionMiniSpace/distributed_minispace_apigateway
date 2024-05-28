using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Convey.Auth;
using MiniSpace.Services.Identity.Application.DTO;
using MiniSpace.Services.Identity.Application.Services;

namespace MiniSpace.Services.Identity.Infrastructure.Auth
{
    [ExcludeFromCodeCoverage]
    public class JwtProvider : IJwtProvider
    {
        private readonly IJwtHandler _jwtHandler;

        public JwtProvider(IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        public AuthDto Create(Guid userId, string role, string audience = null,
            IDictionary<string, IEnumerable<string>> claims = null)
        {
            var jwt = _jwtHandler.CreateToken(userId.ToString("N"), role, audience, claims);

            return new AuthDto
            {
                AccessToken = jwt.AccessToken,
                Role = jwt.Role,
                Expires = jwt.Expires
            };
        }
    }
}