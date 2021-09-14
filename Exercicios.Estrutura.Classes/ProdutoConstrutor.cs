using System;
using System.Globalization;

namespace Exercicios.Estrutura.Classes
{
    class ProdutoConstrutor
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /// <summary> Construtor padrão </summary>
        public ProdutoConstrutor() { }

        /// <summary> Construtor personalizado de ProdutoConstrutor que recebe os paramêtros de início </summary>
        public ProdutoConstrutor(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public ProdutoConstrutor(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        /// <summary> Retorna o total em estoque </summary>
        public double ValorTotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return total;
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
            string preco = Preco.ToString("F2", CultureInfo.InvariantCulture);
            string total = ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return Nome + ", $ " + preco + ", " + Quantidade + " unidades, Total: $ " + total;
        }
    }
}