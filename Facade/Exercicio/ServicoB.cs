namespace Facade.Exercicio.Subsistemas
{
    public class ServicoB
    {
         public Livro GetLivro(string isbn)
        {
            var livros = new List<Livro>
            {
                new Livro(1, "0000", "Autor1", "Edit", 10, "Livro 1"),
                new Livro(2, "0001", "Autor2", "Edit2", 12, "Livro 2")
            };

            return livros.First(l => l.Isbn.Equals(isbn));
        }
    }
}