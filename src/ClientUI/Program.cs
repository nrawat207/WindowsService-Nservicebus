using Commands;
using log4net;
using System;

namespace ClientUI
{
    class Program
    {       
        
        static void Main(string[] args)
        {          
            var message = new CreateOrder("Test Order", 100);
            Console.WriteLine("Create order intiated from Client: Order Id {0}, Description:{1}", message.OrderId, message.Description);
            NServiceBusHelper.Bus.Send(message);
            Console.ReadLine();
        }
    }
}
