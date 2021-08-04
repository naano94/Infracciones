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
    public partial class AgregarTitular : Form
    {
        private Titular t;
        public AgregarTitular()
        {
            InitializeComponent();
            t = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textDni.Text!="" && textNombre.Text!="" && textApellido.Text!="" && textDomicilio.Text!="")
            {
                t = new Titular(int.Parse(textDni.Text),textNombre.Text,textApellido.Text,textDomicilio.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR: Debe completar todos los campos");
            }
            
             
        }
        
        public Titular darTitular()
        {
            return t;
        }
    }
}
