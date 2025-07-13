//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CursoC_Dotner.Program25.Entities.Exceptions;
//using CursoC_Dotner.Program25.Entities;
//using System.Globalization;

//namespace CursoC_Dotner.Program25
//{
//    internal class Program25
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                int n1 = (10);
//                int n2 = (0);
//                int result = n1 / n2;
//                Console.WriteLine(result);
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine($"Error! {e.Message}");
//            }

//            Console.Write("------------------------------//---------------------------------");

//            //finally
//            //FileStream fs = null;
//            //try
//            //{
//            //    fs = new FileStream(@"", FileMode.Open);
//            //    StreamReader sr = new StreamReader(fs);
//            //    string line = sr.ReadLine();
//            //    Console.WriteLine(line);
//            //}
//            //catch (FileNotFoundException e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}
//            //finally
//            //{
//            //    if (fs != null)
//            //    {
//            //        fs.Close();
//            //    }


//            //}

//            Console.Write("------------------------------//---------------------------------");


//            try
//            {
//                Console.Write("Room number: ");
//                int number = int.Parse(Console.ReadLine());
//                Console.Write("Check-in date (dd/MM/yyyy): ");
//                DateTime checkIn = DateTime.Parse(Console.ReadLine());
//                Console.Write("Check-out date (dd/MM/yyyy): ");
//                DateTime checkOut = DateTime.Parse(Console.ReadLine());

//                Reservation reservation = new Reservation(number, checkIn, checkOut);
//                Console.WriteLine("Reservation: " + reservation);

//                Console.WriteLine();
//                Console.WriteLine("Enter data to update the reservation:");
//                Console.Write("Check-in date (dd/MM/yyyy): ");
//                checkIn = DateTime.Parse(Console.ReadLine());
//                Console.Write("Check-out date (dd/MM/yyyy): ");
//                checkOut = DateTime.Parse(Console.ReadLine());

//                reservation.UpdateDates(checkIn, checkOut);
//                Console.WriteLine("Reservation: " + reservation);
//            }
//            catch (FormatException e)
//            {
//                Console.WriteLine("Error in format: " + e.Message);
//            }
//            catch (DomainException e)
//            {
//                Console.WriteLine("Error in reservation: " + e.Message);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Unexpected error: " + e.Message);
//            }


//            Console.Write("------------------------------//---------------------------------");
//            try
//            {
//                Console.WriteLine("Enter account data");
//            Console.Write("Number: ");
//            int number = int.Parse(Console.ReadLine());
//            Console.Write("Holder: ");
//            String holder = Console.ReadLine();
//            Console.Write("Initial balance: ");
//            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Withdraw limit: ");
//            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Account acc = new Account(number, holder, balance, withdrawLimit);

//            Console.WriteLine();
//            Console.Write("Enter amount for withdraw: ");
//            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
//                acc.Withdraw(amount);
//                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
//            }
//            catch (DomainException e)
//            {
//                Console.WriteLine("Withdraw error: " + e.Message);
//            }


//        }
//        }
//}
