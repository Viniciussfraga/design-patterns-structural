namespace Composite.Aula
{
    //composite
    public class Organizacao : HoraTrabalhada
    {
        protected List<HoraTrabalhada> departamentos = new();
        public override void Add(HoraTrabalhada component) => departamentos.Add(component);
        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;
            departamentos.ForEach(d => horasTrabalhadasDepartamento += d.GetHoraTrabalhada());
            Console.WriteLine($"{Nome} registrou um total de {horasTrabalhadasDepartamento} \n");
            return horasTrabalhadasDepartamento;
        }
    }
}