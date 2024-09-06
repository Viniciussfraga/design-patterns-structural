namespace Decorator.Pattern.Aulas
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += "\r\n com porção extra de bacon";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00M;
            return preco;
        }
    }
}