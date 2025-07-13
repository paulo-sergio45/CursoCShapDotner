//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program15
//{
//     class Program15
//    {
//        static void Main(string[] args)
//        {
//            Produto produto = new Produto();

//            Console.WriteLine("Entre com os dados do produto");
//            Console.Write("Nome: ");
//            produto.Nome = Console.ReadLine();
//            Console.Write("Preco: ");
//            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Quantidade: ");
//            produto.Quantidade = int.Parse(Console.ReadLine());


//            Console.WriteLine($"Dados do produto:  {produto.ToString()}");


//            Console.WriteLine();
//            Console.WriteLine("Digite o numero de produtos a ser adicionado");
//            int qte = int.Parse(Console.ReadLine());
//            produto.AdicionarProdutos(qte);

//            Console.WriteLine($"Dados Atualizados:  {produto.ToString()}");

//            Console.WriteLine();
//            Console.WriteLine("Digite o numero de produtos a ser removido");
//             qte = int.Parse(Console.ReadLine());
//            produto.RemoverProdutos(qte);

//            Console.WriteLine($"Dados Atualizados:  {produto.ToString()}");

//        }
//    }
//}
