//Aula

using Proxy.Aula;

System.Console.WriteLine("### Exemplo de implementação do padrão Proxy ###\n");

System.Console.WriteLine("\nFuncionário com perfil 'Programador' acessando a pasta compartilhada proxy");
Funcionario func = new Funcionario("Vinicius", "Programador");
PastaCompartilhadaProxy pastaProxy = new PastaCompartilhadaProxy(func);
pastaProxy.OperacaoDeLeituraGravacao();

System.Console.WriteLine("\nFuncionário com perfil 'Usuario' acessando a pasta compartilhada proxy");
func = new Funcionario("Vini", "Usuario");
pastaProxy = new PastaCompartilhadaProxy(func);
pastaProxy.OperacaoDeLeituraGravacao();

System.Console.WriteLine("\nFuncionário com perfil 'CEO' acessando a pasta compartilhada proxy");
func = new Funcionario("Vinão", "Ceo");
pastaProxy = new PastaCompartilhadaProxy(func);
pastaProxy.OperacaoDeLeituraGravacao();