namespace BNetAPI.Core.Utilities.Constants
{
    public static class RequestConstants
    {
        public const string StateValue = "b0f9e3be-5156-48fd-82b8-3afbdf5f92a9";

        public static class Parameters
        {
            public const string Authorization = "Authorization";

            public const string GrantType = "grant_type";

            public const string ClientId = "client_id";

            public const string State = "state";

            public const string RedirectUri = "redirect_uri";

            public const string ResponseType = "response_type";

            public const string Scope = "scope";

            public const string Code = "code";
        }

        public static class HeaderValues
        {
            public const string BearerTokenFormat = "Bearer {0}";
        }

        public static class AuthenticationType
        {
            public const string Bearer = "Bearer";

            public const string Basic = "Basic";
        }

        public static class GrantTypes
        {
            public const string ClientCredentials = "client_credentials";

            public const string Password = "password";

            public const string AuthorizationCode = "authorization_code";
        }

        public static class Scopes
        {
            public const string WoWProfile = "wow.profile";
        }

        public static class ResponseTypes
        {
            public const string Code = "code";
        }
    }
}
