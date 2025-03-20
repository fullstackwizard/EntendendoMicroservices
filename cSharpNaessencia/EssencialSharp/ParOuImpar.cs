using System;

namespace ParOuImpar
{
    internal class ParOuImpar 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para verificar se é Par ou Ímpar:");

            double numero = ObterNumero("Digite o Número: ");

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é Par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é Ímpar.");
            }
        }

        static double ObterNumero(string mensagem)
        {
            Console.Write(mensagem);

            return double.TryParse(Console.ReadLine(), out double resultado) ? resultado : 0;
        }
        
}

/* Metodo Direto 

{
            Console.Write("Digite um número: ");
            double.TryParse(Console.ReadLine(), out double numero);

            Console.WriteLine($"O número {numero} é {(numero % 2 == 0 ? "Par" : "Ímpar")}.");
        }

*/