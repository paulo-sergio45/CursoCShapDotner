//using System;
//using System.Globalization;

//namespace CursoC_Dotner
//{
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            char genero = 'F';
//            int idade = 32;
//            double saldo = 10.35784;
//            string nome = "paulo";

//            Console.Write("Bom dia!");//nao quebra
//            Console.WriteLine("Boa tarde");//quebra linha
//            Console.WriteLine("Boa Noite");//quebra linha
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.WriteLine("===============/*/===============");
//            Console.BackgroundColor = ConsoleColor.Black;
//            Console.WriteLine(genero);
//            Console.WriteLine(idade);
//            Console.WriteLine(nome);
//            Console.WriteLine(saldo);
//            Console.WriteLine(saldo.ToString("F2"));
//            Console.WriteLine(saldo.ToString("F4"));
//            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));

//            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome,idade,saldo);

//            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

//            Console.WriteLine(nome+" tem "+idade+" anos e tem saldo igual a "+saldo.ToString("F2") + " reais");

//        }
//    }
//}