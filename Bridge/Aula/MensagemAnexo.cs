namespace Bridge.Aula
{
    //RefinedAbstraction
    public class MensagemAnexo : Mensagem
    {
        private string Anexo { get; set; }
        public MensagemAnexo(string anexo, IDespachaMensagem desp) : base(desp){ Anexo = anexo; }
        public override void EnviaMensagem() => despachaMensagem.EnviaMensagem(Anexo);
    }
}