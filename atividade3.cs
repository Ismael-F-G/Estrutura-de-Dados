
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        public class Node
        {
            public string Musica;
            public Node Proxima;
            public Node Anterior; // Link para o nó anterior (Lista Duplamente Encadeada)
            public Node(string musica)
            {
                Musica = musica;
                Proxima = null;
                Anterior = null;
            }
        }
        public class Playlist
        {
            private Node inicio;
            private Node fim;
            public void AdicionarMusica(string nome)
            {
                Node novoNo = new Node(nome);
                if (inicio == null) // Lista vazia
                {
                    inicio = novoNo;
                    fim = novoNo;
                }
                else
                {
                    fim.Proxima = novoNo; // O antigo fim aponta para o novo
                    novoNo.Anterior = fim; // O novo aponta para o antigo fim
                    fim = novoNo; // Atualiza o fim
                    //inicio.Anterior = novoNo;
                }
                Console.WriteLine($"Música '{nome}' adicionada.");
            }
            public void TocarPlaylist()
            {
                Console.WriteLine("\n--- Tocando Playlist ---");
                Node atual = inicio;
                while (atual != null)
                {
                    Console.WriteLine($"Tocando: 🎵 {atual.Musica}");
                    atual = atual.Proxima;
                    //Console.WriteLine(atual.Anterior);
                }
                Console.WriteLine("Fim da playlist.\n");
            }
        }

        static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist();
            minhaPlaylist.AdicionarMusica("Bohemian Rhapsody");
            minhaPlaylist.AdicionarMusica("Stairway to Heaven");
            minhaPlaylist.AdicionarMusica("Hotel California");
            minhaPlaylist.TocarPlaylist();

        }
    }
}
