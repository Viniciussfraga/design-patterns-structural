namespace Proxy.Aula
{
    //RealSubject
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
           System.Console.WriteLine("### Operação de leitura e escrita na pasta compartilhada ###");
        }
    }
}