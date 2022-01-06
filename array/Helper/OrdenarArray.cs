namespace array.Helper
{
    public class OrdenarArray
    {
        //Meto bubble sort
         public void OrdenarBubbleSorte(ref int[] array)
        {
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        value = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = value;
                    }
                }
            }
        }
        //Metodo Imprimir array
        public void imprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }

        //Metodo Imprimir array em uma linha
        public void imprimirArrayLinha(int[] array)
        {
                var linha = string.Join(", ", array);
                System.Console.WriteLine(linha);
        }

        //Classe array metodo 
        public void ordenarClasseArraySort(ref int[] array)
        {
            Array.Sort(array);
        }
        public void CopiarArray(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }
        public bool Existe(int[] array, int value)
        {
            return Array.Exists(array, elemento => elemento == value);
        }
        public int obterIndex(int[] array, int value)
        {
            return Array.IndexOf(array, value);
        }
        public void redimensionarArray(ref int[] array, int novoTamnho)
        {
            Array.Resize(ref array, novoTamnho);
        }
        public string[] converterArrayParaString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}