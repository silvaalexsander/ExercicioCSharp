

namespace CalculoSalario.Classes
{
    public class CalculoReajuste : ICalculo
    {

        public double AumentoSalario(double salario, double porcentagem)
        {
            return salario * (porcentagem / 100) + salario;
           
        }
    }
}
