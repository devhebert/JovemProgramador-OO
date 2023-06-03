namespace AllObjects.Services
{
    public class Cachorro : Animais
    {
        protected static int qtdDeCachorros { get; set; }
        protected string dono { get; set; }
        protected int qtdBrinquedos { get; set; }
        protected bool dormindo { get; set; }
        protected bool fome { get; set; }
        public Cachorro(string nome, int idade, string dono, int qtdBrinquedos, bool dormindo, bool fome)
            : base(nome, idade)
        {
            this.dono = dono;
            this.qtdBrinquedos = qtdBrinquedos;
            this.dormindo = dormindo;
            this.fome = fome;

            qtdDeCachorros++;
        }
        
        public void dormir()
        {
            if (!dormindo)
            {
                Console.WriteLine("Doguinho feliz, brincando");
            }
            else
            {
                Console.WriteLine("O cachorro está dormindo. Não pode brincar agora.");
            }
        }
        
        public void brincar()
        {
            if (!dormindo)
            {
                Console.WriteLine("Doguinho feliz, brincando");
            }
            else
            {
                Console.WriteLine("O cachorro está dormindo. Não pode brincar agora.");
            }
        }
        
        public void comer()
        {
            if (!dormindo)
            {
                if (fome)
                {
                    Console.WriteLine("Comendo...");
                    fome = false;
                }
                else
                {
                    Console.WriteLine("O cachorro não está com fome. Não precisa comer agora.");
                }
            }
            else
            {
                Console.WriteLine("O cachorro está dormindo. Não pode comer agora.");
            }
        }
        
        public override void som()
        {
            if (!dormindo)
            {
                Console.WriteLine("AUAUAU, DOG MAU");
            }
            else
            {
                Console.WriteLine("O cachorro está dormindo. Não pode fazer som agora.");
            }
        }
        
        public override string ToString()
        {
            return $"Cachorro: {nome}, Idade: {idade}, Dono: {dono}, Quantidade de Brinquedos: {qtdBrinquedos}, Dormindo: {dormindo}, Fome: {fome}";
        }
        
    }
}