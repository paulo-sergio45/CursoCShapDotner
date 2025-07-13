//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program18
//{
//    class Program18
//    {
//        static void Main(string[] args)
//        {
//            Point p;

//            p.x = 10;
//            p.y = 20;

//            Console.WriteLine(p);

//            p = new Point();

//            Console.WriteLine(p);

//            Nullable<double> x = null;
//            double? y = null;
//            y = 10.0;


//            Console.WriteLine("x.GetValueOrDefault()= " + x.GetValueOrDefault());
//            Console.WriteLine("y.GetValueOrDefault()= " + y.GetValueOrDefault());
//            Console.WriteLine("x.HasValue= " + x.HasValue);
//            Console.WriteLine("y.HasValue= " + y.HasValue);
//            if (x.HasValue)
//                Console.WriteLine("x.HasValue= " + x.Value);
//            else
//                Console.WriteLine("x is null ");
//            if (y.HasValue)
//                Console.WriteLine("y.HasValue= " + y.Value);
//            else
//                Console.WriteLine("y is null ");

//            double a = x ?? 5;
//            double b = y?? 5;


//            Console.WriteLine("a= " + a);
//            Console.WriteLine("b= "+b);



//        }
//    }
//}
