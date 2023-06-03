using System;
using AllObjects.Services;

namespace AllObjects.Controllers
{
    public class CachorroController
    {
        public void CriarCachorros()
        {
           int qtdCachorros;
             List<Cachorro> cachorroList = new List<Cachorro>();
             
             Console.WriteLine("Vamos criar uma lista de cachorros? Digite o numero de carros para adiconar a lista:");
             qtdCachorros = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < qtdCachorros; i++)
             {
                 string input, inputSN ;
                 
                 Console.WriteLine($"Informe os dados do {i + 1} cachorro:");
                 Console.Write("Nome: ");
                 input = Console.ReadLine();
                 
                 while (!RegexUtils.isValidString(input))
                 {
                     Console.Clear();
                     Console.WriteLine("Digite apenas letras: ");
                     input = Console.ReadLine();
                 }
                 string nome = input;

                 Console.WriteLine("Idade: ");
                 input = Console.ReadLine();
                 
                 while (!RegexUtils.isValidNumber(input))
                 {
                     Console.Clear();
                     Console.WriteLine("Digite apenas numeros: ");
                     input = Console.ReadLine();
                 }
                 int idade = Convert.ToInt32(input);

                 Console.WriteLine("Dono: ");
                 input = Console.ReadLine();
                 
                 while (!RegexUtils.isValidString(input))
                 {
                     Console.Clear();
                     Console.WriteLine("Digite apenas letras: ");
                     input = Console.ReadLine();
                 }
                 string dono = input;

                 Console.WriteLine("Quantidade de brinquedos: ");
                 input = Console.ReadLine();
                 
                 while (!RegexUtils.isValidNumber(input))
                 {
                     Console.Clear();
                     Console.WriteLine("Digite apenas numeros: ");
                     input = Console.ReadLine();
                 }
                 int qtdBrinquedos = Convert.ToInt32(input);

                 Console.WriteLine("O cachorro está dormindo? (Digite 'S' para Sim ou 'N' para Não): ");
                 inputSN = Console.ReadLine();
                 inputSN = inputSN.ToUpper();

                 while (!RegexUtils.IsValidChar(inputSN))
                 {
                     Console.Clear();
                     Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                     inputSN = Console.ReadLine();
                 }
                 bool dormindo = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);

                 Console.WriteLine("O cachorro está com fome? (Digite 'S' para Sim ou 'N' para Não): ");
                 inputSN = Console.ReadLine();
                 inputSN = inputSN.ToUpper();

                 while (!RegexUtils.IsValidChar(inputSN))
                 {
                     Console.WriteLine("Digite apenas [S] sim ou [N] não:");
                     inputSN = Console.ReadLine();
                 }
                 bool fome = inputSN.Equals("S", StringComparison.OrdinalIgnoreCase);

                 Cachorro cachorro = new Cachorro(nome, idade, dono, qtdBrinquedos, dormindo, fome);
                 
                 cachorroList.Add(cachorro);
             }

             foreach (Cachorro cachorro in cachorroList)
             {
                 Console.WriteLine(cachorro);
                 cachorro.dormir();
                 cachorro.brincar();
                 cachorro.comer();
                 cachorro.som();
             }
        }
    }
}