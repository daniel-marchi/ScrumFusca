namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var suspensao = new Suspensao();
            var virabrequim = new Virabrequim();
            var bateria = new Bateria();
            
            cilindro.Montar();
            suspensao.Montar();
            virabrequim.Instalar();
            cilindro.Montar();
            bateria.Instalar();
            Fiacao.Montar():
            
        }
    }
}
