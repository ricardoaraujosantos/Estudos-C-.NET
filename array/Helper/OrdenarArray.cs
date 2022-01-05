namespace array.Helper
{
    public class OrdenarArray
    {
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
        public void imprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
    }
}