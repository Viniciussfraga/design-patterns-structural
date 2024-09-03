namespace Bridge.Exercicio
{
    //abstraction
    public abstract class Arquivo
    {
        protected IGeraArquivo geraArquivo{ get; set; }
        public Arquivo(IGeraArquivo tipo)
        {
            geraArquivo = tipo;
        }

        public virtual void GravaArquivo(Funcionario func)
        {
            geraArquivo.GeraArquivo(func);
        }
    }
}