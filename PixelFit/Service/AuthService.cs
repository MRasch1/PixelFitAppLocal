using PixelFit.DTOS.Auth;
using System.Net.Http.Json;

namespace PixelFit.Service
{
    // Service der håndterer kommunikationen mellem
    // MAUI-appen og PixelFit API'et
    public class AuthService
    {
        // HttpClient bruges til at sende HTTP requests til API'et
        private readonly HttpClient _httpClient;

        // HttpClient bliver givet til servicen gennem Dependency Injection
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // Bevis på HTTPS, tjek output i debug konsollen
            Console.WriteLine("API BaseAddress: " + _httpClient.BaseAddress);
        }

        // Sender email og adgangskode til API'et
        // for at oprette en ny bruger
        public async Task<bool> RegisterAsync(
            string email,
            string password)
        {
            // Opretter de data som skal sendes til API'et
            var request = new RegisterRequest
            {
                Email = email,
                Password = password
            };

            // Sender brugerdata som JSON til register endpointet
            var response = await _httpClient.PostAsJsonAsync(
                "api/Users/register",
                request
            );

            // Returnerer true hvis brugeren blev oprettet
            // og false hvis API'et returnerede en fejl
            return response.IsSuccessStatusCode;
        }


        // Sender email og adgangskode til API'et
        // og returnerer et JWT-token hvis login lykkes
        public async Task<string?> LoginAsync(
            string email,
            string password)
        {
            // Opretter login-data som skal sendes til API'et
            var request = new LoginRequest
            {
                Email = email,
                Password = password
            };

            // Sender login-data som JSON til login endpointet
            var response = await _httpClient.PostAsJsonAsync(
                "api/Auth/login",
                request
            );

            // Hvis login mislykkes returneres null
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            // Læser JSON-svaret fra API'et
            // og konverterer det til LoginResponse
            var result = await response.Content
                .ReadFromJsonAsync<LoginResponse>();

            // Returnerer JWT-tokenet
            return result?.Token;
        }
    }
}