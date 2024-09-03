namespace Bridge.Exercicio
{
    //ConcreteImplementor
    public class GeraXML : IGeraArquivo
    {
        public void GeraArquivo(Funcionario func)
        {
            System.Console.WriteLine($"Dados do funcionario {func.Nome} gerados no formato XML");
        }
    }
}