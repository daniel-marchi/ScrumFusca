namespace ScrumFusca
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var bateria = new Bateria();
            var cilindro = new Cilindro();
 
            var suspensao = new Suspensao();
            var tanque = new TanqueGasolina();
            var virabrequim = new Virabrequim();
<<<<<<< HEAD
            var bateria = new Bateria();
            var cambio = new Cambio();
            
            cambio.Montar();
=======
            var valvulas = new Valvulas();
            var velas = new Velas();

            tanque.Montar();
>>>>>>> 85b2fc361c07a757f90ce2f35b7b1031d4ac835b
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
<<<<<<< HEAD


            
            
            
           

=======
>>>>>>> 85b2fc361c07a757f90ce2f35b7b1031d4ac835b
        }

    }
}
