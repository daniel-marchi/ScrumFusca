namespace ScrumFusca
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var lataria = new Lataria();
            var aneisPistao = new AneisPistao();
            var bateria = new Bateria();
            var cilindro = new Cilindro();
            var suspensao = new Suspensao();
            var tanque = new TanqueGasolina();
            var virabrequim = new Virabrequim();
            var cambio = new Cambio();
            var valvulas = new Valvulas();
            var velas = new Velas();
            var carter = new Carter();
            var tubos = new TubosDeBorracha();

            lataria.Fabricar();

            aneisPistao.Instalar();
            carter.Instalar();
            cambio.Montar();
            tanque.Montar();
            cilindro.Montar();
            suspensao.Montar();
            virabrequim.Instalar();
            cilindro.Montar();
            bateria.Instalar();
            valvulas.Montar();
            tubos.Instalar();
            velas.Instalar();

            var ie = new InjecaoEletronica(bateria, velas, valvulas);

            ie.Ligar();
            System.Threading.Thread.Sleep(100);
            ie.Desligar();
        }    
    }
}
