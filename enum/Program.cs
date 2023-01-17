using System;
using Exercicio.Entities;
using Exercicio.Entities.Enums;

namespace Exercicio{
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}
