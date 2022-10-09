namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly HttpClient _httpClient;

        public EmailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<bool>> SendEmail(Email request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Email", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}
