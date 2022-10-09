namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.EmailService
{
    public interface IEmailService
    {
        Task<ServiceResponse<bool>> Send(Email request);
    }
}
