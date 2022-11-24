using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario.Classes
{
    public class Cadastrar
    {
        ColaboradoresAntigos colaboradorAntigo;
        CalculoReajuste calculo = new CalculoReajuste();
        ColaboradoresNovos colaboradoresNovos;
        List<Colaboradores> lista = new List<Colaboradores>();
        private string nome;
        private string cargo;
        private double salario;
        private int tempoDeTrabalho;
        public void Cadastro()
        {
            int escolha = 0;
            do
            {
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Cargo: ");
                cargo = Console.ReadLine();
                Console.WriteLine("Salario: ");
                salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ano de contratação");
                tempoDeTrabalho = Convert.ToInt16(Console.ReadLine());
                if(2022 - tempoDeTrabalho >= 3)
                {
                    colaboradorAntigo = new ColaboradoresAntigos(nome, cargo, salario, tempoDeTrabalho);
                    lista.Add(colaboradorAntigo);
                    
                }
                else if((2022 - tempoDeTrabalho) < 3 && (2022 - tempoDeTrabalho >= 0))
                {
                    colaboradoresNovos = new ColaboradoresNovos(nome, cargo, salario, tempoDeTrabalho);
                    lista.Add(colaboradoresNovos);
                }

                if(salario > 7000 && (2022 - tempoDeTrabalho)>= 3)
                {
                    salario = calculo.AumentoSalario(salario, 10);
                    Console.WriteLine($"Colaborador ganhou 10% de aumento, novo salario R${salario}");
                }
                else
                {
                    Console.WriteLine("Funcionario não elégivel para aumento de 10%, insiera a porcentagem de aumento para ele: ");
                    double porcentagem  = Convert.ToDouble(Console.ReadLine());
                    salario = calculo.AumentoSalario(salario, porcentagem);
                    Console.WriteLine($"Novo salario: R${salario}");
                }
                Console.WriteLine("Deseja cadastrar outro funcionario? \n1 - Sim\n2- Não");
                escolha = Convert.ToInt16(Console.ReadLine());

            } while (escolha == 1);
        }

        public void ExibeDados()
        {
            foreach (var item in lista)
            {
                Console.WriteLine($"\n========Colaboradores Cadastrados=========\nNome: {item.Nome}\nCargo: {item.Cargo}\nSalario: {item.SalarioAtual}\n\n\n");
            }
        }
    }
}
