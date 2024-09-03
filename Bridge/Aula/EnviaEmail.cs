namespace Bridge.Aula
{
    //ConcreteImplementor
    public class EnviaEmail : IDespachaMensagem
    {
        public void EnviaMensagem(string anexo = "")
        {
            string messagem = "Enviando Email";
            if (!string.IsNullOrEmpty(anexo))
                messagem += $"\n Anexo: {anexo}\n";

             System.Console.WriteLine(messagem);
        }
    }
}