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
    public partial class Pagos : Form
    {
        private Administradora admin;
        public Pagos(Administradora ad)
        {
            InitializeComponent();
            admin = ad;
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaPagos();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarPago agregar = new RealizarPago(admin);
            agregar.ShowDialog();
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaPagos();
        }
    }
}
