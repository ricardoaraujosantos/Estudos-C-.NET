namespace array.Helper
{
    public class operacoesFila
    {
        public void imprimirFila(Queue<string> fila)
        {
            while (fila.Count > 0)
            {
                 System.Console.WriteLine("Vez de: {0}",fila.Peek());
                 System.Console.WriteLine("{0} foi atendido", fila.Dequeue());
                 System.Console.WriteLine("Existe {0} pessoas na fila", fila.Count);
            }
        }
    }
}