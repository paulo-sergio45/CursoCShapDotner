//using CursoC_Dotner.Program23.Entities;


//namespace CursoC_Dotner.Program23
//{
//    internal class Program24
//    {
//        static void Main(string[] args)
//        {
//            Order order = new Order
//            {
//                Id = 1000,
//                Moment = DateTime.Now,
//                Status = OrderStatus.Shipped,
//            };

//            OrderStatus os1 = (OrderStatus)2;
//            int n1 = (int)OrderStatus.Processing;

//            string txt = OrderStatus.PendingPayment.ToString();
//            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

//            OrderStatus os2 = Enum.Parse<OrderStatus>("Delivered");

//            OrderStatus os3 = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

//            OrderStatus os4;
//            Enum.TryParse("Delivered", out os4);

//            Console.WriteLine(order);

//            Console.WriteLine(os);
//            Console.WriteLine(txt);
//            Console.WriteLine(os1);
//            Console.WriteLine(n1);
//            Console.WriteLine(os2);
//            Console.WriteLine(os3);
//            Console.WriteLine(os4);
//        }
        
//    }
//}
