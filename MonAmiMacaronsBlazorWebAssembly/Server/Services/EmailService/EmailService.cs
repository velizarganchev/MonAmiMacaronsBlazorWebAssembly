using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;

namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<ServiceResponse<bool>> Send(Email request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(request.From));
            email.To.Add(MailboxAddress.Parse(_config.GetSection("Email:UserName").Value));

            email.Subject = $"{request.Subject} / {request.PhoneNumber}";
            email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("Email:Host").Value, 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetSection("Email:UserName").Value, _config.GetSection("Email:Password").Value);

            smtp.Send(email);
            smtp.Disconnect(true);

            return new ServiceResponse<bool> { Data = true, Message = "Thank you for your Message!" };

        }
    }
}
