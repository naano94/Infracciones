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
    public partial class AgregarVehiculo : Form
    {
        private Vehiculo vehiculo;
        private string categoria;
        private List<Titular> titulares;
        public AgregarVehiculo(List<Titular> listaTitulares)
        {
            InitializeComponent();
            vehiculo = null;
            categoria = "";
            titulares = listaTitulares;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioMoto.Checked)
            {
                categoria = "Motocicleta";
            }
            else if(radioAuto.Checked)
            {
                categoria = "Automovil";
            }
            else if(radioUtilitario.Checked)
            {
                categoria = "Utilitario";
            }

            bool encuentra = false;

            if(textDominio.Text != "" && textMarca.Text != "" && textModelo.Text != "" && textDni.Text != "")
            {
                if (categoria != "")
                {
                    for (int i = 0; i < titulares.Count; i++)
                    {
                        if (titulares[i].Dni == int.Parse(textDni.Text))
                        {
                            encuentra = true;
                            break;
                        }
                    }

                    if(encuentra)
                    {
                        vehiculo = new Vehiculo(textDominio.Text, textMarca.Text, textModelo.Text, int.Parse(textDni.Text), categoria);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: El número de dni ingresado no pertenece a un titular registrado");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Debe seleccionar un tipo de vehículo");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Debe completar todos los campos");
            }

        }
        
        public Vehiculo darVehiculo()
        {
            return vehiculo;
        }
    }
}
