using Adapter;
using Adapter.Exercicio;

//aula
// var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();

// ICalculaMensalidade calculo = new AlunosAdapter();
// calculo.ProcessaCalculoMensalidade(alunosArray); 
// Console.ReadKey();

//exercicio

IGrafico grafico = new GraficoAdapter();
grafico.Titulo = "Gerador de Gráficos";

List<string> x = new () { "Seg", "Ter" };    
List<int> y = new () { 10, 20 };

grafico.GerarGrafico(grafico.Titulo, x, y);
Console.ReadKey();