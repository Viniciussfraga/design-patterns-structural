namespace Decorator.Pattern.Exercicio
{
    public abstract class OpcionalDecorator : ICafe
    {
        protected readonly ICafe _cafe;

        protected OpcionalDecorator(ICafe cafe)
        {
            _cafe = cafe;
        }

        public virtual string Descricao()
        {
            return _cafe.Descricao();
        }

        public virtual decimal Preco()
        {
            return _cafe.Preco();
        }
    }
}