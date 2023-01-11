using BooksEvents.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BooksEvents.Services
{
    public class EmailService : IEmailService
    {
        private const string templatePath = @"EmailTemplate/{0}.html";

        private readonly SMTPConfigModel _options;

        public EmailService(IOptions<SMTPConfigModel> options)
        {
            _options = options.Value;
        }
        public async Task SendTestEmail(UserEmailOptionModel userEmailOption)
        {
            userEmailOption.Subject = UpdatePlaceHolder("Testing email", userEmailOption.PlaceHolders);
            userEmailOption.Body = UpdatePlaceHolder(GetEmailBody("TestEmail"),userEmailOption.PlaceHolders);
            await SendEmail(userEmailOption);
        }
        public async Task SendEmailConfirmation(UserEmailOptionModel userEmailOption)
        {
            userEmailOption.Subject = UpdatePlaceHolder("Hello {{UserName}}, Confirm your Email Id", userEmailOption.PlaceHolders);
            userEmailOption.Body = UpdatePlaceHolder(GetEmailBody("ConfirmEmail"), userEmailOption.PlaceHolders);
            await SendEmail(userEmailOption);
        }
        private async Task SendEmail(UserEmailOptionModel userEmailOption)
        {
            MailMessage mail = new MailMessage
            {
                Subject = userEmailOption.Subject,
                Body = userEmailOption.Body,
                From = new MailAddress(_options.SenderAddress, _options.SenderDisplayName),
                IsBodyHtml = _options.IsBodyHtml,
            };
            string[] Multi = userEmailOption.ToEmails.Split(',');

            foreach (var toEmail in Multi)
            {
                mail.To.Add(new MailAddress(toEmail));
            }
            NetworkCredential networkCredential = new NetworkCredential(_options.UserName, _options.Password);
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _options.Host,
                Port = _options.Port,
                EnableSsl = _options.EnableSSL,
                UseDefaultCredentials = _options.UserDefaultCredentials,
                Credentials = networkCredential
            };
            mail.BodyEncoding = Encoding.Default;
            await smtpClient.SendMailAsync(mail);
        }
        private string GetEmailBody(string template)
        {
            var body = File.ReadAllText(string.Format(templatePath, template));
            return body;
        }
        private string UpdatePlaceHolder(string text,List<KeyValuePair<string,string>> keyValuePairs)
        {
            if (!string.IsNullOrEmpty(text) && keyValuePairs!=null)
            {
                foreach(var placeholder in keyValuePairs)
                {
                    if (text.Contains(placeholder.Key))
                    {
                        text = text.Replace(placeholder.Key, placeholder.Value);
                    }
                }
            }
            return text;
        }
    }
}
