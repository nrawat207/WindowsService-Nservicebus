using log4net.Config;
using NServiceBus;

namespace SalesService
{
    public class EndpointConfiguration : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
    {
        public void Init()
        {
            XmlConfigurator.Configure();

            Configure.With()
                .DefiningCommandsAs(t => t.Namespace != null && (t.Namespace.EndsWith("Commands")))
                .DefiningEventsAs(t => t.Namespace != null && (t.Namespace.EndsWith("Events")))
                .DefaultBuilder()
                .XmlSerializer()
                .UseInMemoryTimeoutPersister()
                .MsmqSubscriptionStorage()
                .DisableTimeoutManager()
                .DisableSecondLevelRetries();
        }
    }
}
