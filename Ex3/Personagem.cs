using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public abstract class Personagem
    {
        public static int QtdPersonagens { get; set; }
        public string Nome { get; set; }
        public int Mana { get; set; }
        public int Vida { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public Personagem (string nome, int mana, int vida, float xp, int inteligencia, int forca, int level)
        {
            Personagem.QtdPersonagens++;
            this.Nome = nome;
            this.Mana = mana;
            this.Vida = vida;
            this.Xp = xp;
            this.Inteligencia = inteligencia;
            this.Forca = forca;
            this.Level = level;   
        }
        public abstract void LvlUp();
        public override string ToString()
    {
        return $"Nome do personagem: {this.Nome}, Mana do personagem: {this.Mana}, Vida do personagem: {this.Vida}, XP do personagem: {this.Xp}, " +
            $"Inteligencia do personagem: {this.Inteligencia}, Força do personagem: {this.Forca}, Level do personagem {this.Level}";
    }
   }   
}  