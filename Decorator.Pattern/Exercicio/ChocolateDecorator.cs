namespace Decorator.Pattern.Exercicio
{
    public class ChocolateDecorator : OpcionalDecorator
    {
        public ChocolateDecorator(ICafe cafe) : base(cafe)
        {
        }

        public override string Descricao()
        {
            var descricao = base.Descricao();
            descricao += "\r\n com chocolate";
            return descricao;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 5.00M;
            return preco;
        }
    }
}