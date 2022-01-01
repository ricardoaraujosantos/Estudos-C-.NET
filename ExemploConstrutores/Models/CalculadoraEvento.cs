namespace ExemploConstrutores.Models
{
    public class CalculadoraEvento
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora Eventocalculadora;
         public static void somar(int x, int y)
        {
            if(Eventocalculadora != null)
            {
                System.Console.WriteLine($"Resultado do evento da operação de adição: {x + y}");
                Eventocalculadora();
            }
        }
        public static void subtrair(int x, int y)
        {
            System.Console.WriteLine($"Resultado do evento da operação de subtração: {x - y}");
        }
    }
}