using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Planerve.App.Identity;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("planerveappapi", "Planerve APP API")
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            // interactive ASP.NET Core MVC client
            new Client
            {
                ClientId ="planerveappui",
                ClientSecrets = { new Secret("secret".Sha256()) },

                AllowedGrantTypes = GrantTypes.Code,
                AllowOfflineAccess = true,
                AccessTokenLifetime = 60 * 60,
                // where to redirect to after login
                RedirectUris = { "https://localhost:5001/signin-oidc" },

                // where to redirect to after logout
                PostLogoutRedirectUris = { "https://localhost:5001/signout-callback-oidc" },

                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "planerveappapi"
                },
                AlwaysIncludeUserClaimsInIdToken = true,
            }
        };
}
