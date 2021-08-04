using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class Infraccion
    {
        private int nroInfraccion;
        private string codTipoInfraccion;
        private string descripcion;
        private float importe;
        private string dominio;
        private string fecha;
        private string fechavencimiento;
        private string paga;
        private string gravedad;
        private string marca;
        private string modelo;
        private int dni;
        private string nya;

        public Infraccion (int num,string cod,string desc,float imp,string dom, string mar,string mod,int dn,string na,string f,string fv, string str,string str2)
        {
            this.nroInfraccion = num;
            this.codTipoInfraccion = cod;
            this.dominio = dom;
            this.dni = dn;
            this.descripcion = desc;
            this.importe = imp;            
            this.marca = mar;
            this.modelo = mod;            
            this.nya = na;
            this.fecha = f;
            this.fechavencimiento = fv;
            this.paga = str2;
            this.gravedad = str;
        }

        public int NroInfraccion
        {
            get { return this.nroInfraccion; }
            set { this.nroInfraccion = value; }
        }

        public string CodTipoInfraccion
        {
            get { return this.codTipoInfraccion; }
            set { this.codTipoInfraccion = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public float Importe
        {
            get { return this.importe; }
            set { this.importe = value; }
        }

        public string Dominio
        {
            get { return this.dominio; }
            set { this.dominio = value; }
        }

        public string darFecha()
        {
            return this.fecha;
        }

        public string darPago()
        {
            return this.paga;
        }

        public string darFechaVencimiento()
        {
            return this.fechavencimiento;
        }
        public void pagar()
        {
            Datos.AbonarInfraccion(this.nroInfraccion);
            this.paga = "Abonada";
        }

        public string darGravedad()
        {
            return this.gravedad;
        }

        public string darMarca()
        {
            return this.marca;
        }

        public string darModelo()
        {
            return this.modelo;
        }

        public int darDni()
        {
            return this.dni;
        }

        public string darNombreApellido()
        {
            return this.nya;
        }

        public override string ToString()
        {
            return "Infracción N°: " + nroInfraccion + " - Tipo de Infracción: " + this.gravedad + " - Dominio: " + this.dominio + " - Marca: " + this.marca + " - Modelo: " + this.modelo + " - Importe: " + this.importe + " - Fecha: " + this.fecha + " - Vencimiento: " + this.fechavencimiento + " - Estado: " + this.paga + " - Descripcion: " + this.descripcion;
        }

        
        public void guardarseEnBase()
        {
            ArrayList datosInfraccion = this.algebraRelacional();
            Datos.GuardarInfraccion(datosInfraccion);
        }
        public void eliminarInfraccion()
        {
            string str = this.nroInfraccion.ToString();
            Datos.EliminarInfraccion(str);
        }

        public ArrayList algebraRelacional()
        {
            ArrayList data = new ArrayList();

            data.Add(this.nroInfraccion);
            data.Add(this.codTipoInfraccion);
            data.Add(this.descripcion);
            data.Add(this.importe);
            data.Add(this.dominio);
            data.Add(this.fecha);
            data.Add(this.fechavencimiento);
            data.Add(this.paga);
            data.Add(this.gravedad);
            data.Add(this.marca);
            data.Add(this.modelo);
            data.Add(this.dni);
            data.Add(this.nya);

            return data;
        }

        public static List<Infraccion> TraerDataInfracciones()
        {
            List<Infraccion> listaInfracciones = new List<Infraccion>();
            Infraccion inf;

            int num,dn;
            string cod,desc,dom,mar,mod,na,f,fv,str,str2;
            float imp;
            

            ArrayList dataInf = Datos.TraerInfracciones();

            for (int i = 0; i < dataInf.Count; i = i + 13)
            {
                num = int.Parse(dataInf[i].ToString());
                cod = dataInf[i + 1].ToString();
                desc = dataInf[i + 2].ToString();
                imp = float.Parse(dataInf[i + 3].ToString());
                dom = dataInf[i + 4].ToString();
                f = dataInf[i + 5].ToString();
                fv = dataInf[i + 6].ToString();
                str2 = dataInf[i + 7].ToString();
                str = dataInf[i + 8].ToString();
                mar = dataInf[i + 9].ToString();
                mod = dataInf[i + 10].ToString();
                dn = int.Parse(dataInf[i + 11].ToString());
                na = dataInf[i + 12].ToString();

                inf = new Infraccion(num,cod,desc,imp,dom,mar,mod,dn,na,f,fv,str,str2);
                listaInfracciones.Add(inf);

            }

            return listaInfracciones;
        }
        
    }
}
