using NServiceBus;

namespace ClientUI
{
    public class NServiceBusHelper
    {
        static NServiceBusHelper()
        {
            CreateBus();
        }

        public static IBus Bus { get; private set; }

        private static void CreateBus()
        {
            Bus = Configure.With()
                           .DefiningCommandsAs(x => x.Namespace != null && x.Namespace.EndsWith("Commands"))
                           .DefaultBuilder()
                           .XmlSerializer()
                           .MsmqTransport()
                           .UnicastBus()
                           .SendOnly();
        }
    }
}
