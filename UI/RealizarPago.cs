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
    public partial class RealizarPago : Form
    {
        private Administradora admin;
        private Pago pago;
        private List<Infraccion> infracciones;
        private List<Pago> pagos;
        private Infraccion inf;
        public RealizarPago(Administradora a)
        {
            InitializeComponent();
            admin = a;
            pago = null;
            inf = null;
            admin = a;
            infracciones = admin.darListaInfracciones();
            pagos = admin.darListaPagos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="")
            {
                int dni = int.Parse(textBox1.Text);
                int nroInfraccion = int.Parse(textBox2.Text);

                bool encuentra = false;
                bool pagoRealizado = false;

                for (int i = 0; i < infracciones.Count; i++)
                {
                    if (infracciones[i].darDni() == dni && infracciones[i].NroInfraccion == nroInfraccion)
                    {
                        inf = infracciones[i];
                        encuentra = true;
                        break;
                    }
                }

                for(int i=0;i < pagos.Count();i++)
                {
                    if(pagos[i].darNroInfraccion()== nroInfraccion && pagos[i].darDniTitular()==dni)
                    {
                        pagoRealizado = true;
                        break;
                    }
                }

                if (!pagoRealizado)
                {
                    if (encuentra)
                    {
                        AbonarPago abonar = new AbonarPago(admin, inf);
                        abonar.ShowDialog();
                        pago = abonar.darPago();
                        admin.AgregarPago(pago);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: El número de Infracción o el DNI del titular ingresado no corresponden a una infracción registrada");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: La infracción ingresada ya fue abonada");
                } 
            }
            else
            {
                MessageBox.Show("ERROR: Debe completar todos los campos");
            }
        }
    }
}
