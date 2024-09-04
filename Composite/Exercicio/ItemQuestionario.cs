namespace Composite.Exercicio
{
    //Component
    public abstract class ItemQuestionario
    {
        protected string Descricao { get; set; }
        public ItemQuestionario(string descricao)
        {
            Descricao = descricao;
        }        
        public abstract void Exibir();
    }
}