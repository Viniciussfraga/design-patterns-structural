namespace Adapter.Exercicio
{
    public class MeuGeradorGrafico : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValor { get; set; }
        public List<int> YValor { get; set; }

        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            Console.WriteLine("\n << MeuGeradorGrafico : Gerando Gráfico >>");
        }
    }
}