using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPU cpu = new CPU();

            // Adicionando fora de ordem
            cpu.AdicionarProcesso("Bloco de Notas", 1, 2000);
            cpu.AdicionarProcesso("Atualização Windows", 10, 1000); // Prioridade Alta
            cpu.AdicionarProcesso("Google Chrome", 5, 7000);
            cpu.AdicionarProcesso("Antivírus", 9, 1500);
            // A CPU deve executar: Atualização -> Antivírus -> Chrome -> Bloco de Notas
            cpu.ExecutarCiclo();

        }
        public class Processo
        {
            public string Nome;
            public int Prioridade; // Maior número = Maior prioridade
            public int tempo_execusao; // em ms
            public Processo(string nome, int prioridade, int tempo_execusao)
            {
                Nome = nome;
                Prioridade = prioridade;
                this.tempo_execusao = tempo_execusao;
            }
        }
        public class CPU
        {
            // Simulando uma Heap usando uma Lista que ordenamos ao inserir
            private List<Processo> filaProcessos = new List<Processo>();
            public void AdicionarProcesso(string nome, int prioridade, int tempo_execusao)
            {
                Processo novo = new Processo(nome, prioridade, tempo_execusao);
                filaProcessos.Add(novo);

                // Simula o comportamento da Heap: Reordena para manter o maior no topo
                // OrderByDescending garante que a Maior Prioridade fique no índice 0
                filaProcessos = filaProcessos.OrderByDescending(p => p.Prioridade).ToList();

                Console.WriteLine($"Agendado: {nome} (Prioridade {prioridade})");
            }
            public void ExecutarCiclo()
            {
                Console.WriteLine("\n--- Processando ---");
                while (filaProcessos.Count > 0)
                {
                    // O elemento 0 sempre é o de maior prioridade (Topo da Heap)
                    Processo atual = filaProcessos[0];

                    Console.WriteLine($"CPU Executando: ⚙️ {atual.Nome} [Prio: {atual.Prioridade}] [Tempo De Execusão: {atual.tempo_execusao}ms]");

                    Thread.Sleep(atual.tempo_execusao);

                    // Remove da fila (Simula o Dequeue da Heap)
                    filaProcessos.RemoveAt(0);
                }
                Console.WriteLine("Todos os processos finalizados.");
            }
        }

    }
}
