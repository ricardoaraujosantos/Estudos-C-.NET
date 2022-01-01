namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void somar(int num1, int num2)
        {
            System.Console.WriteLine($"Resultado da operação de adição: {num1 + num2}");
        }
        public static void subtrair(int num1, int num2)
        {
            System.Console.WriteLine($"Resultado da operação de subtração: {num1 - num2}");
        }
    }
}