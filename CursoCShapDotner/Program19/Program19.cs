//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program19
//{
//    internal class Program19
//    {
//        static void Main(string[] args)
//        {

//            int n = int.Parse(Console.ReadLine());

//            double[] vect = new double[n];

//            for (int i = 0; i < n; i++)
//            {
//                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            }


//            double sum = 0.0;

//            for (int i = 0; i < n; i++)
//            {
//                sum += vect[i];

//            }

//            double avg = sum / n;

//            Console.WriteLine("AVERAGE HRigth = " + avg.ToString("F2", CultureInfo.InvariantCulture));

//            Console.WriteLine("////////////////////////////");


//            int n2 = int.Parse(Console.ReadLine());

//            Product[] vect2 = new Product[n];

//            for (int i = 0; i < n2; i++)
//            {
//                string name = Console.ReadLine();
//                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                vect2[i] = new Product { Name = name, Price = price };
//            }


//            double sum2 = 0.0;

//            for (int i = 0; i < n; i++)
//            {
//                sum2 += vect2[i].Price;

//            }

//            double avg2 = sum2 / n2;

//            Console.WriteLine("AVERAGE PRICE = " + avg2.ToString("F2", CultureInfo.InvariantCulture));


                //double[,] mat = new double[2, 3];

                //Console.WriteLine(mat.Length);
                //Console.WriteLine(mat.Rank);
                //Console.WriteLine(mat.GetLength(0));
                //Console.WriteLine(mat.GetLength(1));

//        }
//    }
//}
