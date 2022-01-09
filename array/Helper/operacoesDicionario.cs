namespace array.Helper
{
    public class operacoesDicionario
    {
        public void imprimirDicionario(Dictionary<string, string> estadosCapital)
        {
            foreach (KeyValuePair<string, string> item in estadosCapital)
            {
                System.Console.WriteLine("Chave: {0} Valor: {1}", item.Key, item.Value);
            }
        }
    }
}