namespace Decorator.Pattern.Aulas
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += "\r\n com borda recheada";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 3.00M;
            return preco;
        }
    }
}