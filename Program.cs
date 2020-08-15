using System;

namespace ScrumFusca
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var cambio = new Cambio();
            
            cilindro.Montar();
            cambio.Montar();
        }

    }
}
