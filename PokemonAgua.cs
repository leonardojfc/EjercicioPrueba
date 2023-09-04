using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPokemon_Clases
{
    internal class PokemonAgua : pokemon
    {
        private string _debilidad;
        public PokemonAgua(int _ataqueagua, int _vidaagua) : base( _ataqueagua, _vidaagua)
        {
            _debilidad = "Fuego";
        }

        public string getdebilidad()
        {
            return _debilidad;
        }
    }
}
