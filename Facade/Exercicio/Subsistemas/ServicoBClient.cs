namespace Facade.Exercicio.Subsistemas
{
    public class ServicoBClient
    {
         private ServicoB servicoB;
        public ServicoBClient()
        {
            servicoB = new ServicoB();
        }
        public Livro PesquisaLivro(string isbn)
        {
            return servicoB.GetLivro(isbn);
        }
    }
}