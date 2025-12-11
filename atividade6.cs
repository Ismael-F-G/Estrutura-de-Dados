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
            ArvoreBinaria arvore = new ArvoreBinaria();
            // Inserindo números desordenados
            int[] numeros = { 45, 10, 7, 90, 12, 50, 13, 39, 57 };

            Console.WriteLine("Inserindo: " + string.Join(", ", numeros));
            foreach (int n in numeros) arvore.Inserir(n);
            Console.Write("Árvore Ordenada (Em-Ordem): ");
            arvore.ImprimirEmOrdem(arvore.Raiz);
            Console.WriteLine();


        }
        public class Node
        {
            public int Valor;
            public Node Esquerda;
            public Node Direita;
            public Node(int valor)
            {
                Valor = valor;
                Esquerda = null;
                Direita = null;
            }
        }

        public class ArvoreBinaria
        {
            public Node Raiz;
            public void Inserir(int valor)
            {
                Raiz = InserirRecursivo(Raiz, valor);
            }
            // Lógica de inserção BST
            private Node InserirRecursivo(Node atual, int valor)
            {
                if (atual == null) return new Node(valor); // Lugar vago encontrado
                if (valor < atual.Valor)
                    atual.Esquerda = InserirRecursivo(atual.Esquerda, valor); // Vai pra esquerda
                else if (valor > atual.Valor)
                    atual.Direita = InserirRecursivo(atual.Direita, valor); // Vai pra direita
                return atual;
            }
            // Varredura Em-Ordem (Esquerda -> Visita -> Direita)
            public void ImprimirEmOrdem(Node atual)
            {
                if (atual != null)
                {
                    ImprimirEmOrdem(atual.Esquerda);
                    Console.Write(atual.Valor + " ");
                    ImprimirEmOrdem(atual.Direita);
                }
            }
        }
    }
}
