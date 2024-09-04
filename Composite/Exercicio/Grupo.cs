namespace Composite.Exercicio
{
    //composite
    public class Grupo : ItemQuestionario
    {
        private List<ItemQuestionario> itens = new();
        public Grupo(string descricao) : base(descricao) {}

        public override void Exibir()
        {
            Console.WriteLine($"Grupo : {Descricao}");
            itens.ForEach(i => i.Exibir());
        }
        public void Add(ItemQuestionario item)
        {
            itens.Add(item);
        }
        public void Remove(ItemQuestionario item)
        {
            itens.Remove(item);
        }
    }
}