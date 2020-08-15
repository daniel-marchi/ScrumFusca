namespace ScrumFusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro();
            var virabrequim = new Virabrequim();

            cilindro.Montar();
            virabrequim.Instalar();
        }
    }
}
