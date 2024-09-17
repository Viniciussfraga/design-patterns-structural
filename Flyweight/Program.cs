using Flyweight.Aula;

for (int i=0;i<5;i++)
{
    var personagem = (Soldado)PersonagemFactory.GetPersonagem("Soldado");
    //prop extrinseca
    personagem.Poder = getRandomPoderSoldado();
    personagem.Render();
}

System.Console.WriteLine("\n --------------------------------------------");

for (int i=0;i<5;i++)
{
    var personagem = (Piloto)PersonagemFactory.GetPersonagem("Piloto");
    //prop extrinseca
    personagem.Poder = getRandomPoderPiloto();
    personagem.Render();
}

int getRandomPoderSoldado()
{
    Random rnd = new();
    return rnd.Next(10, 50);
}
int getRandomPoderPiloto()
{
    Random rnd = new();
    return rnd.Next(20, 100);
}