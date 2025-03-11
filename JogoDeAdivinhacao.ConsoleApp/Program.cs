using System.Runtime.CompilerServices;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("----------------------------------------");

                Console.Write("Digite um número: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nVocê digitou: {numeroDigitado}");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
