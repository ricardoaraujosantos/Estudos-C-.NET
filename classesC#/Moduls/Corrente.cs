namespace exemploPoo.Moduls
{
    public class Corrente : Conta
    {
        public override void creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}