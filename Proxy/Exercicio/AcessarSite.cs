namespace Proxy.Exercicio;
public class AcessarSite : IAcessoSite
{
    void IAcessoSite.AcessarSite(string url)
    {
         System.Console.WriteLine($"### Acessado site {url} ###");
    }
}