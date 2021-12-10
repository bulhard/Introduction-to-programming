using System;
using System.IO;
using System.Text.Json;

namespace Lesson_09_Files
{
    public static class Exercise3
    {
        public static void PlayWithOrders(string workingFolder)
        {
            Order order = CreateOrder(1);
            ExportOrder(workingFolder, order);

            order = CreateOrder(2);
            ExportOrder(workingFolder, order);

            order = CreateOrder(3);
            ExportOrder(workingFolder, order);

            Order storedOrder = ReadOrder(workingFolder, 1);

            Console.WriteLine(storedOrder.ID);
        }

        private static Order ReadOrder(string workingFolder, int orderId)
        {
            string orderFile = Path.Combine(workingFolder, "Orders", orderId.ToString() + ".txt");

            string orderAsJsonString = File.ReadAllText(orderFile);

            return JsonSerializer.Deserialize<Order>(orderAsJsonString);
        }

        private static void ExportOrder(string workingFolder, Order order)
        {
            // Convert Object to String in order to save it as text
            JsonSerializerOptions o = new JsonSerializerOptions();
            o.WriteIndented = true;
            var orderAsJsonString = JsonSerializer.Serialize(order, o);

            string orderFile = Path.Combine(workingFolder, "Orders", order.ID.ToString() + ".txt");

            File.WriteAllText(orderFile, orderAsJsonString.ToString());
        }

        private static Order CreateOrder(int orderId)
        {
            var order = new Order
            {
                ID = orderId,
                Date = DateTime.Now
            };

            order.Products.Add(new Product { ID = 1, Name = "Car", Price = 50000, Quantity = 2 });
            order.Products.Add(new Product { ID = 1, Name = "Book", Price = 50, Quantity = 22 });
            order.Products.Add(new Product { ID = 1, Name = "Socks", Price = 5, Quantity = 1 });

            return order;
        }
    }
}