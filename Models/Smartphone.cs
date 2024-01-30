namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Ddd { get; set; }
        private string Modelo { get; set; }
        private string Imai { get; set; }
        private int Memoria { get; set; }



        public Smartphone(string ddd, string numero, string modelo, string imai, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imai = imai;
            Memoria = memoria;
            Ddd = ddd;



        }


        public void AdiconarOddd()
        {
            Console.WriteLine("Digite o DDD");
            string Codigo = Console.ReadLine();

            string NumeroDoCelularComOddd = $"({Codigo}){Numero} ";
            Numero = NumeroDoCelularComOddd;

            

        }


        public void EscolherOpcoes()
        {
            Console.WriteLine("[1]:Ligar | [2]:Desligar");
            int Opcoes = Convert.ToInt32(Console.ReadLine());


            switch (Opcoes)
            {
                case 1:
                    Console.WriteLine("Fazendo Chamada");
                  
                    break;
                case 2:
                    Console.WriteLine("Ligação encerrada");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

        

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}