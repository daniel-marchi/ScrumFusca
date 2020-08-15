using System;

namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var suspensao = new Suspensao();

            cilindro.Montar();
            suspensao.Montar();
        }
    }
}
