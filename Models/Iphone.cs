namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone( string ddd, string numero, string modelo, string imai, int memoria) : base(ddd, numero, modelo, imai, memoria)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iphone.");
        }
    }
}