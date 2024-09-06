namespace Decorator.Pattern.Aulas
{
        //ConcreteComponent
    public class Pizza : IPizza
    {
        public string Nome { get; set; }
        public Pizza(string nome)
        {
            Nome = nome;
        }

        public string Opcionais()
        {
            var opcional = $"Pizza de {Nome}";
            return opcional;
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}