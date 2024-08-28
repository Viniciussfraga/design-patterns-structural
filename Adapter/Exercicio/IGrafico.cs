namespace Adapter.Exercicio
{
    public interface IGrafico
    {
        string Titulo { get; set; }
        List<string> XValor { get; set; }
        List<int> YValor { get; set; }

        void GerarGrafico(string titulo, List<string> x, List<int> y);
    }
}