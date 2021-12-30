using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemellynFalcone
{
    class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {

        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
    }
}
