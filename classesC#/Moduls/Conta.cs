namespace exemploPoo.Moduls
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Verificar Saldo conta Corrente, seu saldo é : R$ {saldo}");
        }
    }
}