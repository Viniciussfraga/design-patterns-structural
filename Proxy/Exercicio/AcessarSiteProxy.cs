namespace Proxy.Exercicio;
public class AcessarSiteProxy : IAcessoSite
{
    private IAcessoSite acesso;
    private List<string> sites = ["pt.wikipedia.org", "abc.com.br", "def.net"];
    public void AcessarSite(string url)
    {
        if(sites.Contains(url))
        {
            acesso = new AcessarSite();
            System.Console.WriteLine("Este link é valido para acessar, redirecionando.");
            acesso.AcessarSite(url);
        }
        else
            System.Console.WriteLine("Este link não é valido.");
            
    }
}