using AllObjects.Services;

namespace AllObjects.Controllers
{
    public class BesouroController
    {
        public void CriarBesoruos()
        {
            List<Besouro> besouroList = new List<Besouro>();
            int qtdBesouros;
            
            Console.WriteLine("Bora adicionar tipos de besouros que você encontrou na lista?");
            Console.WriteLine("Digite o numero de besouros que quer adicionar:");
            qtdBesouros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdBesouros; i++)
            {
                string input, inputSN;
                
                Console.WriteLine($"Insira os dados do {i + 1} besouro:");
                Console.WriteLine("Digita a cor:");
                input = Console.ReadLine();

                while (!RegexUtils.isValidString(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas letras: ");
                    input = Console.ReadLine();
                }
                string cor = input;
                
                Console.WriteLine("Digita o tamanho em cm:");
                input = Console.ReadLine();
                
                while (!RegexUtils.isValidNumber(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas numeros: ");
                    input = Console.ReadLine();
                }
                double tamanho = Convert.ToInt32(input);
                  
                Console.WriteLine("O besouro é voador? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();

                while (!RegexUtils.IsValidChar(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                inputSN.ToUpper();
                bool voador = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);

                Besouro besouro = new Besouro(cor, tamanho, voador);

                besouroList.Add(besouro);

                foreach (Besouro besouros in besouroList)
                {
                    Console.WriteLine(besouros);
                    besouros.voar();
                    besouros.som();
                }
            }
        }
        

    }
}

