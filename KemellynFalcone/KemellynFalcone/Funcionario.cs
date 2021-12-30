using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemellynFalcone
{
    abstract class Funcionario
    {
        public int Codigo { get; set; }//forma mais compacta de realizar o encapsulamento "prop+tab+tab"
        public string Nome { get; set; }
        public double Salario { get; set; }

        protected Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public abstract double CalcularSalario(int diasUteis);//método abstrato só tem a assinatura dele
        //se o método é abstrato as subclasses são obrigadas a implementá-los
        //você programador não é obrigado a ter um método abstrato, é opcional
        public virtual void Mostrar()//método com polimorfismo
        {
            Console.WriteLine("Código: " + Codigo + "\t Nome: " + Nome + "\t Salário: " + Salario);
        }

    }
}
