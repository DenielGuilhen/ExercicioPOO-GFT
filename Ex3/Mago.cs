using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Mago : Personagem
    {
        public List<string> Magias { get; set; }

        public Mago(string nome, int mana, int vida, float xp, int inteligencia, int forca, int level, List<string> magias) : base(nome, mana, vida, xp, inteligencia, forca, level)
        {
            this.Magias = magias;
        }

        public override void LvlUp()
        {
            this.Level += 1;
            this.Mana += 5;
            this.Inteligencia += 5;
        }

        public int Attack()
        {
            Random rnd = new Random();

            int dano = (this.Inteligencia * this.Level) + rnd.Next(0, 300);
            
            return dano;

        }

        public void AprenderMagia(string magia)
        {
            this.Magias.Add(magia);
        }

    }
}