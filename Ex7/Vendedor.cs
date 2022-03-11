using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, float salario) : base(nome, idade, salario)
        {
            
        }

        public float Bonificacao()
        {
            var salario = this.Salario + 3000;

            return salario;

            return this.Salario;
        }

    }
}