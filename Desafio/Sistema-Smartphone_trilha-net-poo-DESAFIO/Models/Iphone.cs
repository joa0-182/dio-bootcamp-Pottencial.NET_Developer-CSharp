namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone()
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("In connection...");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Installing the app {nomeApp}");
        }
    }
}