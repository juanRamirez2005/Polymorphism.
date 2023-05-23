namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.HacerRuido();

            Perro perro = new Perro();
            perro.HacerRuido();


        }
    }
}