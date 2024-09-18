namespace Flyweight.Exercicio
{
    public class Imagem : ImagemBase
    {
        //estado intrínseco
        protected string _nomeArquivo;
        public Imagem(string nomeArquivo)
        {
            _nomeArquivo = nomeArquivo;
        }
        
        //estado extrínseco
        public override void Exibir(double x, double y, double largura, double altura)
        {
            Console.WriteLine($"<img src = {_nomeArquivo} style=left:{x}px; top:{y}px; width:{largura}px height:{altura}px;");
        }
    }
}