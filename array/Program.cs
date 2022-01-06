﻿using System;
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
             int[] ArrayInteiros = new int[4] {4, 6, 8, 10};
             System.Console.WriteLine($"Array de inteiros: {ArrayInteiros}");
             string[] arrayString =  ordArray.converterArrayParaString(ArrayInteiros);
             System.Console.WriteLine($"Array de inteiros convertido para string: {ArrayInteiros}");
         }
    }
}