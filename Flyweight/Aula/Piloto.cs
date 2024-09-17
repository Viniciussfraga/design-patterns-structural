using Flyweight.Aula.Ex;

namespace Flyweight.Aula
{
    //Flyweight concreter
    public class Piloto : IPersonagem
    {
        //estado extrínseco (não compartilhavel)
        //muda para cada objeto
        public int Poder { get; set; }
        //estado intrínseco (cache - compartilhável)
        //é o mesmo para cada objeto
        public string Defesa = "Velocidade e Altitude";
        public string Atuacao = "Combate Aéreo";
        public string Arma = "AMX A1 : Bombas/Metralhadora";

        public Piloto()
        {
        }

        public Piloto(int poder)
        {
            _ = poder >= 20 && poder <= 100 ? Poder = poder : 
                throw new ArgumentException("Valor está fora do poder de um piloto");
        }
        public void Render()
        {
            Console.WriteLine($"Piloto : {Poder} - Arma: {Arma} - Defesa: {Defesa} - Atuação: {Atuacao}");
        }
    }
}