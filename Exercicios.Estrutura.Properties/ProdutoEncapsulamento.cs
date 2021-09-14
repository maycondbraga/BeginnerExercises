using System;
using System.Globalization;

namespace Exercicios.Estrutura.Properties
{
    class ProdutoEncapsulamento
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        /// <summary> Construtor padrão </summary>
        public ProdutoEncapsulamento() { }

        /// <summary> Construtor personalizado de ProdutoConstrutor que recebe os paramêtros de início </summary>
        public ProdutoEncapsulamento(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public ProdutoEncapsulamento(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        /// <summary> Get e Set manual para nome do produto </summary>
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome Inválido");
            }
            else
            {
                _nome = nome;
            }
        }

        /// <summary> Get e Set manual para preço do produto </summary>
        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            if (preco < 0)
            {
                Console.WriteLine("Preço Inválido");
            }
            else
            {
                _preco = preco;
            }
        }

        /// <summary> Get manual para quantidade do produto </summary>
        public int GetQuantidade()
        {
            return _quantidade;
        }

        /// <summary> Retorna o total em estoque </summary>
        public double ValorTotalEmEstoque()
        {
            double total = _preco * _quantidade;
            return total;
        }

        ///<summary> Adiciona unidades a um produto determinado </summary>
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        ///<summary> Remove unidades a um produto determinado </summary>
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        /// <summary> Formata corretamente o objeto Produto </summary>
        public override string ToString()
        {
            string preco = _preco.ToString("F2", CultureInfo.InvariantCulture);
            string total = ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return _nome + ", $ " + preco + ", " + _quantidade + " unidades, Total: $ " + total;
        }
    }
}