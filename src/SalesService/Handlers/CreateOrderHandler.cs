using Commands;
using Events;
using log4net;
using NServiceBus;

namespace SalesService.Handlers
{
    public class CreateOrderHandler : IHandleMessages<CreateOrder>
    {
        public IBus Bus { get; set; }
        private readonly ILog log = LogManager.GetLogger(typeof(CreateOrderHandler));

        public void Handle(CreateOrder message)
        {
            log.DebugFormat("Create Order recevied.OrderId: {0}", message.OrderId);            

            var orderCreatedMessage = new OrderCreated(message.OrderId);
            log.DebugFormat("Order Created successfully");

            Bus.Publish(orderCreatedMessage);
        }
    }
}
