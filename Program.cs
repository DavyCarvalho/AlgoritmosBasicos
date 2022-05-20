using System;

namespace Algoritmos_Básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = {64,25,12,22,11};
            Console.WriteLine(OrdenacaoPorSelecao(arr));
        }

        public static int BuscaSequencial(int[] vetor, int numeroProcurado) {
            var indice = 0;
            foreach (var numeroDaLista in vetor)
            {
                if (numeroDaLista == numeroProcurado)
                    return indice;
                indice += 1;
            }
            return -1;
        }

        public static int BuscaBinaria(int[] vetor, int numeroProcurado) {
            var posicao_inicial = 0;
            var posicao_final = vetor.Length - 1;

            while (posicao_inicial <= posicao_final) {
                var posicao_meio = (posicao_inicial + posicao_final) / 2;

                if (vetor[posicao_meio] == numeroProcurado)
                    return posicao_meio;
                if (vetor[posicao_meio] > numeroProcurado)
                    posicao_final = posicao_meio - 1;
                if (vetor[posicao_meio] < numeroProcurado)
                    posicao_inicial = posicao_meio + 1;
            }

            return -1;
        }

        public static int[] OrdenacaoPorInsercao(int[] vetor) {
            
            for (int i = 1; i < vetor.Length; i++)
            {
                var valorPosicaoAtual = vetor[i];
                var posicaoAnteriorAAtual = i - 1;

                while (posicaoAnteriorAAtual >= 0 && vetor[posicaoAnteriorAAtual] > valorPosicaoAtual) {
                    vetor[posicaoAnteriorAAtual + 1] = vetor[posicaoAnteriorAAtual];
                    posicaoAnteriorAAtual -= 1;
                }
                vetor[posicaoAnteriorAAtual + 1] = valorPosicaoAtual;
            }

            return vetor;
        }

        public static int[] OrdenacaoPorSelecao(int[] vetor) {

            for (int i = 0; i < vetor.Length; i++) 
            {
                int menor_indice = i;
                for (int j = i + 1; j < vetor.Length; j++) {
                    if (vetor[j] < vetor[menor_indice])
                        menor_indice = j;
                }

                var temp = vetor[menor_indice];
                vetor[menor_indice] = vetor[i];
                vetor[i] = temp ;
            }

            return vetor;
        }

        public static int[] QuickSort(int[] vetor, int leftIndex, int rightIndex) {
            var i = leftIndex;
            var j = rightIndex;
            var pivo = vetor[leftIndex];

            while (i <= j) 
            {
                while (vetor[i] < pivo) 
                {
                    i++;
                }

                while (vetor[j] > pivo) 
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j) 
            {
                QuickSort(vetor, leftIndex, j);
            }

            if (i < rightIndex)
            {
                QuickSort(vetor, i, rightIndex);
            }

            return vetor;
        }
    }
}
