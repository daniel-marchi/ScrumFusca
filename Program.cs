using System;

namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var bateria = new Bateria();


            cilindro.Montar();
            bateria.Instalar();
        }
    }
}
