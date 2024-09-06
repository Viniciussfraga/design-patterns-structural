//Aula
using Decorator.Pattern.Aulas;

IPizza pizzaMussarela = new Pizza("Mussarela");
System.Console.WriteLine(pizzaMussarela.Opcionais());
System.Console.WriteLine($"Preço R$ {pizzaMussarela.Preco()}");

System.Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
Console.ReadKey();
System.Console.WriteLine("------------- Aplicando o Decorator -------------");

IPizza massaEspecial = new MassaEspecialDecorator(pizzaMussarela);
IPizza baconDecorator = new BaconDecorator(massaEspecial);
IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

System.Console.WriteLine(bordaDecorator.Opcionais());
System.Console.WriteLine($"Preço Total R$ : {bordaDecorator.Preco()}\n");

Console.ReadKey();
