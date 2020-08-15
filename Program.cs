using System;

namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var ie = new InjecaoEletronica("","","");
            ie.Ligar();
            System.Threading.Thread.Sleep(100);
            ie.Desligar();
        }
    }
}
