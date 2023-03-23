using System;

namespace AluguelEstudante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Obejto - Vetor de Quartos
            Estudante[] estudante = new Estudante[10];

            //Entrada de Dados - Quartos à Alugar
            Console.Write("Quantos quartos deseja alugar: ");
            int n = int.Parse(Console.ReadLine());

            //Condição - Infos do Estudante
            for (int i = 1; i <= n; i++)
            {
                //Entrada de Dados - Infos do Estudante
                Console.WriteLine($"\nAluguel #{i}:");
                Console.Write("Nome: ");
                string nomeEstudante = Console.ReadLine();
                Console.Write("Email: ");
                string emailEstudante = Console.ReadLine();
                Console.Write("Quarto: ");
                int quartoEstudante = int.Parse(Console.ReadLine());
                estudante[quartoEstudante] = new Estudante(nomeEstudante, emailEstudante);
            }

            //Saída de Dados - Quarto(s) Ocupado(s)
            Console.WriteLine("\nQuarto(s) ocupado(s): ");

            //Condição - Quarto(s) Ocupado(s)
            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    //Saída de Dados - Quarto(s) Estudante(s)
                    Console.WriteLine(i + ": " + estudante[i]);
                }
            }
        }
    }
}
