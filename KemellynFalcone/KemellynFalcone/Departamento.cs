using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemellynFalcone
{
    class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Listar()
        {
            Console.WriteLine("\nRelação de Funcionário do departamento " + Nome);
            foreach (Funcionario f in VetF)
                f.Mostrar();
        }
        public double CalcularFolha(int diasUteis)
        {
            Console.WriteLine("\nFolha de pagamento dos Funcionários do departamento " + Nome);
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void Demitir(int codigo_pesquisa)
        {
            for (int i = 0; i < VetF.Count; i++)
            {//generalização
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (codigo_pesquisa == f.Codigo)
                    VetF.Remove(f);
            }
        }

    }
}
