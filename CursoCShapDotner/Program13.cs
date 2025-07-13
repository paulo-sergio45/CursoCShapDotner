//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner
//{
//    class Program13
//    {
//        static void Main(string[] args)
//        {
//            double xA, xB, xC, yA, yB, yC;

//            Console.WriteLine("Entre com as medidas do triangulo X:");
//            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com as medidas do triangulo Y:");
//            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double pX = (xA + xB + xC) / 2.0;
//            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

//            double pY = (yA + yB + yC) / 2.0;
//            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

//            Console.WriteLine("Area de X = " + areaX.ToString("F4",CultureInfo.InvariantCulture));
//            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//            if (areaX>areaY)
//            {
//                Console.WriteLine("Maior Area: X ");
//            }
//            else
//            {
//                Console.WriteLine("Maior Area: Y ");

//            }
//        }
//    }
//}
