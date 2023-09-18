using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.Contracts.Infrastructures;
using GymManegmentApplication.Model;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace GymManagmentSystem.Infrastructurs.Email
{
    internal class EmailSender : IEmailSender
    {
        //Via dependency injection EmailSetting initialized here
        //Here we use Microsoft extension option configuration library
        private EmailSetting _emailSetting { get; }
        public EmailSender(IOptions<EmailSetting> emailSetting)
        {
            _emailSetting = emailSetting.Value;
        }

        //--- IMPORTANT ---
        //To fill this method we used SendGrid Library
        public async Task<bool> SendEmail(GymManegmentApplication.Model.Email email)
        {
            var client = new SendGridClient(_emailSetting.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email = _emailSetting.FromAddress,
                Name = _emailSetting.FromName
            };

            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
            var response = await client.SendEmailAsync(message);


            return response.StatusCode == System.Net.HttpStatusCode.OK ||
                   response.StatusCode == System.Net.HttpStatusCode.Accepted;
        }
    }
}
