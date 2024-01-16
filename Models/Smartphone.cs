namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imai { get; set; }
        private int Memoria { get; set; }

       

        public Smartphone(string numero, string modelo, string imai, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imai = imai;
            Memoria = memoria;

        }

       

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}