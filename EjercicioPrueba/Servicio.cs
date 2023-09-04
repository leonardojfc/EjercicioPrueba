using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciodelidiota
{
    internal class Servicio
    {
        public char vehiculo { get; set; }
        public int tipoServicio { get; set; }
        public double montoPagar { get; set; }

        public Servicio()
        {
            this.vehiculo = (char)0;
            this.tipoServicio = 0;
            this.montoPagar = 0;
        }
        public Servicio(char vehiculo, int tipoServicio)
        {
            this.vehiculo = vehiculo;
            this.tipoServicio = tipoServicio;
            this.montoPagar = 0;
        }

        public void calcularMontoPagar()
        {
            double aumentoPrecio = 0;
            double montoParcial;
            if(vehiculo == 'C')
            {
                aumentoPrecio = 0.05;
            }
            switch(this.tipoServicio)
            {
                case 1:
                    montoParcial = 20;
                    break;
                case 2:
                    montoParcial = 15;
                    break;
                case 3:
                    montoParcial = 10;
                    break;
                default:
                    montoParcial = 0;
                    break;
            }
            this.montoPagar = montoParcial * (1 + aumentoPrecio);
        }
    }
}
