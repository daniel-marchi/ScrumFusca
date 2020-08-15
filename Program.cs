namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var bateria = new Bateria();
            var cilindro = new Cilindro();
            var suspensao = new Suspensao();
            var tanque = new TanqueGasolina();
            var virabrequim = new Virabrequim();

            tanque.Montar();
            cilindro.Montar();
            suspensao.Montar();
            virabrequim.Instalar();
            cilindro.Montar();
            bateria.Instalar();


            var ie = new InjecaoEletronica(null, null, null);
            ie.Ligar();
            System.Threading.Thread.Sleep(100);
            ie.Desligar();

        }
    }
}
