namespace Composite.Exercicio
{
    //leaf
    public class Questao : ItemQuestionario
    {
        public Questao(string descricao) : base(descricao){}
        public override void Exibir()
        {
            Console.WriteLine($"Questão : {Descricao}");
        }
    }
}