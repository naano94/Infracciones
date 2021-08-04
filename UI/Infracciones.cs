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
    public partial class Infracciones : Form
    {
        private Infraccion inf;
        private Administradora admin;
        public Infracciones(Administradora a)
        {
            InitializeComponent();
            admin = a;
            inf = null;
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaInfracciones();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void darDeAltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarInfraccion agregar = new AgregarInfraccion(admin);
            agregar.ShowDialog();
            inf = agregar.darinfraccion();

            if (inf != null)
            {
                admin.AgregarInfraccion(inf);
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaInfracciones();
            }
        }
    }
}
