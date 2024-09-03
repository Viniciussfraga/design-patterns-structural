namespace Bridge.Aula
{
        //RefinedAbstraction
    public class MensagemNormal : Mensagem
    {
        public MensagemNormal(IDespachaMensagem desp) : base(desp){}
        public override void EnviaMensagem() => despachaMensagem.EnviaMensagem();
    }
}