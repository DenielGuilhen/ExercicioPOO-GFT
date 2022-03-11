using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class Funcionario
    {
       
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Salario { get; set; }
        

        public Funcionario(string nome, int idade, float salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
            
        }
        
        public float bonificacao(float bonificacao)
        {
            var salario = this.Salario + bonificacao;

            return salario;
        }


        public override string ToString()
        {
            return $"Nome do funcionario: {this.Nome}, Idade do funcionario {this.Idade}, Salario do funcionario{this.Salario}";
        }
    }
}
