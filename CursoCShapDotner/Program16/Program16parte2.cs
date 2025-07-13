//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program16
//{
//    class Program16
//    {

//        static void Main(string[] args)
//        {
//            Calculadora calculadora = new Calculadora();

//            Console.WriteLine("Entre com o vaor doraio: ");
//            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double circ = calculadora.Circuferencia(raio);

//            double volume = calculadora.Volume(raio);


//            Console.WriteLine($"Circuferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
//            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
//            Console.WriteLine($"Valor de Pi: {calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

//            //operacao statico nao depende do objeto entao e statico

//            Calculadora calculadora1 = new Calculadora();
//            Calculadora calculadora2 = new Calculadora();

//            Console.WriteLine(calculadora1.Pi);
//            Console.WriteLine(calculadora2.Pi);
//            Console.WriteLine(calculadora1.Circuferencia(3.0));
//            Console.WriteLine(calculadora2.Circuferencia(3.0));

//        }
//    }
//}
