namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesInvalido;
        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                mesInvalido = true;
            }
        }
        public int Mes 
        { 
            get
            {
                return this.mes;
            }
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesInvalido = true;
                }
            }
         }
        public void ApresentarMes()
        {
            if(mesInvalido)
            {
                System.Console.WriteLine($"O mês: {mes} é valido");
            }
            else
            {
                System.Console.WriteLine($"O mês digitado é invalido, escolha um mês entre 1 e 12");
            }
        }
    }
}