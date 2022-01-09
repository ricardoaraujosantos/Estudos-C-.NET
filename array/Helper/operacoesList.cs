namespace array.Helper
{
    public class operacoesList
    {
        public void imprimirListas(List<string> lista)
        {
             for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine("Indice: {0} Estado: {1}",i ,lista[i]);
            }
        }
    }
}