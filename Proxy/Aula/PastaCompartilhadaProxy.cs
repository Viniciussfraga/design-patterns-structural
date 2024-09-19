namespace Proxy.Aula
{
    //Proxy
    public class PastaCompartilhadaProxy(Funcionario func) : IPastaCompartilhada
    {
        private Funcionario Funcionario { get; } = func;
        private IPastaCompartilhada pasta;
        public void OperacaoDeLeituraGravacao()
        {
            if(Funcionario.Perfil.ToUpper() == "CEO")
            {
                pasta = new PastaCompartilhada();
                System.Console.WriteLine("O proxy 'Pasta Compartilhada' invoca a pasta Real : método usado: OperacaoDeLeituraGravacao()\n");

                pasta.OperacaoDeLeituraGravacao();
            }
            else
                System.Console.WriteLine("O proxy 'Pasta Compartilhada' avisa: 'Você não tem permissão para acessar esta pasta'\n");
        }
    }
}