using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_Dotner.Program17
{
    class Produto
    {
        private string _nome;

        private double _preco;

        /// <summary>
        /// autoproperties
        /// </summary>

        public int Quantidade { get;private set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public string GetNome()
        {

            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }

        }

        //public int Quantidade
        //{
        //    get { return _quantidade; }
 
        //}


        public double ValotTotalEmEstoque()
        {
            return _preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return $"{_nome} , $ {_preco.ToString("F2", CultureInfo.InvariantCulture)} , {Quantidade} unidades, Total: $ {ValotTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
