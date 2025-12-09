using System;
class Program
{
    static void Main()
    {
        // Vetor base desordenado (Cópia para cada método para garantir igualdade no teste)
        int[] dadosOriginais = { 72, 54, 59, 30, 31, 78, 2, 77, 82, 72 };
        Console.WriteLine("Vetor Original: " + string.Join(", ", dadosOriginais));
        Console.WriteLine("--------------------------------------------------");
        // Teste Bubble Sort
        int[] vetorBubble = (int[])dadosOriginais.Clone();
        BubbleSort(vetorBubble);
        Console.WriteLine("Bubble Sort Resultado: " + string.Join(", ", vetorBubble));
        // Teste Selection Sort
        int[] vetorSelection = (int[])dadosOriginais.Clone();
        SelectionSort(vetorSelection);
        Console.WriteLine("Selection Sort Resultado: " + string.Join(", ", vetorSelection));
        // Teste Insertion Sort
        int[] vetorInsertion = (int[])dadosOriginais.Clone();
        InsertionSort(vetorInsertion);
        Console.WriteLine("Insertion Sort Resultado: " + string.Join(", ", vetorInsertion));
    }
    //[cite_start]// 1. Bubble Sort [cite: 48]
                // O mais lento, mas simples. Valores altos "flutuam" para a direita.
    static void BubbleSort(int[] arr)
    {
        int trocas = 0;
        int temp;
        // Loop externo: define o limite superior que vai diminuindo
        for (int outer = arr.Length - 1; outer >= 1; outer--)
        {
            // Loop interno: compara pares adjacentes
            for (int inner = 0; inner <= outer - 1; inner++)
            {
                if (arr[inner] > arr[inner + 1])
                {
                    // Troca (Swap)
                    temp = arr[inner];
                    arr[inner] = arr[inner + 1];
                    arr[inner + 1] = temp;
                    trocas ++;
                }
            }
        }
        Console.WriteLine(trocas);
    }
    //[cite_start]// 2. Selection Sort [cite: 54]
                // Procura o menor elemento e coloca na posição correta.
    static void SelectionSort(int[] arr)
    {
        int trocas = 0;
        int min, temp;
        for (int outer = 0; outer < arr.Length; outer++)
        {
            min = outer; // Assume que o atual é o menor

            // Procura o verdadeiro menor no restante do vetor
            for (int inner = outer + 1; inner < arr.Length; inner++)
            {
                if (arr[inner] < arr[min])
                {
                    min = inner;
                }
            }

            // Troca o atual pelo menor encontrado
            temp = arr[outer];
            arr[outer] = arr[min];
            arr[min] = temp;
            trocas ++;
        }
        Console.WriteLine(trocas);
    }
    //[cite_start]// 3. Insertion Sort [cite: 57]
                // Pega o elemento e insere na parte já ordenada à esquerda.
    static void InsertionSort(int[] arr)
    {
        int trocas = 0;
        int inner, temp;
        for (int outer = 1; outer < arr.Length; outer++)
        {
            temp = arr[outer]; // O valor a ser inserido
            inner = outer;
            // Desloca elementos maiores para a direita para abrir espaço
            while (inner > 0 && arr[inner - 1] >= temp)
            {
                arr[inner] = arr[inner - 1];
                inner -= 1;
            }
            arr[inner] = temp; // Insere o valor na posição correta
            trocas++;
        }
        Console.WriteLine(trocas);
    }
}
