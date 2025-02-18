namespace KeycloakExtended.Services
{
    public sealed class KeyCloakService
    {
        public async  Task<string> GetAccessToken()
        {
            HttpClient client = new();
            string endpoint = "http://localhost:8080/realms/myrealm/protocol/openid-connect/token";

        }
    }
}
