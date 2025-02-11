﻿using System;
using System.Collections.Generic;
using array.Helper;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] Array = new int[4] {10, 20, 30, 40};
        //    Array[0] = 10; 
        //    Array[1] = 20; 
        //    Array[2] = 30; 
        //    Array[3] = 40; 

           for (int i = 0; i < Array.Length; i++)
             {
                System.Console.WriteLine($"Percorrer Array com for : indice {i} é {Array[i]}");
             }

           foreach (var ArrayLength in Array)
             {
                 System.Console.WriteLine($"Percorrer Array com foreach : {ArrayLength}");
             }

             int[,] arrayMulti = new int[5, 2]
             {
                 { 10, 20 },
                 { 30, 40 },
                 { 50, 60 },
                 { 70, 80 },
                 { 90, 100 }
             };

             for (int linha = 0; linha < arrayMulti.GetLength(0); linha++)
             {
                 for (int coluna = 0; coluna < arrayMulti.GetLength(1); coluna++)
                 {
                     System.Console.WriteLine($"A linha {linha} e coluna {coluna} = {arrayMulti[linha, coluna]}");
                 }
             }

             //Ordenando um array Bubble sorte

             int[] arrayNum = new int[8] {5, 2, 7, 4, 6, 1, 3, 6};

             OrdenarArray ordArray = new OrdenarArray();
            //System.Console.WriteLine("Array original:");
            //  ordArray.imprimirArray(arrayNum);

            //  ordArray.OrdenarBubbleSorte(ref arrayNum);
            //  System.Console.WriteLine("Array ordenado Bubble Sort:");
            //  ordArray.imprimirArray(arrayNum);

             //classe Array:
             //metodo Sort
             System.Console.WriteLine("arrayNum original não ordenado linha");
             ordArray.imprimirArrayLinha(arrayNum);
             ordArray.ordenarClasseArraySort(ref arrayNum);
             System.Console.WriteLine("arrayNum ordenado linha");
             ordArray.imprimirArrayLinha(arrayNum);

             //metodo Copy
             int[] arrayCopy = new int[12];
             ordArray.CopiarArray(ref arrayNum, ref arrayCopy);
             System.Console.WriteLine("arrayCopy Copiado de arrayNum");
             ordArray.imprimirArrayLinha(arrayCopy);

             //metodo exists
             int valorProcurado = 5;
             bool existe = ordArray.Existe(arrayNum, valorProcurado);

             if(existe)
             {
                 System.Console.WriteLine($"Valor {valorProcurado} existe e foi encontrado");
             }
             else
             {
                 System.Console.WriteLine($"O valor {valorProcurado} não existe no arrayNum");
             }

             //metodo IndexOf
             int indice = ordArray.obterIndex(arrayCopy, valorProcurado);

             if(indice > -1)
             {
                 System.Console.WriteLine($"O indice do elemento é {indice} valor procurado {valorProcurado}");
             } 
             else
             {
                 System.Console.WriteLine("O indice procurado não existe");
             }

             //metodo Resize

             System.Console.WriteLine($"Redimensionando array tamanho atual: {arrayNum.Length}");
             ordArray.redimensionarArray(ref arrayNum, arrayNum.Length * 2);
             System.Console.WriteLine($"Array redimensionado novo tamanho: {arrayNum.Length}");

             //metodo ConvertAll
             int[] ArrayInteiros = new int[6] {4, 6, 8, 10, 7, 13};
             System.Console.WriteLine($"Array de inteiros: {ArrayInteiros}");
             string[] arrayString =  ordArray.converterArrayParaString(ArrayInteiros);
             System.Console.WriteLine($"Array de inteiros convertido para string: {ArrayInteiros}");

             //Utilizando Links
             //Sintaxe Query ordenar somente numeros pares do array
             var numParesQuery = 
                    from num in  ArrayInteiros
                    where num % 2 == 0
                    orderby num
                    select num;

            System.Console.WriteLine($"ArrayInteiro numeros pares resultado com Query: {string.Join(", ", numParesQuery)}");

            //Sintaxe metodo ordenar somente numeros pares do array
            var numParesMetodo = ArrayInteiros.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
            System.Console.WriteLine($"ArrayInteiros numeros pares resultado com Metodo: {string.Join(", ", numParesMetodo)}");

            //Calcular valor min, max, e medio de um Array
            //Min, Max, Average
            System.Console.WriteLine($"Calcular valores min, max e medio do Array numParesMetodos:");
            var minimo = numParesMetodo.Min();
            var maximo = numParesMetodo.Max();
            var medio = numParesMetodo.Average();
            System.Console.WriteLine("Valor minimo: {0}, valor maximo: {1}, valor medio: {2}",minimo, maximo, medio);

            // Sum e Distinct
            int[] arrayValorIgual = new int[10] {3, 5, 1, 5, 4, 7, 8, 6, 7, 8};
            var somaArray = arrayValorIgual.Sum();
            var valorUnicoarray = arrayValorIgual.Distinct();
            
            System.Console.WriteLine("ArrayValorIgual é: {0}", string.Join(", ", arrayValorIgual));
            System.Console.WriteLine("Soma de arrayValorIgual é igual {0}", somaArray);
            System.Console.WriteLine("Obter valores unicos em arrayValorIgual: {0}", string.Join(", ", valorUnicoarray));
            
            //Listas Genericas

            operacoesList opListas = new operacoesList();
            List<string> estados = new List<string>() {"SP", "MG", "SE", "BA"};
            string[] arrayEstados = new string[3]{"RO", "PI", "PA"};

            //Adicionar
            estados.Add("CE");
            opListas.imprimirListas(estados);
            System.Console.WriteLine("Quantidade de Estados contidos na lista: {0}", estados.Count);

            //Remover
            estados.Remove("SE");
            opListas.imprimirListas(estados);
            System.Console.WriteLine("Quantidade de Estados contidos na lista: {0}", estados.Count);

            //Adicionar um array a lista
            estados.AddRange(arrayEstados);
            opListas.imprimirListas(estados);
            System.Console.WriteLine("Quantidade de Estados contidos na lista: {0}", estados.Count);

            //Adicionar um novo valor a lista em um indice especifico
            estados.Insert(0, "TO");
            opListas.imprimirListas(estados);
            System.Console.WriteLine("Quantidade de Estados contidos na lista: {0}", estados.Count);

            //Coleçoes especificas 
            //Fila
            operacoesFila opFila = new operacoesFila();
            Queue<string> minhaFila = new Queue<string>();
            minhaFila.Enqueue("João");
            minhaFila.Enqueue("Maria");
            minhaFila.Enqueue("José");
            minhaFila.Enqueue("Luiz");
            System.Console.WriteLine("Existe {0} Pessoas na fila", minhaFila.Count);
            opFila.imprimirFila(minhaFila);

            //Pilha
            operacoesPilha opPilha = new operacoesPilha();
            Stack<string> meusLivros = new Stack<string>();
            meusLivros.Push(".NET");
            meusLivros.Push("C#");
            meusLivros.Push("Codigo Limpo");
            meusLivros.Push("Design Patterns design");
            System.Console.WriteLine("Livros disponiveis {0}", meusLivros.Count);
            opPilha.imprimirPilha(meusLivros);

            //Dicionarios
            operacoesDicionario opDicionario = new operacoesDicionario();
            Dictionary<string, string> estadoCapital = new Dictionary<string, string>();

            //Adicionar chave valor
            estadoCapital.Add("SE", "Aracajú");
            estadoCapital.Add("BA", "Salvador");
            estadoCapital.Add("SP", "São Paulo");
            System.Console.WriteLine("Possui {0} Estados representando seu Id (Chave) e {0} Capitais representando seus valores referente a capital ", estadoCapital.Count);
            opDicionario.imprimirDicionario(estadoCapital);

            //Procurar valor através da chave
            System.Console.WriteLine("procurar valor com chave:");
            var procurarValorComChave = "SE";
            System.Console.WriteLine("Chave inserida: {0} valor encontrado: {1}", procurarValorComChave, estadoCapital[procurarValorComChave]);

            //Atualizar chave
            System.Console.WriteLine("Atualizar chave de busca");
            procurarValorComChave = "SP";
            System.Console.WriteLine("Nova chave de busca: {0} resultado {0}-{1}", procurarValorComChave, estadoCapital[procurarValorComChave]);

            //Remover chave valor
            System.Console.WriteLine("Chaves e Valores existentes");
            opDicionario.imprimirDicionario(estadoCapital);
            System.Console.WriteLine("Removendo chave e valor");
            System.Console.WriteLine("Chave inserida: {0} => Chave e valor {0} removido com sucesso!", procurarValorComChave);
            estadoCapital.Remove(procurarValorComChave);
            System.Console.WriteLine("Novo resultado chaves e valores existentes");
            opDicionario.imprimirDicionario(estadoCapital);
         }
    }
}