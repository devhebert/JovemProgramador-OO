namespace AllObjects.Services
{
    public abstract class Animais
    {
        protected string nome { get; set; }
        protected int idade { get; set; }
        
        public Animais(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        protected void comer()
        {
            Console.WriteLine("Comendo...");
        }

        protected void dormir()
        {
            Console.WriteLine("Dormindo...");
        }

        public abstract void som();
    }
}