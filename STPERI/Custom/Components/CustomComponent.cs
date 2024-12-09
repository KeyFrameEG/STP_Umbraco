using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
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
                if (content.ContentType.Alias.Equals("newsPage") ||
                    content.ContentType.Alias.Equals("eventPage"))
                {
                    if (content.WasPropertyDirty("mainContentLatestNews"))
                    {
                        SendEmail(content.Name);

                        var subscribers = GetSubscribers();
                        // Send the email to all subscribers
                        SendEmailsToSubscribers(subscribers, content.Name);
                    }
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

        private void SendEmailsToSubscribers(List<string> subscribers, string contentName)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings");
                var fromAddress = new MailAddress(smtpSettings["Username"], "STPERI");
                var fromPassword = smtpSettings["Password"];
                const string subject = "New News Added";
                string body = $"A new news item has been added: {contentName}";

                // SMTP client setup
                var smtp = new SmtpClient
                {
                    Host = smtpSettings["Host"],
                    Port = int.Parse(smtpSettings["Port"]),
                    EnableSsl = bool.Parse(smtpSettings["EnableSsl"]),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                // Loop through all subscriber emails and send the email
                foreach (var subscriberEmail in subscribers)
                {
                    var toAddress = new MailAddress(subscriberEmail);

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
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
        public List<string> GetSubscribers()
        {
            var connectionDB = _configuration.GetSection("ConnectionStrings");
            var subscriberEmails = new List<string>();

            using (var connection = new SqlConnection(connectionDB["umbracoDbDSN"]))
            {
                connection.Open();


                var query = "SELECT RecordData FROM UFRecords WHERE UmbracoPageId = 1064";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var recordData = reader["RecordData"].ToString();

                            // Parse JSON to get email
                            var jsonData = JObject.Parse(recordData);

                            // Assuming '7f7529f5-e43f-41cb-c26a-64e385333021' is the field ID for the email
                            var email = jsonData["7f7529f5-e43f-41cb-c26a-64e385333021"]?.ToString();

                            if (!string.IsNullOrWhiteSpace(email))
                            {
                                subscriberEmails.Add(email);
                            }
                        }
                    }
                }
            }

            return subscriberEmails;
        }

    }
}
