using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemellynFalcone
{
    class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }
        public Comissionado(int codigo, string nome, double salario, double porcentagem) : base(codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis * Porcentagem + Salario;
        }
        public override void Mostrar()
        {
            base.Mostrar(); //executa exatamente o que esta na superclasse
            Console.WriteLine("Porcentagem da comissão: " + Porcentagem);
        }


    }
}
