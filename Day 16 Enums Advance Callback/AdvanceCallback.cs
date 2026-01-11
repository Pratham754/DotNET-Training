namespace MyConsoleApp
{
    public delegate void Notify(string message);
    public class OrderService
    {
        public void PlaceOrder(string orderID, Notify callback)
        {
            System.Console.WriteLine($"Order {orderID} placed.");
            callback?.Invoke($"Ordr {orderID} confirmation sent!");
        }
    }

    public class AdvanceCallback
    {
        public static void Main()
        {
            OrderService service = new();
            service.PlaceOrder("ORD-101", SendEmail);
            service.PlaceOrder("ORD-102", SendSms);
        }

        private static void SendSms(string message) => System.Console.WriteLine("SMS: " + message);
        private static void SendEmail(string message) => System.Console.WriteLine("EMAIL: " + message);
    }
}