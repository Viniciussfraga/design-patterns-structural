using Adapter.Domain;

namespace Adapter
{
    //Adaptee
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (var aluno in listaAlunos)
            {
                var mensalidade = aluno.Mensalidade * 1.1M;

                Console.WriteLine($"Aluno {aluno.Nome} " + 
                $"- Valor da mensalidade R$ {mensalidade}");
            }
        }
    }
}