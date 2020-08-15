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
            var fiacao = new Fiacao();


            cilindro.Montar();
            suspensao.Montar();
            virabrequim.Instalar();
            cilindro.Montar();
            bateria.Instalar();
            fiacao.Passar();
        }
    }
}
