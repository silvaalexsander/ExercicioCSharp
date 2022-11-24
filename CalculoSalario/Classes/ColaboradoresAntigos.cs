using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario.Classes
{
    public class ColaboradoresAntigos : Colaboradores
    {
      public ColaboradoresAntigos(string nome, string cargo, double salario, int tempoDeTrabalho) 
        { 
            this.Nome = nome;
            this.Cargo = cargo;
            this.SalarioAtual= salario;
        }
    }
}
