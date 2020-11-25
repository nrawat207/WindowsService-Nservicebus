using log4net.Config;
using NServiceBus;

namespace ShippingService
{
    public class EndpointConfiguration : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            XmlConfigurator.Configure();
            Configure.With()
               .DefiningMessagesAs(t => t.Namespace != null && (t.Namespace.EndsWith("Events")))
               .DefaultBuilder()
               .XmlSerializer()
               .UseInMemoryTimeoutPersister()
               .MsmqSubscriptionStorage()
               .DisableTimeoutManager()
               .DisableSecondLevelRetries();
        }
    }
}
