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
    public partial class Titulares : Form
    {
        private Administradora admin;
        private Titular tit;
        public Titulares(Administradora ad)
        {
            InitializeComponent();
            tit = null;
            admin = ad;
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaTitulares();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarTitular agregar = new AgregarTitular();
            agregar.ShowDialog();
            tit = agregar.darTitular();

            if(tit != null)
            {
                admin.AgregarTitular(tit);
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaTitulares();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tit = (Titular)listBox1.SelectedItem;

            if(tit!=null)
            {
                admin.RemoverTitular(tit);
                MessageBox.Show("El titular seleccionado fue dado de baja exitosamente");
                listBox1.DataSource = null;
                listBox1.DataSource = admin.darListaTitulares();
            }
            else
            {
                MessageBox.Show("ERROR: Debe seleccionar un titular del listado");
            }
        }
    }
}
