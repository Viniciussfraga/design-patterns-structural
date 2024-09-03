namespace Bridge.Aula
{
    //ConcreteImplementor
    public class EnviaSMS : IDespachaMensagem
    {
        public void EnviaMensagem(string anexo = "")
        {
            string messagem = "Enviando SMS";
            if (!string.IsNullOrEmpty(anexo))
                messagem += $"\n Anexo: {anexo}\n";

             System.Console.WriteLine(messagem);
        }
    }
}