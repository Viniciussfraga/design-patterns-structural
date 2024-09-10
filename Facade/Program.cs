//Aula
// using Facade.Aula;
// using Facade.Aula.Subsistemas;

// CreditoFacade concedeCreditoFacade = new CreditoFacade();

// Cliente cliente1 = new Cliente("Vini");

// bool result = concedeCreditoFacade.ConcederEmprestimo(cliente1, 199000.00);

// System.Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente1.Nome} foi " + (result ? "Aprovado" : "Negado"));

// Console.ReadKey();

using Facade.Exercicio;

var comparaPreco = new ComparaPreco();
var livros = comparaPreco.CompararPreco("0000");

livros.ForEach(l => System.Console.WriteLine($"ISBN : {l.Isbn} - {l.Titulo} - {l.Preco:C} - {l.Origem}\n"));