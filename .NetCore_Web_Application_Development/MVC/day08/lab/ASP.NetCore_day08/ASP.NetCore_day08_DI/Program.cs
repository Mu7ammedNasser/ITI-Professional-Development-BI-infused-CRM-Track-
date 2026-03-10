using static ASP.NetCore_day08_DI.OrderService;

namespace ASP.NetCore_day08_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            OrderService orderService = new OrderService(
                new PaymentService() ,
                new OrderRepository() ,
                new EmailServices() );
        }
    }
}
