using System;

namespace Events
{
    public class OrderCreated
    {
        public OrderCreated()
        {
            Timestamp = DateTime.Now;
        }

        public OrderCreated(Guid orderId) : this()
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
