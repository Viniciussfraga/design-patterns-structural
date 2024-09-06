namespace Decorator.Pattern.Exercicio
{
    public class Filtrado : ICafe
    {
        public string Nome { get; set; }

         public Filtrado()
        {
            Nome = "Filtrado";
        }

        public string Descricao()
        {
            return $"Café {Nome}";
        }

        public decimal Preco()
        {
            return 3.00M;
        }
    }
}