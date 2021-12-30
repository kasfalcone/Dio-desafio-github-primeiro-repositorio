using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemellynFalcone
{
    class Dependente : Funcionario
    {
        public int Idade { get; set; }
        public List<Funcionario> VetD { get; set; }
        public Dependente(int codigo, string nome, double salario, int idade) : base(codigo, nome, salario)
        {
            
        }
        public void AdicionarDependente(Funcionario f)
        {
            VetD.Add(f);
        }
    }
}
