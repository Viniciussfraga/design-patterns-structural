namespace Facade.Exercicio
{
    public class Livro
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Preco { get; set; }
        public string Origem { get; set; }

        public Livro(int id, string isbn, string titulo, string autor, decimal preco, string origem)
        {
            Id = id;
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Preco = preco;
            Origem = origem;
        }
    }
}