using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Eqüilátero: Todos os lados iguais OK
             • Isósceles: Dois lados iguais
             • Escaleno: Todos os lados diferentes

             * 
             * a medida de qualquer um dos lados seja menor que a soma dos outros dois lados. OK
             * 
             * Caso algum comprimento dos lados do triângulo for inválido, escrever a mensagem “Triângulo Inválido” OK
             * 
             * O usuário poderá verificar vários triângulos, ou seja, crie um menu de opções que possibilite isso.
             * 
             */

            int x, y, z;
            char op = ' ';

            Console.Write("Tecle uma das opções:\n\n1 - Verificar Triângulo:\n2 - Encerrar:\n\n> ");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (op != '2')
            {
                if (op == '1')
                {
                    Console.Write("Entre com valor de X: ");
                    x = int.Parse(Console.ReadLine());

                    Console.Write("Entre com valor de Y: ");
                    y = int.Parse(Console.ReadLine());

                    Console.Write("Entre com valor de Z: ");
                    z = int.Parse(Console.ReadLine());

                    if ((x + y) > z && (x + z) > y && (y + z) > x)
                    {
                        Console.WriteLine("\nOk, triângulo válido...\n");
                        if (x == z && x == y && y == z)
                        {
                            Console.WriteLine("TRIÂNGULO EQUILÁTERO\n\n(tecle)");
                        }

                        else if (x != z && x != y && y != z)
                        {
                            Console.WriteLine("TRIÂNGULO ESCALENO\n\n(tecle)");
                        }
                        else // if (x == y && x < z || x == z && x < y || y == z && y < x)
                        {
                            Console.WriteLine("TRIÂNGULO ISÓSCELES\n\n(tecle)");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nTriângulo inválido!\n");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Tecle uma das opções:\n\n1 - Verificar Triângulo:\n2 - Encerrar:\n\n> ");
                    op = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                if (op != '1' && op != '2')
                {
                    Console.WriteLine("Opção inválida!\n\n\n(tecle)");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Tecle uma das opções:\n\n1 - Verificar Triângulo:\n2 - Encerrar:\n\n> ");
                    op = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            }
        }
    }
}
