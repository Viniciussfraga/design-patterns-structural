namespace Adapter.Exercicio
{
    //adaptee
    public sealed class SuperGeradorGrafico
    {
        public void init() {}
        public void DesenharGrafico (string titulo, List<string> x, List<int> y)
        {
            Console.WriteLine("\n ** SuperGeradorGrafico : Gerando Gráfico com efeitos **");
        }
    }
}