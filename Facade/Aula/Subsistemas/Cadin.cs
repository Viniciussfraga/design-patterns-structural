namespace Facade.Aula.Subsistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            System.Console.WriteLine("Verificando CADIN do cliente " + cliente.Nome);
            return false;
        }
    }
}