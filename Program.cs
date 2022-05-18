using System.Collections.Generic;

namespace Algoritmos_Básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int BuscaSequencial(List<int> listaDeNumeros, int numeroProcurado) {
            var indice = 0;
            foreach (var numeroDaLista in listaDeNumeros)
            {
                if (numeroDaLista == numeroProcurado)
                    return indice;
                indice += 1;
            }
            return -1;
        }

        public static int BuscaBinaria(List<int> listaDeNumeros, int numeroProcurado) {
            var posicao_inicial = 0;
            var posicao_final = listaDeNumeros.Count - 1;

            while (posicao_inicial <= posicao_final) {
                var posicao_meio = (posicao_inicial + posicao_final) / 2;

                if (listaDeNumeros[posicao_meio] == numeroProcurado)
                    return posicao_meio;
                if (listaDeNumeros[posicao_meio] > numeroProcurado)
                    posicao_final = posicao_meio - 1;
                if (listaDeNumeros[posicao_meio] < numeroProcurado)
                    posicao_inicial = posicao_meio + 1;
            }

            return -1;
        }
    }
}
