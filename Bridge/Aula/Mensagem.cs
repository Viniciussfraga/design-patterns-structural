namespace Bridge.Aula
{
    //Abstraction
    public abstract class Mensagem
    {
        protected IDespachaMensagem despachaMensagem;
        public Mensagem(IDespachaMensagem desp)
        {
            despachaMensagem = desp;
        }

        public abstract void EnviaMensagem();
    }
}