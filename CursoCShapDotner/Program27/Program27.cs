﻿//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CursoC_Dotner.Program27.Entities;
//using CursoC_Dotner.Program27.Services;

//namespace CursoC_Dotner.Program27
//{
//    internal class Program27
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter rental data");
//            Console.Write("Car model: ");
//            string model = Console.ReadLine();
//            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
//            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
//            Console.Write("Return (dd/MM/yyyy HH:mm): ");
//            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

//            Console.Write("Enter price per hour: ");
//            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Enter price per day: ");
//            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

//            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

//            rentalService.ProcessInvoice(carRental);

//            Console.WriteLine("INVOICE:");
//            Console.WriteLine(carRental.Invoice);
//        }
//    }
//}
