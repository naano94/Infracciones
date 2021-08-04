using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class Pago
    {
        private string fecha;
        private int nroPago;
        private float importe;
        private int nroInfraccion;
        private string tipoinf;
        private int dni;
        private string nombreTitular;
        private string dominio;

        public Pago(int ninf,int num,float imp,string tip,int dn,string nya,string dom,string f)
        {
            this.fecha = f;
            this.nroPago = num;
            this.importe = imp;
            this.nroInfraccion = ninf;
            this.tipoinf = tip;
            this.dni = dn;
            this.nombreTitular = nya;
            this.dominio = dom;
        }

        public override string ToString()
        {
            return "N° de Pago: " + this.nroPago + " - Fecha: " + this.fecha + " - Importe: " + this.importe + " - N° Infracción: " + this.nroInfraccion + " - Tipo de Infraccion: " + this.tipoinf + " - Dni Titular: " + this.dni + " - Titular: " + this.nombreTitular + " - Dominio: " + this.dominio;
        }
        public int NroPago
        {
            get { return this.nroPago; }
            set { this.nroPago = value; }
        }
        public float Importe
        {
            get { return this.importe; }
            set { this.importe = value; }
        }

        public string darFecha()
        {
            return this.fecha;
        }

        public int darNroInfraccion()
        {
            return this.nroInfraccion;
        }

        public string DarNombreTitutlar()
        {
            return this.nombreTitular;
        }

        public string DarDominio()
        {
            return this.dominio;
        }

        public int darDniTitular()
        {
            return this.dni;
        }

        public string DarTipoInfraccion()
        {
            return this.tipoinf;
        }

        public void guardarseEnBase()
        {
            ArrayList datosInfraccion = this.algebraRelacional();
            Datos.GuardarPago(datosInfraccion);
        }
        
        public ArrayList algebraRelacional()
        {
            ArrayList data = new ArrayList();

            data.Add(this.nroPago);
            data.Add(this.fecha);
            data.Add(this.importe);
            data.Add(this.nroInfraccion);
            data.Add(this.tipoinf);
            data.Add(this.dni);
            data.Add(this.nombreTitular);
            data.Add(this.dominio);           
            
            return data;
        }

        public static List<Pago> TraerDataPagos()
        {
            List<Pago> listaPagos = new List<Pago>();
            Pago pago;

            int num, numi,dn;
            string fech,tipo,nom,dom;
            float imp;


            ArrayList dataPago = Datos.TraerPagos();

            for (int i = 0; i < dataPago.Count; i = i + 8)
            {
                num = int.Parse(dataPago[i].ToString());
                fech = dataPago[i + 1].ToString();
                imp = float.Parse(dataPago[i + 2].ToString());
                numi = int.Parse(dataPago[i + 3].ToString());
                tipo = dataPago[i + 4].ToString();
                dn= int.Parse(dataPago[i + 5].ToString());
                nom = dataPago[i + 6].ToString();
                dom = dataPago[i + 7].ToString();
                
                pago = new Pago(numi,num, imp, tipo, dn,nom, dom,fech);
                listaPagos.Add(pago);
            }

            return listaPagos;
        }
    }
}
