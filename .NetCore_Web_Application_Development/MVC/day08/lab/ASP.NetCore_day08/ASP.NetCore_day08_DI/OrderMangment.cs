using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASP.NetCore_day08_DI
{
    #region SRP but tight coupling 
    //    internal class OrderService
    //    {
    //        public void PlaceOrder(string orderId, string customerId, decimal amount)
    //        {
    //            // 1- process payment
    //            //Console.WriteLine("Processing payment...");
    //            var paymentService = new PaymentService();
    //            paymentService.processPayment(orderId, 2);

    //            // 2- send order to database
    //            //Console.WriteLine("Saving order to database...");
    //            var orderRepository = new OrderRepository();
    //            orderRepository.saveOrder(orderId, customerId, amount);

    //            // 3 - send confirmation email 
    //            //Console.WriteLine("Sending confirmation email...");
    //            var emailServices = new EmailServices();
    //            emailServices.SendConfirmationEmail(customerId, orderId);
    //        }

    //        public class PaymentService
    //        {
    //            public void processPayment(string orderId, decimal amount)
    //            {
    //                Console.WriteLine($"Processing paymanet for order {orderId} with amount {amount}...");

    //            }
    //        }
    //        public class OrderRepository
    //        {
    //            public void saveOrder(string orderId, string customerId, decimal amount)
    //            {
    //                Console.WriteLine($"Saving this order number {orderId} fro customer {customerId} with amount {amount}...");
    //            }
    //        }

    //        public class EmailServices
    //        {
    //            public void SendConfirmationEmail(string customerId, string orderId)
    //            {
    //                Console.WriteLine($"sending Email to customer with id {customerId} for order number {orderId}...");
    //            }
    //        }


    //    }
    //}

    //// ->here i solved the SRP but has another problem which is the tight coupling between the classes and the OrderService class
    //// ->as if i need to test the placeOrder method i will need to create instances of the PaymentService, OrderRepository and EmailServices
    //// classes which is not good for testing and also if i need to change the implementation of any of these classes i will need to change
    //// the OrderService class which is not good for maintainability.
    //// and this calss may be need to crate instances of another classes which will make the code more complex and hard to maintain and test ( dependecy tree ).
    #endregion


    #region just we make all methods insdie the class can access methods from fields
    //internal class OrderService
    //{

    //    private readonly PaymentService _paymentService = new PaymentService();
    //    private readonly OrderRepository _orderRepository = new OrderRepository();
    //    private readonly EmailServices _emailServices = new EmailServices();



    //    public void PlaceOrder(string orderId, string customerId, decimal amount)
    //    {
    //        // 1- process payment
    //        //Console.WriteLine("Processing payment...");
    //        //var paymentService = new PaymentService();
    //        _paymentService.processPayment(orderId, 2);

    //        // 2- send order to database
    //        //Console.WriteLine("Saving order to database...");
    //        //var orderRepository = new OrderRepository();
    //        _orderRepository.saveOrder(orderId, customerId, amount);

    //        // 3 - send confirmation email 
    //        //Console.WriteLine("Sending confirmation email...");
    //        //var emailServices = new EmailServices();
    //        _emailServices.SendConfirmationEmail(customerId, orderId);
    //    }

    //    public class PaymentService
    //    {
    //        public void processPayment(string orderId, decimal amount)
    //        {
    //            Console.WriteLine($"Processing paymanet for order {orderId} with amount {amount}...");

    //        }
    //    }
    //    public class OrderRepository
    //    {
    //        public void saveOrder(string orderId, string customerId, decimal amount)
    //        {
    //            Console.WriteLine($"Saving this order number {orderId} fro customer {customerId} with amount {amount}...");
    //        }
    //    }

    //    public class EmailServices
    //    {
    //        public void SendConfirmationEmail(string customerId, string orderId)
    //        {
    //            Console.WriteLine($"sending Email to customer with id {customerId} for order number {orderId}...");
    //        }
    //    }


    //}
    #endregion

    #region MyRegion
    internal class OrderService
    {

        //private readonly PaymentService _paymentService = new PaymentService();
        private readonly IPaymentService _paymentService;

        //private readonly OrderRepository _orderRepository = new OrderRepository();
        private readonly IOrderRepository _orderRepository;

        //private readonly EmailServices _emailServices = new EmailServices();
        private readonly IEmailServices _emailServices;

        // the above code applyed the dependency inversion principle as we depend on abstractions ( interfaces )
        // not on concretions ( classes )

        public OrderService( IPaymentService paymentService , IOrderRepository orderRepository , IEmailServices emailServices )
        {
            _paymentService = paymentService;
            _orderRepository = orderRepository;
            _emailServices = emailServices;
        }



        public void PlaceOrder(string orderId, string customerId, decimal amount)
        {
            // 1- process payment
            //Console.WriteLine("Processing payment...");
            //var paymentService = new PaymentService();
            _paymentService.processPayment(orderId, 2);

            // 2- send order to database
            //Console.WriteLine("Saving order to database...");
            //var orderRepository = new OrderRepository();
            _orderRepository.saveOrder(orderId, customerId, amount);

            // 3 - send confirmation email 
            //Console.WriteLine("Sending confirmation email...");
            //var emailServices = new EmailServices();
            _emailServices.SendConfirmationEmail(customerId, orderId);
        }

        #region PaymentService
        public interface IPaymentService
        {
            void processPayment(string orderId, decimal amount);
        }

        public class PaymentService : IPaymentService
        {
            public void processPayment(string orderId, decimal amount)
            {
                Console.WriteLine($"Processing paymanet for order {orderId} with amount {amount}...");

            }
        }
        #endregion

        #region OrderRepository
        public interface IOrderRepository
        {
            void saveOrder(string orderId, string customerId, decimal amount);
        }
        public class OrderRepository : IOrderRepository
        {
            public void saveOrder(string orderId, string customerId, decimal amount)
            {
                Console.WriteLine($"Saving this order number {orderId} fro customer {customerId} with amount {amount}...");
            }
        }


        #endregion

        #region EmailServices
        public interface IEmailServices
        {
            void SendConfirmationEmail(string customerId, string orderId);
        }

        public class EmailServices : IEmailServices
        {
            public void SendConfirmationEmail(string customerId, string orderId)
            {
                Console.WriteLine($"sending Email to customer with id {customerId} for order number {orderId}...");
            }
        } 
        #endregion

    }
    #endregion

}