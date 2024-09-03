namespace Bridge.Exercicio
{
    //ConcreteImplementor
    public class GeraJson : IGeraArquivo
    {
         public void GeraArquivo(Funcionario func)
        {
            System.Console.WriteLine($"Dados do funcionario {func.Nome} gerados no formato JSON");
        }
    }
}