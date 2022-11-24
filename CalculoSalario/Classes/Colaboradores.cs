using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario.Classes
{
    public class Colaboradores
    {
        private string _nome;
        private string _cargo;
        private double _salarioAtual;
        private int _tempoDeTrabalho;

        public Colaboradores()
        {
            this._nome = string.Empty;
            this._cargo = string.Empty;
            this._salarioAtual = 0;
            this.TempoDeTrabalho = 0;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public double SalarioAtual { get => _salarioAtual; set => _salarioAtual = value; }
        public int TempoDeTrabalho { get => _tempoDeTrabalho; set => _tempoDeTrabalho = value; }

        
       

    }
}
