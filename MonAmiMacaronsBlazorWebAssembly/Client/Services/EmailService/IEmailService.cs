namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.EmailService
{
    public interface IEmailService
    {
        Task<ServiceResponse<bool>> SendEmail(Email request);
    }
}
