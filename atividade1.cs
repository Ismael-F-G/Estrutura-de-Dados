using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] notasAlunos = new int[3][];

            notasAlunos[0] = new int[] { 70, 85, 90 };
            notasAlunos[1] = new int[] { 60, 45 };
            notasAlunos[2] = new int[] { 80, 95, 100, 88 };
            notasAlunos[2].SetValue(83, 1);
            Console.WriteLine(notasAlunos[1].GetValue(1));

            // Exibindo a estrutura 
            Console.WriteLine("--- Estrutura de Notas ---"); for (int i = 0; i < notasAlunos.Length; i++)
            {
                Console.Write($"Aluno {i}: "); for (int j = 0; j < notasAlunos[i].Length; j++)
                {
                    Console.Write(notasAlunos[i][j] + " ");
                }
                Console.WriteLine();
            }


            bool BuscaSequencial(int[][] matriz, int valorProcurado)
            {
                // Percorre cada linha (aluno)
                for (int i = 0; i < matriz.Length; i++)
                {
                    // Percorre cada coluna (notas do aluno)
                    for (int j = 0; j < matriz[i].Length; j++)
                    {
                        // Se encontrar correspondência, retorna verdadeiro [cite: 37]
                        if (matriz[i][j] == valorProcurado)
                        {
                            Console.WriteLine($"[DEBUG] Encontrado no Aluno {i}, Prova {j + 1}"); return true;
                        }
                    }
                }
                // Se percorreu tudo e não achou
                return false;
            }

            while (true)
            {
                {  // 3. Testando a Busca Sequencial 
                    Console.WriteLine("\nDigite uma nota para buscar:"); int notaBusca = int.Parse(Console.ReadLine());

                    bool encontrada = BuscaSequencial(notasAlunos, notaBusca);

                    if (encontrada)
                        Console.WriteLine($"A nota {notaBusca} foi encontrada no sistema.");
                    else
                        Console.WriteLine($"A nota {notaBusca} NÃO consta nos registros.");
                }
               }
            }



    }
}
