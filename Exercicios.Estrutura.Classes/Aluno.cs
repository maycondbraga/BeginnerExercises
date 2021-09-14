using System.Globalization;

namespace Exercicios.Estrutura.Classes
{
    class Aluno
    {
        public string Nome;
        public string[] Notas;

        public double NotaFinal()
        {
            double nota1 = double.Parse(Notas[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Notas[1], CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Notas[2], CultureInfo.InvariantCulture);

            double notaFinal = nota1 + nota2 + nota3;
            return notaFinal;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
