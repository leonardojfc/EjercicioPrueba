using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPokemon_Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPokemonelegido.Text = cmbPokemon.Text;

            if(lblPokemonelegido.Text == "Fuego")
            {

            }

            if (lblPokemonelegido.Text == "Agua")
            {
                PokemonAgua objPokemonAgua = new PokemonAgua(50, 55);

                lblAtaque.Text = objPokemonAgua.geataquePokemon().ToString();
                lblVida.Text = objPokemonAgua.getvidaPokemon().ToString();
            }

            if (lblPokemonelegido.Text == "Electricidad")
            {

            }
        }
    }
}
