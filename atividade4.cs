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

            Stack<string> historicoAcoes = new Stack<string>(); // Pilha para Desfazer
            Queue<string> filaImpressao = new Queue<string>(); // Fila para Impressora
            while (true)
            {
                Console.WriteLine("\n1. Escrever Texto (Add Ação)");
                Console.WriteLine("2. Desfazer (Undo)");
                Console.WriteLine("3. Enviar para Impressão");
                Console.WriteLine("4. Imprimir Próximo (Impressora)");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a ação feita: ");
                        string acao = Console.ReadLine();
                        historicoAcoes.Push(acao); // Push no topo
                        Console.WriteLine("Ação registrada.");
                        break;
                    case "2":
                        if (historicoAcoes.Count > 0)
                        {
                            string desfeita = historicoAcoes.Pop(); // Pop remove do topo
                            Console.WriteLine($"Desfeito: {desfeita}");
                        }
                        else Console.WriteLine("Nada para desfazer.");
                        break;
                    case "3":
                        Console.Write("Nome do documento: ");
                        string doc = Console.ReadLine();
                        filaImpressao.Enqueue(doc); // Enqueue no fim
                        Console.WriteLine("Documento na fila.");
                        break;
                    case "4":
                        if (filaImpressao.Count > 0)
                        {
                            string imp = filaImpressao.Dequeue(); // Dequeue remove do início
                            Console.WriteLine($"Imprimindo: 📄 {imp}");
                        }
                        else Console.WriteLine("Fila vazia.");
                        break;

                    default:
                        Console.WriteLine("\nOpção invalida, tente novamente.");
                        break;
                }
            }
        }
    }
}
