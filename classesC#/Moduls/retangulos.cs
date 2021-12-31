namespace exemploPoo.Moduls
{
    public class Retangulos
    {
        private double comprimento;
        private double largura;

        private bool validar;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && comprimento > 0){
                this.comprimento = comprimento;
                this.largura = largura;
                validar = true;
                System.Console.WriteLine("Os dois campos foram preenchidos com valores Validos");
                return;
            }
                System.Console.WriteLine("Um ou mais Campos foram preenchidos com valores invalidos");
        } 

        public double ObterArea()
        {
            if(validar == true){
                return comprimento * largura;
            }
            System.Console.WriteLine("Digite valores validos seu retorno:");
            return 0;
        }
    }
}