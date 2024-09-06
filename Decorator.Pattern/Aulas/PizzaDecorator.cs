namespace Decorator.Pattern.Aulas
{
    //Decorator
    public abstract class PizzaDecorator : IPizza
    {
        protected readonly IPizza _pizza;

        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string Opcionais()
        {
            var opcional = _pizza.Opcionais();
            return opcional;
        }

        public virtual decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }
    }
}