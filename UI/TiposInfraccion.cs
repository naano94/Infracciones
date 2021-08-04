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
    public partial class TiposInfraccion : Form
    {
        private TipoInfraccion tipo;
        private Administradora admin;
        public TiposInfraccion(Administradora ad)
        {
            InitializeComponent();
            tipo = null;
            admin = ad;
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaTipoInfracciones();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarTipoInfraccion agregar = new AgregarTipoInfraccion();
            agregar.ShowDialog();
            tipo = agregar.darTipoInfraccion();

            if(tipo != null)
            {
                admin.AgregarTipoInfraccion(tipo);
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaTipoInfracciones();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipo = (TipoInfraccion)listBox1.SelectedItem;

            if (tipo != null)
            {
                ModificarTipoInfraccion modificar = new ModificarTipoInfraccion(tipo);
                modificar.ShowDialog();
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaTipoInfracciones();
            }
            else
            {
                MessageBox.Show("ERROR: Debe seleccionar un tipo de infracción del listado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipo = (TipoInfraccion)listBox1.SelectedItem;

            if (tipo != null)
            {
                admin.RemoverTipoInfraccion(tipo);
                MessageBox.Show("El tipo de infraccion seleccionado fue dado de baja exitosamente");
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaTipoInfracciones();
            }
            else
            {
                MessageBox.Show("ERROR: Debe seleccionar un tipo de infracción del listado");
            }
        }
    }
}
