namespace AllObjects.Services
{
    public class Besouro : Inseto
    {
        protected bool voador { get; set; }
        
        public Besouro(string cor, double tamanho, bool voador) : base(cor, tamanho)
        {
            this.voador = voador;
        }

        public void voar()
        {
            if (!voador)
            {
                Console.WriteLine("Besourinho perdeu as asas");
                return;
            }
            
            Console.WriteLine("Avua besourinho!"); 

        }

        public override void som()
        {
            Console.WriteLine("Bzzzz");
        }

        public override string ToString()
        {
            return $"Cor: {cor}, Tamanho: {tamanho}, Voador: {voador}";
        }
    }
}
