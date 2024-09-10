namespace Facade.Aula.Subsistemas
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            System.Console.WriteLine($"Cadastro do cliente {cliente.Nome} sem pendências");
        }
    }
}