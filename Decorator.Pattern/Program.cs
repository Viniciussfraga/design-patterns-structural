//Aula
// using Decorator.Pattern.Aulas;

// IPizza pizzaMussarela = new Pizza("Mussarela");
// System.Console.WriteLine(pizzaMussarela.Opcionais());
// System.Console.WriteLine($"Preço R$ {pizzaMussarela.Preco()}");

// System.Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
// Console.ReadKey();
// System.Console.WriteLine("------------- Aplicando o Decorator -------------");

// IPizza massaEspecial = new MassaEspecialDecorator(pizzaMussarela);
// IPizza baconDecorator = new BaconDecorator(massaEspecial);
// IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

// System.Console.WriteLine(bordaDecorator.Opcionais());
// System.Console.WriteLine($"Preço Total R$ : {bordaDecorator.Preco()}\n");

// Console.ReadKey();

//Exercicio
using Decorator.Pattern.Exercicio;

ICafe filtrado = new Filtrado();
System.Console.WriteLine(filtrado.Descricao());
System.Console.WriteLine($"Preço R$ {filtrado.Preco()}");

ICafe espresso = new Espresso();
System.Console.WriteLine(espresso.Descricao());
System.Console.WriteLine($"Preço R$ {espresso.Preco()}");

System.Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
Console.ReadKey();
System.Console.WriteLine("------------- Aplicando o Decorator -------------");

ICafe leiteDecorator = new LeiteDecorator(filtrado);
ICafe chocolateDecorator = new ChocolateDecorator(leiteDecorator);

System.Console.WriteLine(chocolateDecorator.Descricao());
System.Console.WriteLine($"Preço Total R$ : {chocolateDecorator.Preco()}\n");

leiteDecorator = new LeiteDecorator(espresso);
chocolateDecorator = new ChocolateDecorator(leiteDecorator);

System.Console.WriteLine(chocolateDecorator.Descricao());
System.Console.WriteLine($"Preço Total R$ : {chocolateDecorator.Preco()}\n");

Console.ReadKey();