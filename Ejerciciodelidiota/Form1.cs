using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ejerciciodelidiota
{
    public partial class Form1 : Form
    {
        List<Servicio> arrServicios = new List<Servicio>(100);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbTipoServicio.SelectedItem == null || cmbTipoVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir un tipo de vehiculo y un tipo de servicio");
            }
            else
            {
                string vehiculoSeleccionado = cmbTipoVehiculo.SelectedItem.ToString();
                string servicioSeleccionado = cmbTipoServicio.SelectedItem.ToString();
                char vehiculo = vehiculoSeleccionado == "Auto" ? 'A': 'C';
                int tipoServicio;
                switch (servicioSeleccionado)
                {
                    case "Lavado":
                        tipoServicio = 1;
                        break;
                    case "Encerado":
                        tipoServicio = 2;
                        break;
                    case "Silicona":
                        tipoServicio = 3;
                        break;
                    default:
                        tipoServicio = 0;
                        break;
                }
                Servicio objServicio = new Servicio(vehiculo, tipoServicio);
                objServicio.calcularMontoPagar();
                arrServicios.Add(objServicio);
                double montoPagar = objServicio.montoPagar;
                lstServiciosSeleccionados.Items.Add(vehiculoSeleccionado + " con servicio de " + servicioSeleccionado);
                lstServiciosSeleccionados.Items.Add("El precio es de: " + montoPagar);
            }
            
        }

        private void btnNumeroServicios_Click(object sender, EventArgs e)
        {
            int cantidadLavados = 0;
            int cantidadEncerados = 0;
            int cantidadSiliconas = 0;
            foreach (Servicio servicio in arrServicios)
            {
                switch (servicio.tipoServicio)
                {
                    case 1:
                        cantidadLavados++;
                        break;
                    case 2:
                        cantidadEncerados++;
                        break;
                    case 3:
                        cantidadSiliconas++;
                        break;
                    default:
                        break;
                }
            }
            MessageBox.Show("Cantidad de Lavados: " + cantidadLavados.ToString() + " Cantidad de Encerados: " + cantidadEncerados.ToString() + " Cantidad de Siliconas: " + cantidadSiliconas.ToString());
        }

        private void btnServicioMenorDemanda_Click(object sender, EventArgs e)
        {
            List<int> tiposServiciosMenosDemanda = new List<int>();
            int cantidadLavados = 0;
            int cantidadEncerados = 0;
            int cantidadSiliconas = 0;
            string mensajeMenorDemanda = "";
            bool servicioMenosDemandaMasDe1;
            bool noUltimo;
            foreach (Servicio servicio in arrServicios)
            {
                switch (servicio.tipoServicio)
                {
                    case 1:
                        cantidadLavados++;
                        break;
                    case 2:
                        cantidadEncerados++;
                        break;
                    case 3:
                        cantidadSiliconas++;
                        break;
                    default:
                        break;
                }
            }
            int menorCantidadServicio = cantidadLavados;
            int tipoMenorCantidadServicio;
            if(menorCantidadServicio > cantidadEncerados)
            {
                menorCantidadServicio = cantidadEncerados;
            }
            else if(menorCantidadServicio > cantidadSiliconas)
            {
                menorCantidadServicio = cantidadSiliconas;
            }
            if (menorCantidadServicio == cantidadLavados)
            {
                tipoMenorCantidadServicio = 1;
                tiposServiciosMenosDemanda.Add(tipoMenorCantidadServicio);
            }
            if (menorCantidadServicio == cantidadEncerados)
            {
                tipoMenorCantidadServicio = 2;
                tiposServiciosMenosDemanda.Add(tipoMenorCantidadServicio);
            }
            if(menorCantidadServicio == cantidadSiliconas)
            {
                tipoMenorCantidadServicio = 3;
                tiposServiciosMenosDemanda.Add(tipoMenorCantidadServicio);
            }
            servicioMenosDemandaMasDe1 = tiposServiciosMenosDemanda.Count() > 1;
            if (servicioMenosDemandaMasDe1)
            {
                mensajeMenorDemanda = "Los servicios con menos demanda son";
            }
            else
            {
                mensajeMenorDemanda = "El servicio con menos demanda es";
            }
            foreach (int tipoMenosDemanda in tiposServiciosMenosDemanda)
            {
                noUltimo = tiposServiciosMenosDemanda.Count()-1 != tiposServiciosMenosDemanda.IndexOf(tipoMenosDemanda);
                string mensaje = "";
                switch(tipoMenosDemanda)
                {
                    case 1:
                        mensaje = " el de lavado";
                        break;
                    case 2:
                        mensaje = " el de encerado";
                        break;
                    case 3:
                        mensaje = " el de silicona";
                        break;
                    default:
                        break;
                }
                mensajeMenorDemanda = mensajeMenorDemanda.Insert(mensajeMenorDemanda.Length, mensaje);
                if(servicioMenosDemandaMasDe1 && noUltimo)
                {
                    mensajeMenorDemanda = mensajeMenorDemanda.Insert(mensajeMenorDemanda.Length, " y");
                }
            }
            MessageBox.Show(mensajeMenorDemanda);
        }

        private void btnMontoPromedioLavado_Click(object sender, EventArgs e)
        {
            double montoTotal = 0;
            int cantidadLavado = 0;
            double promedio = 0;
            foreach (Servicio servicio in arrServicios)
            {
                if(servicio.tipoServicio == 1)
                {
                    montoTotal += servicio.montoPagar;
                    cantidadLavado++;
                }
            }
            if(cantidadLavado > 0)
            {
                promedio = montoTotal / cantidadLavado;
                MessageBox.Show("El monto promedio del servicio de lavado es: " + promedio);
            }
            else
            {
                MessageBox.Show("Eres taradito o te haces? Que se va a promediar si no hay ningun servicio de lavado maricon");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            arrServicios.Clear();
            lstServiciosSeleccionados.Items.Clear();
        }
    }
}
