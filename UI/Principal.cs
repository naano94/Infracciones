using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RN;

namespace UI
{
    public partial class Principal : Form
    {
        private TiposInfraccion tipos;
        private Titulares titulares;
        private Vehiculos vehiculos;
        private Administradora admin;
        private Infracciones infracciones;
        private List<Infraccion> listaInfracciones;
        private List<TipoInfraccion> listaTipoInfracciones;
        private List<Pago> listaPagos;
        private List<Vehiculo> listaVehiculos;
        private List<Titular> listaTitulares;
        private Pagos pagos;
        public Principal()
        {
            InitializeComponent();

            Administradora.PonerPath(Application.StartupPath);
            admin = new Administradora();

            listaInfracciones = Infraccion.TraerDataInfracciones();
            listaTipoInfracciones = TipoInfraccion.TraerDataTipoInfracciones();
            listaPagos = Pago.TraerDataPagos();
            listaVehiculos = Vehiculo.TraerDataVehiculos();
            listaTitulares = Titular.TraerDataTitulares();

            admin.Infracciones = listaInfracciones;
            admin.Vehiculos = listaVehiculos;
            admin.TipoInfracciones = listaTipoInfracciones;
            admin.Titulares = listaTitulares;
            admin.Pagos = listaPagos;

            
            tipos = new TiposInfraccion(admin);
            titulares = new Titulares(admin);
            vehiculos = new Vehiculos(admin);
            infracciones = new Infracciones(admin);
            pagos = new Pagos(admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infracciones.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titulares.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vehiculos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pagos.ShowDialog();
        }
    }
}
