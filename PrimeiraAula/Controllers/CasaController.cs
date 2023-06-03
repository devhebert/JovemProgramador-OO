using AllObjects.Services;

namespace AllObjects.Controllers
{
    public class CasaController
    {
        public void CriarCasa()
        {
            int qtdCasa;
            List<Casa> casaList = new List<Casa>();
            
            Console.WriteLine("Vamos criar uma lista de casas? Digite o numero de casas para adiconar a lista:");
            qtdCasa = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdCasa; i++)
            {
                string input, inputSN ;
                
                Console.WriteLine($"Informe os dados da {i + 1} casa:");
                Console.WriteLine("Para construir a casa, foi solicitado a planta para um engenheiro? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool engenheiro = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Tem alvará para construir? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool alvara = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Tem pedreiro para contruir? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool pedreiro = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Tem ajudante para contruir? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool ajudante = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Tem area externa? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool areaExterna = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Tem pintor? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool pintor = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Tem moveis planejados? (Digite 'S' para Sim ou 'N' para Não): ");
                inputSN = Console.ReadLine();
                inputSN = inputSN.ToUpper();

                while (!RegexUtils.IsValidChar(inputSN))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                    inputSN = Console.ReadLine();
                }
                bool moveisPlanejados = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);
                
                Console.WriteLine("Qual a quantidade de quartos?: ");
                input = Console.ReadLine();
                 
                while (!RegexUtils.isValidNumber(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas numeros: ");
                    input = Console.ReadLine();
                }
                int quarto = Convert.ToInt32(input);
                
                Console.WriteLine("Qual a quantidade de salas?: ");
                input = Console.ReadLine();
                 
                while (!RegexUtils.isValidNumber(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas numeros: ");
                    input = Console.ReadLine();
                }
                int sala = Convert.ToInt32(input);
                
                Console.WriteLine("Qual a quantidade de cozinhas?: ");
                input = Console.ReadLine();
                 
                while (!RegexUtils.isValidNumber(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas numeros: ");
                    input = Console.ReadLine();
                }
                int cozinha = Convert.ToInt32(input);
                
                Console.WriteLine("Qual a quantidade de banheiros?: ");
                input = Console.ReadLine();
                 
                while (!RegexUtils.isValidNumber(input))
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas numeros: ");
                    input = Console.ReadLine();
                }
                int banheiro = Convert.ToInt32(input);

                Casa casa = new Casa(engenheiro, alvara, pedreiro, ajudante, areaExterna, pintor, moveisPlanejados, quarto, sala, cozinha, banheiro);
                casaList.Add(casa);

                foreach (var casas in casaList)
                {
                    Console.WriteLine(casas);
                    casas.construir();
                    casas.pintar();
                    casas.colocarMoveisPlanejados();
                }

            }

        }
    }
}

