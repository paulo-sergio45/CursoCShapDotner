//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program20
//{
//    internal class Program20
//    {
//        static void Main(string[] args)
//        {

//            int s1 = Calculator.Sum(1, 2);
//            int s2 = Calculator.Sum(1, 2, 3);

//            double s3 = Calculator.Sum(new double[] { 1.0, 2.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 });
//            int s4 = Calculator.Sum( 1, 2, 4, 5, 6, 7, 8, 9, 10);

//            Console.WriteLine("s1= " + s1);
//            Console.WriteLine("s2= " + s2);
//            Console.WriteLine("s3= " + s3);
//            Console.WriteLine("s4= " + s4);

//            Console.WriteLine("////////////////////////////////////////////");

//            int a = 10;
//             Calculator.Triple(a);

//            Console.WriteLine("a= " + a);

//            int b = 10;
//            Calculator.Triple(ref b);

//            Console.WriteLine("b= " + b);


//            int c = 10;
//            int triple;
//            Calculator.Triple(c ,out triple);

//            Console.WriteLine("c= " + c);
//            Console.WriteLine("triple= " + triple);

//            int x = 20;

//            Console.WriteLine("boxing x= " + x);

//            Object obj = x;


//            Console.WriteLine("boxing obj= " + obj);

//            int y =(int) obj;

//            Console.WriteLine("boxing y= " + y);

//        }
//    }
//}
