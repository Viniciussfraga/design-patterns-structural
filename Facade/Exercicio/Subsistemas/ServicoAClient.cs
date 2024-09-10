namespace Facade.Exercicio.Subsistemas
{
    public class ServicoAClient
    {
        private ServicoA servicoA;
        public ServicoAClient()
        {
            servicoA = new ServicoA();
        }
        public Livro PesquisaLivro(string isbn)
        {
            return servicoA.GetLivro(isbn);
        }
    }
}