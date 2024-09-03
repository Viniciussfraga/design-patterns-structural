namespace Bridge.Exercicio
{
    //RefinedAbstraction
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGeraArquivo tipo) : base(tipo)
        {
        }

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;
            System.Console.WriteLine($"O salário do funcionário {funcionario.Nome} é de {funcionario.SalarioTotal}");
            geraArquivo.GeraArquivo(funcionario);
        }
    }
}