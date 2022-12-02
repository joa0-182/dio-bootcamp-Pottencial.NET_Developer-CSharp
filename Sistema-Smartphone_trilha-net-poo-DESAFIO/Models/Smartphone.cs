namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        public Smartphone()
        {

        }

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Memoria { get; set;}


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void SmartphoneConfig(string nomeDispositivo)
        {
            Console.WriteLine($"Configurações do Dispositivo: {nomeDispositivo}");
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}