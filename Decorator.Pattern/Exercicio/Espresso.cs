namespace Decorator.Pattern.Exercicio
{
    public class Espresso : ICafe
    {
        public string Nome { get; set; }

         public Espresso()
        {
            Nome = "Espresso";
        }

        public string Descricao()
        {
            return $"Café {Nome}";
        }

        public decimal Preco()
        {
            return 4.00M;
        }
    }
}