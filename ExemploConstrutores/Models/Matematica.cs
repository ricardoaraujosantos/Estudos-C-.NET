namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;
            CalculadoraEvento.Eventocalculadora += EventoHendler;
        }
        public void somar()
        {
            CalculadoraEvento.somar(X, Y);
        }
        public void EventoHendler()
        {
            System.Console.WriteLine("Metodo Executado com sucesso");
        }
    }
}