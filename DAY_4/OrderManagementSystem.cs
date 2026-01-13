using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4
{
    public class OrderManagementSystem
    {
        public static void Main(String[] args)
        {
            // Create delivery location
            DeliveryLocation location = new DeliveryLocation
            {
                City = "Tirupati",
                State = "Andhra Pradesh",
                Pincode = 517502
            };

            // Choose payment method
            IPayment payment = new UPIPayment();
            // IPayment payment = new CreditCardPayment();

            // Create order
            Order order = new Order(101, 2500, location, payment);

            // Process order
            order.ProcessPayment();
            order.ShipOrder();
            order.DeliverOrder();

            // Display details
            order.DisplayOrderDetails();
        }

    }
}
