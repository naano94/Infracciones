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
    public partial class Vehiculos : Form
    {
        private Administradora admin;
        private Vehiculo v;
        public Vehiculos(Administradora ad)
        {
            InitializeComponent();
            admin = ad;
            v = null;
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaVehiculos();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarVehiculo agregar = new AgregarVehiculo(admin.darListaTitulares());
            agregar.ShowDialog();
            v = agregar.darVehiculo();

            if (v != null)
            {
                admin.AgregarVehiculo(v);
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaVehiculos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            v = (Vehiculo)listBox1.SelectedItem;
            if(v!=null)
            {
                admin.RemoverVehiculo(v);
                MessageBox.Show("El vehículo seleccionado fue dado de baja exitosamente");
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaVehiculos();
            }
            else
            {
                MessageBox.Show("ERROR: Debe seleccionar un vehículo del listado");
            }
        }
    }
}
