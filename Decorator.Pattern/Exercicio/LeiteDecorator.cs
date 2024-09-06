namespace Decorator.Pattern.Exercicio
{
    public class LeiteDecorator : OpcionalDecorator
    {
        public LeiteDecorator(ICafe cafe) : base(cafe)
        {
        }

        public override string Descricao()
        {
            var descricao = base.Descricao();
            descricao += "\r\n com leite";
            return descricao;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 2.00M;
            return preco;
        }
    }
}