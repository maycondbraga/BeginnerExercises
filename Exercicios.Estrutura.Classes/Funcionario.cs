using System.Globalization;

namespace Exercicios.Estrutura.Classes
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        /// <summary> Retorna o salario com imposto descontado </summary>
        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        /// <summary> Calcula o aumento salarial </summary>
        public void AumentarSalario(double porcentagem)
        {
            double aumento = (porcentagem / 100) * SalarioBruto;
            SalarioBruto += aumento;
        }

        /// <summary> Formata corretamente o objeto Funcionário </summary>
        public override string ToString()
        {
            string salarioLiquido = SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
            return Nome + ", R$ " + salarioLiquido;
        }
    }
}
