namespace AllObjects.Services
{
    public class Carro : Automovel
    {
        protected string nivelCombustivel { get; set; }
        protected bool ligado { get; set; }
        protected bool andando { get; set; }

        public Carro(string marca, string modelo, DateTime fabricacao, string nivelCombustivel, bool ligado, bool andando) : base(marca, modelo, fabricacao)
        {
            this.nivelCombustivel = nivelCombustivel;
            this.ligado = ligado;
            this.andando = andando;
        }

        public void andar()
        {
            if (ligado)
            {
                if (nivelCombustivel == "alto" || nivelCombustivel == "medio" || nivelCombustivel == "baixo")
                {
                    Console.WriteLine("Bibi... O carro começou a andar");
                }
                else
                {
                    Console.WriteLine("O carro está sem combustivel");
                }
            }
            else
            {
                Console.WriteLine("O carro está desligado.");
            }
        }

        public void parar()
        {
            if (ligado)
            {
                if (andando)
                {
                    Console.WriteLine("O carro está parando...");
                }
                else
                {
                    Console.WriteLine("O carro já está parado...");
                }
            }
            else
            {
                Console.WriteLine("O carro está desligado.");
            }
        }
        
        
        public override void buzinar()
        {
            Console.WriteLine("Bibi...");
        }
    }
    
}

