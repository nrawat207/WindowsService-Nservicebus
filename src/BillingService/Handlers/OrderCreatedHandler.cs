using Events;
using log4net;
using NServiceBus;

namespace BillingService.Handlers
{
    public class OrderCreatedHandler : IHandleMessages<OrderCreated>
    {
        public IBus Bus { get; set; }
        private readonly ILog log = LogManager.GetLogger(typeof(OrderCreatedHandler));

        public void Handle(OrderCreated message)
        {
            log.DebugFormat("Order received for billing.OrderId: {0}", message.OrderId);
            log.DebugFormat("Bill generated Sucessfully!!");            
        }
    }
}
