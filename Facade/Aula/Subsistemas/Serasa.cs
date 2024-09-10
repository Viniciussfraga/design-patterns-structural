namespace Facade.Aula.Subsistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            System.Console.WriteLine("Verificando SERASA do cliente " + cliente.Nome);
            return false;
        }
    }
}