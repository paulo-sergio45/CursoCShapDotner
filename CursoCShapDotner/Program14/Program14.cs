﻿//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program14
//{
//    class Program14
//    {
//        static void Main(string[] args)
//        {
//            Triangulo x, y;

//            x = new Triangulo();
//            y = new Triangulo();



//            Console.WriteLine("Entre com as medidas do triangulo X:");
//            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com as medidas do triangulo Y:");
//            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//            double pX = (x.A + x.B + x.C) / 2.0;
//            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

//            double pY = (y.A + y.B + y.C) / 2.0;
//            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

//            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//            if (areaX > areaY)
//            {
//                Console.WriteLine("Maior Area: X ");
//            }
//            else
//            {
//                Console.WriteLine("Maior Area: Y ");

//            }

//            double areaX2 = x.Area();
//            double areaY2 = y.Area();

//            Console.WriteLine("Area de X2 = " + areaX2.ToString("F4", CultureInfo.InvariantCulture));
//            Console.WriteLine("Area de Y2 = " + areaY2.ToString("F4", CultureInfo.InvariantCulture));

//        }
//    }
//}
