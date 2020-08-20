﻿using ScrumFusca.Funilaria;

namespace ScrumFusca
{

    partial class Program
    {
        static void Main(string[] args)
        { 
            var lataria = new Lataria();
            var chassi = new Chassi();
            var portas = new Portas();
            var latariachassi = new LatariaChassi();
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

            //Funilaria
            lataria.Fabricar();
            chassi.Fabricar();
            portas.Instalar();
            latariachassi.Montar();


            //Motor
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
            System.Threading.Thread.Sleep(1);
            ie.Desligar();

        }
    }
}
