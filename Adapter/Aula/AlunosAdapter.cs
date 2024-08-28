
using Adapter.Domain;

namespace Adapter
{
    //Adapter
    public class AlunosAdapter : ICalculaMensalidade
    {
        private SistemaMensalidades sistemaMensalidades = new SistemaMensalidades();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
           var listaAlunos = ConverteArrayParaList(alunosArray);
           sistemaMensalidades.CalculaMensalidade(listaAlunos);
        }

        private List<Aluno> ConverteArrayParaList(string[,] alunosArray)
        {
            string id = "";
            string nome = "";
            string mensalidade = "";
            var alunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    switch (j) 
                    {
                        case 0:
                            id = alunosArray[i,j];
                            break;
                        case 1:
                            nome = alunosArray[i,j]; 
                            break;
                        default:
                            mensalidade = alunosArray[i,j]; 
                            break;
                    }
                }
                alunos.Add(new Aluno(Convert.ToInt32(id), nome, Convert.ToDecimal(mensalidade)));
            }
            return alunos;
        }
    }
}