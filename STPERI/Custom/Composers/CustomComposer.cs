using STPERI.Custom.Handlers;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;

namespace STPERI.Custom.Composers
{
    public class CustomComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.AddNotificationHandler<ContentPublishedNotification, CustomContentPublishedHandler>();
        }
    }
}
