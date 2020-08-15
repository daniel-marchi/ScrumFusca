using System;

namespace ScrumFusca
{
    public class TanqueGasolina
    {
        public void Montar()
        {
            var oldColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("* tanque de gasolina montado");
            Console.BackgroundColor = oldColor;
        }
    }
}
