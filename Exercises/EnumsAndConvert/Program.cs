using EnumsAndConvert.Entities;
using EnumsAndConvert.Entities.Enums;
using System;
using System.Globalization;

namespace EnumsAndConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}