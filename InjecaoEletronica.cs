using System;
using System.Threading;
using System.Threading.Tasks;

namespace ScrumFusca
{
    public class InjecaoEletronica
    {
        public object Bateria { get; set; }
        public object Vela { get; set; }
        public object Valvula { get; set; }

        public bool ligado { get; set; }

        public InjecaoEletronica(object bateria, object vela, object valvula) {
            Bateria = bateria;
            Vela = vela;
            Valvula = valvula;
        }

        public void Ligar()
        {
            var som = "VRUUUMMMMM ";
            var i = 0;

            Task.Factory.StartNew(() => {
                Console.WriteLine("Ligando Modulo de Injeção Eletrônica");
                this.ligado = true;

                Console.WriteLine("Jogando mistura na Valvula");
                Console.WriteLine("Acionando vela");

                while (this.ligado)
                {
                    Console.Write(som[i]);
                    i = i + 1 >= som.Length ? 0 : i + 1;
                }
            });
        }

        public void Desligar()
        {
            ligado = false;                
            Console.WriteLine("");
            Console.WriteLine("Desligando Modulo de Injeção Eletrônica");
            Console.WriteLine("Entrando em modo de espera...");
            Console.WriteLine("");
        }
    }
}
