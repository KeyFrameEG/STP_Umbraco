using System.Net;
using System.Net.Mail;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Services;
using Umbraco.Extensions;

namespace STPERI.Custom.Handlers
{
    public class CustomContentPublishedHandler : INotificationHandler<ContentPublishedNotification>
    {
        private readonly IContentService _contentService;
        private readonly IConfiguration _configuration;
        public CustomContentPublishedHandler(IContentService contentService, IConfiguration configuration)
        {
            _contentService = contentService;
            _configuration = configuration;
        }

        public void Handle(ContentPublishedNotification notification)
        {
            foreach (var content in notification.PublishedEntities)
            {
                if (content.ContentType.Alias.Equals("newsPage"))
                {
                    SendEmail(content.Name);
                }
            }
        }

        private void SendEmail(string contentName)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings");
                var recipientSettings = _configuration.GetSection("RecipientSettings");

                var fromAddress = new MailAddress(smtpSettings["Username"], "STPERI");
                var toAddress = new MailAddress(recipientSettings["Email"], recipientSettings["Name"]);
                var fromPassword = smtpSettings["Password"];
                const string subject = "New News Added";
                string body = $"A new news item has been added: {contentName}";

                var smtp = new SmtpClient
                {
                    Host = smtpSettings["Host"],
                    Port = int.Parse(smtpSettings["Port"]),
                    EnableSsl = bool.Parse(smtpSettings["EnableSsl"]),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"SMTP Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }

    }
}
