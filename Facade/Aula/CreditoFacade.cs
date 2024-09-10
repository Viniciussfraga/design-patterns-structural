using Facade.Aula.Subsistemas;

namespace Facade.Aula
{
    public class CreditoFacade
    {
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public CreditoFacade()
        {
            limite = new LimiteCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            System.Console.WriteLine($"{cliente.Nome} está pleitando um empréstimo no valor de {valor:C}\n");

            cadastro.CadastrarCliente(cliente);
            bool concederEmprestimo = true;

            if(serasa.EstaNoSerasa(cliente))
            {
                System.Console.WriteLine($"Cliente {cliente.Nome} possui restrição no SERASA");
                concederEmprestimo = false;
            }

            if(cadin.EstaNoCadin(cliente))
            {
                System.Console.WriteLine($"Cliente {cliente.Nome} possui restrição no CADIN");
                concederEmprestimo = false;
            }

            if(!limite.PossuiLimiteCredito(cliente, valor))
            {
                 System.Console.WriteLine($"Cliente {cliente.Nome} possui limite de crédito inferior a {valor:C}\n");
                concederEmprestimo = false;
            }

            return concederEmprestimo;
        }
    }
}