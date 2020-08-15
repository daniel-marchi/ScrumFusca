﻿namespace ScrumFusca
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
 
            var suspensao = new Suspensao();
            var virabrequim = new Virabrequim();
            var bateria = new Bateria();
            var cambio = new Cambio();
            
            cambio.Montar();
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
