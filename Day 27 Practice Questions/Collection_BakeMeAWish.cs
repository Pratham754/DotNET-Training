using System;
using System.Collections.Generic;

namespace BakeMeAWish
{
    #region CakeOrder
    public class CakeOrder
    {
        // Stores order id and cake cost
        private readonly static Dictionary<string, double> orders = [];

        /// <summary>
        /// Adds a cake order to the collection.
        /// </summary>
        public static void AddOrder(string orderId, double cost)
        {
            orders.TryAdd(orderId, cost);
        }

        /// <summary>
        /// Returns orders with cost greater than the given value.
        /// </summary>
        public static Dictionary<string, double> GetOrdersAboveCost(double cost)
        {
            Dictionary<string, double> result = [];

            foreach (var order in orders)
            {
                if (order.Value > cost)
                {
                    result[order.Key] = order.Value;
                }
            }

            return result;
        }
    }
    #endregion

    #region Program
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of cake orders to be added");

            if (!int.TryParse(Console.ReadLine(), out int count)) return;

            Console.WriteLine("Enter the cake order details (OrderId:CakeCost)");

            for (int i = 0; i < count; i++)
            {
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    i--;
                    continue;
                }

                string[] parts = input.Split(':');

                if (parts.Length != 2 || !double.TryParse(parts[1], out double cost))
                {
                    i--;
                    continue;
                }

                CakeOrder.AddOrder(parts[0], cost);
            }

            Console.WriteLine("Enter the cost to search the cake orders");

            if (!double.TryParse(Console.ReadLine(), out double searchCost))
            {
                return;
            }

            Dictionary<string, double> result = CakeOrder.GetOrdersAboveCost(searchCost);

            if (result.Count == 0) Console.WriteLine("No cake orders found");
            else
            {
                Console.WriteLine("Cake Orders above the specified cost");
                foreach (var item in result)
                {
                    Console.WriteLine($"Order ID: {item.Key}, Cake Cost: {item.Value}");
                }
            }
        }
    }
    #endregion
}