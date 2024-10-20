using Microsoft.AspNetCore.Identity.UI.Services;

namespace Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //logics to send email remember to write
            return Task.CompletedTask;
        }
    }
}
