using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }

        public double Preco { get; set; }

        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Km = km;
            this.IsLigado = isLigado;
            this.LitrosCombustivel = litrosCombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }

        public void Acelerar()
        {
            this.Velocidade += 20;
        }

        public void Abastecer(int combustivel)
        {

            if (LitrosCombustivel + combustivel <= 60)
            {
                this.LitrosCombustivel += combustivel;
            }
            else
            {
                Console.WriteLine("O valor ultrapassara o limite");
            }
        }

        public void Frear()
        {
            if (Velocidade >= 20)
            {
                this.Velocidade -= 20;
            }
            else if (Velocidade < 20)
            {
                this.Velocidade = 0;
            }

        }

        public void Pintar(string cor)
        {
            this.Cor = cor;
        }

        public void Ligar()
        {
            if (this.IsLigado == false)
            {
                this.IsLigado = true;
            }
        }

        public void Desligar()
        {
            if (this.IsLigado == true && this.Velocidade == 0)
            {
                this.IsLigado = false;
            }
        }

        public override string ToString()
        {
            return $"Marca: {this.Marca}, Km: {this.Km}, Modelo: {this.Modelo}, Placa: {this.Placa}, Cor: {this.Cor}, Km: {this.Km}, Ligado: {this.IsLigado}, " +
                $"Litros de combustivel: {this.LitrosCombustivel}, Velocidade: {this.Velocidade}, Preço: R${this.Preco.ToString("F")}";
        }
    }
}           //Console.WriteLine($"{preco.ToString("F")}");