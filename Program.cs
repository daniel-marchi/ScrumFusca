namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var suspensao = new Suspensao();
            var virabrequim = new Virabrequim();
            var valvulas = new Valvulas();
            var bateria = new Bateria();
            var velas = new Velas();
            
            cilindro.Montar();
            suspensao.Montar();
            virabrequim.Instalar();
            cilindro.Montar();
            bateria.Instalar();
            valvulas.Montar();
            velas.Instalar();

            var ie = new InjecaoEletronica(bateria, velas, valvulas);
            ie.Ligar();
            System.Threading.Thread.Sleep(100);
            ie.Desligar();
        }
    }
}
