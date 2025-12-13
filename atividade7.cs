using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            TabelaHash dicionario = new TabelaHash();

            // Palavras com mesmo tamanho cairão no mesmo índice (Colisão)
            dicionario.Adicionar("Gato", "Cat"); // Length 3 -> Indice 3
            dicionario.Adicionar("Cachorro", "Dog"); // Length 3 -> Indice 3 (Colisão!)
            dicionario.Adicionar("Passaro", "Bird"); // Length 4 -> Indice 4
            dicionario.Adicionar("?", "Ox"); // Length 2 -> Indice 2
            dicionario.ExibirTabela();
        }
        class TabelaHash
        {
            // Array de Listas (Encadeamento Separado)
            private List<KeyValuePair<string, string>>[] tabela = new List<KeyValuePair<string, string>>[5];

            public TabelaHash()
            {
                // Inicializa as listas em cada posição
                for (int i = 0; i < tabela.Length; i++)
                    tabela[i] = new List<KeyValuePair<string, string>>();
            }
            // Função Hash simples (gera colisões propositais para teste)
            private int FuncaoHash(string chave)
            {
                return chave.Length % 5; // Retorna posição 0 a 4
            }
            public void Adicionar(string key, string palavra)
            {
                int indice = FuncaoHash(palavra);
                tabela[indice].Add(new KeyValuePair<string, string>(key, palavra));
                Console.WriteLine($"Palavra '{palavra}' armazenada no índice {indice}.");
            }

            public void ExibirTabela()
            {
                Console.WriteLine("\n--- Estado da Tabela Hash ---");
                for (int i = 0; i < tabela.Length; i++)
                {
                    Console.Write($"Índice {i}: ");
                    foreach (var item in tabela[i])
                    {
                        Console.Write($"[{item}] -> ");
                    }
                    Console.WriteLine("null");
                }
            }
        }
    }
}
