using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, float salario) : base(nome, idade, salario)
        {
            
        }

        public float Bonificacao()
        {
            var salario = this.Salario + 5000;

            return salario;

            return this.Salario;
        }

    }
}
