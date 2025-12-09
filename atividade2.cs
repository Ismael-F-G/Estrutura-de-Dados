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
            int[] dadosOriginais = { 72, 54, 59, 30, 31, 78, 2, 77, 82, 72 };

            int BubbleSort(int[] array)
            {
                int trocas = 0;
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    bool trocou = false;
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            // Troca os elementos
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            trocou = true;
                            trocas++;
                        }
                    }
                    // Otimização: se não houve trocas, está ordenado
                    if (!trocou) break;
                }
                return trocas;
            }

            int SelectionSort(int[] array)
            {
                int n = array.Length;
                int trocas = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    // Encontra o índice do menor elemento
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[j] < array[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    // Troca o menor elemento encontrado com a posição atual
                    if (minIndex != i)
                    {
                        int temp = array[i];
                        array[i] = array[minIndex];
                        array[minIndex] = temp;
                        trocas++;
                    }
                }
                return trocas;
            }

            int InsertionSort(int[] array)
            {
                int trocas = 0;
                int n = array.Length;
                for (int i = 1; i < n; i++)
                {
                    int chave = array[i];
                    int j = i - 1;

                    // Move elementos maiores que a chave
                    // uma posição para frente
                    while (j >= 0 && array[j] > chave)
                    {
                        array[j + 1] = array[j];
                        j--;
                        trocas++;
                    }
                    array[j + 1] = chave;
                }
                return trocas;
            }

            Console.WriteLine(BubbleSort(dadosOriginais));
            Console.WriteLine(SelectionSort(dadosOriginais));
            Console.WriteLine(InsertionSort(dadosOriginais));
        }
    }
}
