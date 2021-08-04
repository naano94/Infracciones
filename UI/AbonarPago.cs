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
    public partial class AbonarPago : Form
    {
        private Administradora admin;
        private Infraccion inf;
        private Pago pago;
        private int nroPago;
        private float imp;
        public AbonarPago(Administradora ad,Infraccion i)
        {
            InitializeComponent();
            pago = null;
            inf = i;
            admin = ad;
           
           

            imp = inf.Importe;
            string hoy = DateTime.Now.ToString("dd/MM/yyyy");
            string vencimiento = inf.darFechaVencimiento();

            DateTime fechaHoy = Convert.ToDateTime(hoy);
            DateTime fechaVencimiento = Convert.ToDateTime(vencimiento);

            TimeSpan diferenciaFechas = fechaVencimiento - fechaHoy;

            int diferencia = diferenciaFechas.Days;

            nroPago = (admin.darListaPagos().Count()) + 1;

            if (inf.darGravedad() == "Leve")
            {
                if (diferencia >=20)
                {
                    imp = imp - ((imp / 100) * 25);
                }
                else if (diferencia >= 10)
                {
                    imp = imp - ((imp / 100) * 15);
                }
            }
            else if ((inf.darGravedad() == "Grave") && (diferencia >=25))
            {
                imp = imp - ((imp / 100) * 20);
            }

            textFecha.Text = hoy;
            textNro.Text = inf.NroInfraccion.ToString();
            textDominio.Text = inf.Dominio;
            textDni.Text = inf.darDni().ToString();
            textTitular.Text = inf.darNombreApellido();
            textTipo.Text = inf.darGravedad();
            textImporte.Text = imp.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pago = new Pago(inf.NroInfraccion, nroPago, imp, inf.darGravedad(), inf.darDni(), inf.darNombreApellido(), inf.Dominio, DateTime.Now.ToString("dd/MM/yyyy"));
            inf.pagar();
            this.Close();
        }

        public  Pago darPago()
        {
            return this.pago;
        }
    }
}
