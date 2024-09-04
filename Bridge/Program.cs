//client

//Aula
using Bridge.Aula;

Mensagem mensagem = new MensagemAnexo("Anexo Email", new EnviaEmail());
mensagem.EnviaMensagem();
mensagem = new MensagemAnexo("Anexo SMS", new EnviaSMS());
mensagem.EnviaMensagem();
mensagem = new MensagemNormal(new EnviaEmail());
mensagem.EnviaMensagem();
mensagem = new MensagemNormal(new EnviaSMS());
mensagem.EnviaMensagem();



//Exercicio
// using Bridge.Exercicio;

// Funcionario funcionario = new ()
// {
//     Id = 101,
//     Nome = "Manoel",
//     SalarioBase = 3000,
//     Incentivo = 900
// };

// CalculaSalario calculaSalarioJson = new CalculaSalario(new GeraJson());
// calculaSalarioJson.ProcessaSalarioFuncionario(funcionario);

// funcionario = new ()
// {
//     Id = 102,
//     Nome = "João",
//     SalarioBase = 5000,
//     Incentivo = 900
// };

// CalculaSalario calculaSalarioXML = new CalculaSalario(new GeraXML());
// calculaSalarioXML.ProcessaSalarioFuncionario(funcionario);
