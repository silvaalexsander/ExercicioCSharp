using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario.Classes
{
    public interface ICalculo
    {
        public double AumentoSalario(double salario, double porcentagem);
    }
}
