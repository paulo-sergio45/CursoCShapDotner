//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CursoC_Dotner.Program27.Devices;
//using CursoC_Dotner.Program27.Entities;

//namespace CursoC_Dotner.Program27
//{
//    class Program27_3
//    {
//        static void Main(string[] args)
//        {
//            string path = @"c:\temp\in.txt";
//            try
//            {
//                using (StreamReader sr = File.OpenText(path))
//                {
//                    List<Employee> list = new List<Employee>();
//                    while (!sr.EndOfStream)
//                    {
//                        list.Add(new Employee(sr.ReadLine()));
//                    }
//                    list.Sort();
//                    foreach (Employee emp in list)
//                    {
//                        Console.WriteLine(emp);
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}
