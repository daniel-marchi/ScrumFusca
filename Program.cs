namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var suspensao = new Suspensao();
            var virabrequim = new Virabrequim();
            
            cilindro.Montar();
            suspensao.Montar();
            virabrequim.Instalar();
        }
    }
}
