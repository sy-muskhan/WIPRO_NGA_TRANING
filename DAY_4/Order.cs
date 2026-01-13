using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4
{
    using System;

    // ===============================
    // ENUM : Order Status
    // ===============================
    enum OrderStatus
    {
        Placed,
        Confirmed,
        Shipped,
        Delivered,
        Cancelled
    }

    // ===============================
    // STRUCT : Delivery Location
    // ===============================
    struct DeliveryLocation
    {
        public string City;
        public string State;
        public int Pincode;

        public void Display()
        {
            Console.WriteLine($"Delivery Location: {City}, {State} - {Pincode}");
        }
    }

    // ===============================
    // PAYMENT CLASS : UPI
    // ===============================
    class UPIPayment : IPayment
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} completed using UPI.");
        }
    }

    // ===============================
    // PAYMENT CLASS : Credit Card
    // ===============================
    class CreditCardPayment : IPayment
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} completed using Credit Card.");
        }
    }

    // ===============================
    // MAIN BUSINESS LOGIC CLASS
    // ===============================
    class Order
    {
        public int OrderId;
        public decimal Amount;
        public OrderStatus Status;
        public DeliveryLocation Location;

        private IPayment paymentMethod;

        public Order(int orderId, decimal amount, DeliveryLocation location, IPayment payment)
        {
            OrderId = orderId;
            Amount = amount;
            Location = location;
            paymentMethod = payment;
            Status = OrderStatus.Placed;
        }

        public void ProcessPayment()
        {
            paymentMethod.MakePayment(Amount);
            Status = OrderStatus.Confirmed;
        }

        public void ShipOrder()
        {
            Status = OrderStatus.Shipped;
        }

        public void DeliverOrder()
        {
            Status = OrderStatus.Delivered;
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("\nOrder Details");
            Console.WriteLine("Order ID : " + OrderId);
            Console.WriteLine("Amount   : " + Amount);
            Console.WriteLine("Status   : " + Status);
            Location.Display();
        }
    }

}
