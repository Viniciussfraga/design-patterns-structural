using Flyweight.Aula.Ex;

namespace Flyweight.Aula
{
    //Flyweight concreter
    public class Soldado : IPersonagem
    {
        //estado extrínseco (não compartilhavel)
        //muda para cada objeto
        public int Poder { get; set; }
        //estado intrínseco (cache - compartilhável)
        //é o mesmo para cada objeto
        public string Defesa = "Colete e Capacete";
        public string Atuacao = "Luta Corporal";
        public string Arma = "Fuzil e Pistola";

        public Soldado()
        {
        }

        public Soldado(int poder)
        {
            _ = poder >= 10 && poder <= 50 ? Poder = poder : 
                throw new ArgumentException("Valor está fora do poder de um soldado");
        }
        public void Render()
        {
            Console.WriteLine($"Soldado : {Poder} - Arma: {Arma} - Defesa: {Defesa} - Atuação: {Atuacao}");
        }
    }
}