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
    public partial class ModificarTipoInfraccion : Form
    {
        private TipoInfraccion tipo;
        private string nombre;
        private string valor;
        
        public ModificarTipoInfraccion(TipoInfraccion t)
        {
            InitializeComponent();
            tipo = t;
            textCodigo.Text = tipo.darCodInfraccion();
            textNombre.Text = tipo.Nombre;
            textCosto.Text = tipo.Valor.ToString();

            nombre = textNombre.Text;
            valor = textCosto.Text;

           if(tipo.Categoria=="Leve")
           {
                radioLeve.Checked = true;
           }
           else
           {
                radioGrave.Checked = true;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textNombre.Text!="" && textCosto.Text!="")
            {
                if (nombre != textNombre.Text)
                {
                    tipo.Nombre = textNombre.Text;
                }

                if (valor != textCosto.Text)
                {
                    tipo.Valor = float.Parse(textCosto.Text);
                }

                if (radioGrave.Checked == true)
                {
                    tipo.Categoria = "Grave";
                }

                if (radioLeve.Checked == true)
                {
                    tipo.Categoria = "Leve";
                }
            }
            else
            {
                MessageBox.Show("ERROR: No puede dejar campos en blanco");
            }
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
