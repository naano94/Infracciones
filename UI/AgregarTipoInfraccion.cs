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
    public partial class AgregarTipoInfraccion : Form
    {
        private TipoInfraccion tipo;
        private string gravedad;
        public AgregarTipoInfraccion()
        {
            InitializeComponent();
            tipo = null;
            gravedad = "";
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                gravedad = "Leve";
            }
            else if(radioButton2.Checked)
            {
                gravedad = "Grave";
            }
            
            if(textCodigo.Text!="" && textCosto.Text!="" && textNombre.Text!="")
            {
                if (gravedad != "")
                {
                    tipo = new TipoInfraccion(textCodigo.Text, float.Parse(textCosto.Text), gravedad, textNombre.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR: Debe seleccionar una categoría");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Debe completar todos los campos");
            }            
            
            
        }

        public TipoInfraccion darTipoInfraccion()
        {
            return tipo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
