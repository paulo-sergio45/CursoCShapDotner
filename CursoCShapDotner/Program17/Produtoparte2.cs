//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program17
//{
//    class Produto
//    {
//        public string Nome;

//        public double Preco;

//        public int Quantidade;

//        public Produto()
//        {
//            Quantidade = 10;
//        }

//        public Produto(string nome, double preco) : this()
//        {
//            Nome = nome;
//            Preco = preco;
//        }
//        public Produto(string nome, double preco, int quantidade) : this()
//        {
//            Quantidade = quantidade;
//        }


//        public double ValotTotalEmEstoque()
//        {
//            return Preco * Quantidade;
//        }

//        public void AdicionarProdutos(int quantidade)
//        {
//            Quantidade += quantidade;
//        }

//        public void RemoverProdutos(int quantidade)
//        {
//            Quantidade -= quantidade;
//        }


//        public override string ToString()
//        {
//            return $"{Nome} , $ {Preco.ToString("F2", CultureInfo.InvariantCulture)} , {Quantidade} unidades, Total: $ {ValotTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
//        }
//    }
//}
