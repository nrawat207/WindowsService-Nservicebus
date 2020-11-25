using System;

namespace Commands
{
    public class CreateOrder
    {
        public CreateOrder()
        {
            OrderId = Guid.NewGuid();
            Timestamp = DateTime.Now;
        }

        public CreateOrder(string description, decimal amount) : this()
        {
            Description = description;
            Amount = amount;
        }

        public Guid OrderId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
