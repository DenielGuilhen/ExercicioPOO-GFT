using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidades { get; set; }

        public Guerreiro(string nome, int mana, int vida, float xp, int inteligencia, int forca, int level, List<string> habilidades) : base(nome, mana, vida, xp, inteligencia, forca, level)
        {
            this.Habilidades = habilidades;
        }

        public override void LvlUp()
        {
            this.Level += 1;
            this.Vida += 5;
            this.Forca += 5;
        }

        public int Attack()
        {
            Random rnd = new Random();

            int dano = (this.Forca * this.Level) + rnd.Next(0, 300);

            return dano;
        }

        public void AprenderHabilidade(string habilidades)
        {
            this.Habilidades.Add(habilidades);
        }

    }
}
