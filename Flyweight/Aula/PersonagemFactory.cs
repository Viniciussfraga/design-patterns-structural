using Flyweight.Aula.Ex;

namespace Flyweight.Aula
{
    public class PersonagemFactory
    {
        private static Dictionary<string, IPersonagem> personagemMap = new();
        public static IPersonagem GetPersonagem(string tipo)
        {
            IPersonagem personagem;

            if(personagemMap.ContainsKey(tipo))
            {
                Console.WriteLine($">>> Retornando personagem do cache : {tipo} >>>");
                return personagemMap[tipo];
            }
            else
            {
                Console.WriteLine($"### Instanciando um novo personagem : {tipo} ###");
                switch(tipo)
                {
                    case "Soldado":
                        personagem = new Soldado();
                        personagemMap.Add("Soldado", personagem);
                        break;
                    case "Piloto":
                        personagem = new Piloto();
                        personagemMap.Add("Piloto", personagem);
                        break;
                    default:
                    throw new ArgumentException("Este tipo de personagem não pode ser criado");
                }      
                return personagem;          
            }
        }
    }
}