using Cursos.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Service.Concretes
{
    public class EmailService : IEmailService
    {
        private IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task EnviaEmail(string toEmail, string subject, string content)
        {
            var apiKey = _configuration["SendGridAPIKey"];
            var estudante = new SendGridClient(apiKey);
            var from = new EmailAddress("thyagomartins21@gmail.com", "Thyago Martins. Dev. Junior");
            var to = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await estudante.SendEmailAsync(msg);
        }
    }
}
