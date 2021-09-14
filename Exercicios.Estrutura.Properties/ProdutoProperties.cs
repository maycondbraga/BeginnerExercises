using System;
using System.Globalization;

namespace Exercicios.Estrutura.Properties
{
    class ProdutoProperties
    {
        private string _nome;
        private double _preco;
        public int Quantidade { get; private set; }

        /// <summary> Construtor padrão </summary>
        public ProdutoProperties() { }

        /// <summary> Construtor personalizado de ProdutoConstrutor que recebe os paramêtros de início </summary>
        public ProdutoProperties(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public ProdutoProperties(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = 0;
        }

        /// <summary> Get e Set para nome do produto </summary>
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                { 
                    Console.WriteLine("Nome Inválido"); 
                }
                else 
                { 
                    _nome = value; 
                }
            }
        }

        /// <summary> Get e Set para preço do produto </summary>
        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value < 0) 
                { 
                    Console.WriteLine("Preço Inválido"); 
                }
                else 
                { 
                    _preco = value; 
                }
            }
        }

        /// <summary> Retorna o total em estoque </summary>
        public double ValorTotalEmEstoque
        {
            get { return _preco * Quantidade; }
        }

        ///<summary> Adiciona unidades a um produto determinado </summary>
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        ///<summary> Remove unidades a um produto determinado </summary>
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        /// <summary> Formata corretamente o objeto Produto </summary>
        public override string ToString()
        {
            string preco = _preco.ToString("F2", CultureInfo.InvariantCulture);
            string total = ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);

            return _nome + ", $ " + preco + ", " + Quantidade + " unidades, Total: $ " + total;
        }
    }
}
