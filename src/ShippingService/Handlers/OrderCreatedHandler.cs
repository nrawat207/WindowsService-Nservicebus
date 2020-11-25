using Events;
using log4net;
using NServiceBus;

namespace ShippingService.Handlers
{
    public class OrderCreatedHandler : IHandleMessages<OrderCreated>
    {
        public IBus Bus { get; set; }
        private readonly ILog log = LogManager.GetLogger(typeof(OrderCreatedHandler));

        public void Handle(OrderCreated message)
        {
            log.DebugFormat("Order recevied for Shipping.OrderId: {0}", message.OrderId);

            log.DebugFormat("Order Packages and Shipped Successfully!!");
        }
    }
}
