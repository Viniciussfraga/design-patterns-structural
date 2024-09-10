using Facade.Exercicio.Subsistemas;

namespace Facade.Exercicio
{
    //facade
    public class ComparaPreco
    {
        private ServicoAClient serviceA;
        private ServicoBClient serviceB;

        public ComparaPreco()
        {
            serviceA = new ServicoAClient();
            serviceB = new ServicoBClient();
        }
        public List<Livro> CompararPreco(string isbn)
        {
            var livroVendedor1 = serviceA.PesquisaLivro(isbn);
            var livroVendedor2 = serviceB.PesquisaLivro(isbn);

            var livros = new List<Livro>();
            livros.Add(livroVendedor1);
            livros.Add(livroVendedor2);
            livros.Sort(delegate (Livro b1, Livro b2)
            {
                return b1.Preco.CompareTo(b2.Preco);
            });

            return livros;
        }
    }
}