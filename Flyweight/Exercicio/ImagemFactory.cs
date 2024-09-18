namespace Flyweight.Exercicio
{
    public class ImagemFactory
    {
         private static Dictionary<string, ImagemBase> imagemMap = new();
         public static ImagemBase GetImagem(string nomeArquivo)
        {
            ImagemBase imagem;

            if(imagemMap.ContainsKey(nomeArquivo))
            {
                imagem = imagemMap[nomeArquivo];
                Console.WriteLine($">>> Retornando imagem do cache : {nomeArquivo} >>>");
            }
            else
            {
                imagem = new Imagem(nomeArquivo);
                imagemMap.Add(nomeArquivo, imagem);
                Console.WriteLine($"### Instanciando uma nova imagem : {nomeArquivo} ###");  
            }
            return imagem;   
        }
    }
}