namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMAI;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imai, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMAI = imai;
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