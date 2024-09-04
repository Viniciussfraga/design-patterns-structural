// Aula

// using Composite.Aula;

// Organizacao org = new Organizacao { Nome = "Vinicius Fraga .NET"};

// Organizacao depTI = new Organizacao { Nome = "Vinicius TI"};
// depTI.Add(new Funcionario{ Nome = "Vinicius", Horas = 8 });
// depTI.Add(new Funcionario{ Nome = "Santos", Horas = 9 });
// depTI.Add(new Funcionario{ Nome = "Fraga", Horas = 10 });

// Organizacao depRH = new Organizacao { Nome = "Vinicius RH"};
// depRH.Add(new Funcionario{ Nome = "Ayla", Horas = 9 });
// depRH.Add(new Funcionario{ Nome = "Bethania", Horas = 10 });

// org.Add(depTI);
// org.Add(depRH);

// org.GetHoraTrabalhada();

//exercicio

using Composite.Exercicio;

var grupoA = new Grupo("A) Português");
var questao1 = new Questao("Quando usamos a crase?");
var questao2 = new Questao("Qual o sinonimo de rápido?");

grupoA.Add(questao1);
grupoA.Add(questao2);

var grupoB = new Grupo("B) Física");
var grupoB1 = new Grupo("B1) Mecânica");
var questao3 = new Questao("O que é velocidade média?");
var questao4 = new Questao("O que é velocidade aceleração?");

grupoB1.Add(questao3);
grupoB1.Add(questao4);

var grupoB2 = new Grupo("B1) Óptica");
var questao5 = new Questao("O que é refração?");
var questao6 = new Questao("Qual velocidade da luz?");

grupoB2.Add(questao5);
grupoB2.Add(questao6);

grupoB.Add(grupoB1);
grupoB.Add(grupoB2);

var grupoC = new Grupo("C) Matemática");
var questao7 = new Questao("Qual a raiz quadrada de 126?");
var questao8 = new Questao("Qual o valor do número Pi?");

grupoC.Add(questao7);
grupoC.Add(questao8);

var grupoRaiz = new Grupo("Questionario");
grupoRaiz.Add(grupoA);
grupoRaiz.Add(grupoB);
grupoRaiz.Add(grupoC);

grupoRaiz.Exibir();

Console.ReadKey();