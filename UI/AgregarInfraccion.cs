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
    public partial class AgregarInfraccion : Form
    {
        private Administradora admin;
        private Vehiculo v;
        private Titular t;
        private TipoInfraccion ti;
        private Infraccion infraccion;
        public AgregarInfraccion(Administradora a)
        {
            InitializeComponent();
            admin = a;
            v = null;
            t = null;
            ti = null;
            infraccion = null;
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darListaTipoInfracciones();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textFecha.Text != "" && richTextBox1.Text != "" && textDominio.Text != "")
            {
                v = admin.buscarVehiculo(textDominio.Text);

                if(v!=null)
                {
                    t = admin.buscarTitular(v.DniTitular);
                    ti = (TipoInfraccion)listBox1.SelectedItem;

                    if(ti!=null)
                    {
                        if(this.validarFecha())
                        {
                            int num = ((admin.darListaInfracciones().Count) + 1);
                            string nya = (t.Nombre + " " + t.Apellido);
                            
                            DateTime fecha = Convert.ToDateTime(textFecha.Text);
                            fecha = fecha.AddDays(30);
                            string fechavencimiento = fecha.ToString("dd/MM/yyyy");
                            string str = "No Abonada";

                            infraccion = new Infraccion(num, ti.darCodInfraccion(), richTextBox1.Text, ti.Valor, v.Dominio, v.Marca, v.Modelo, t.Dni, nya, textFecha.Text, fechavencimiento,ti.Categoria,str);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La fecha ingresada es inválida o corresponde a una infracción que ya prescribió");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado un tipo de infracción");
                    }
                }
                else
                {
                    MessageBox.Show("El dominio ingresado es inválido o no corresponde a un vehículo registrado");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Debe completar todos los campos");
            }                   
        }

        public Infraccion darinfraccion()
        {
            return this.infraccion;
        }

        public bool validarFecha()
        {
            // 22/05/1994
            // Substring(0, 2) Día
            // Fecha.Substring(3, 2) Mes
            // Fecha.Substring(6, 4) Año


            int dia, mes, año;
            dia = int.Parse(textFecha.Text.Substring(0, 2));
            mes = int.Parse(textFecha.Text.Substring(3, 2));
            año = int.Parse(textFecha.Text.Substring(6, 4));

            if (año > 2015) // La infracción preescribio
            {
                if ((mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && dia >= 1 && dia <= 31)
                {
                    return true;
                }
                else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia >= 1 && dia <= 30)
                {
                    return true;
                }
                else if ((mes == 2) && dia>=1 && dia<=28)
                {
                    return true;
                }
                else if (((mes == 2) && dia >= 1 && dia <= 29) && ( ((año%4)==0) && ( (año%100)!=0) || (año%100)==0) ) // Fecha bisiesta
                {
                    return true;
                }
                else
                {
                    return false; // Fecha Inválida
                }
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
