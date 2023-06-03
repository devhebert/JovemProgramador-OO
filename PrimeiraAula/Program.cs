using System;
using AllObjects.Views;

namespace AllObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ProgramAnimalsView programAnimalsView = new ProgramAnimalsView();
            ProgramaInsetoView programaInsetoView = new ProgramaInsetoView();
            ProgramCasaView programCasaView = new ProgramCasaView();

            bool sair = false;
            Console.WriteLine("Qual programa quer executar?");
            while (!sair)
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1 - Animal");
                Console.WriteLine("2 - Automovel");
                Console.WriteLine("3 - Inseto");
                Console.WriteLine("4 - Planta");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("----------------\n");
                Console.Write("Selecione uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        programAnimalsView.Run();
                        break;
                    case "2":
                        Console.Write("Em construção...");
                        break;
                    case "3":
                        programaInsetoView.Run();
                        break;
                    case "4":
                        programCasaView.Run();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

        }
    }
}