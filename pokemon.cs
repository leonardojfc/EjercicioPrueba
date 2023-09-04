using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPokemon_Clases
{
    internal class pokemon
    {
        private int ataque;
        private int vida;

        public pokemon (int _ataque, int _vida)
        {
            this.ataque = _ataque;
            this.vida = _vida;  
        }

        public int getvidaPokemon()
        {
            return vida;
        }

        public int geataquePokemon()
        {
            return ataque;
        }

        public int setvidaPokemon(int _vida)
        {
            return this.vida = _vida;
        }

        public int seataquePokemon(int _ataque)
        {
            return this.ataque = _ataque;
        }

    }
}
