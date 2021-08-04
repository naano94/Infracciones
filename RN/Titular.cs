using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class Titular
    {
        private int dni;
        private string nombre;
        private string apellido;
        private string domicilio;

        public Titular(int dn, string nom, string ap,string dom)
        {
            this.dni = dn;
            this.nombre = nom;
            this.apellido = ap;
            this.domicilio = dom;
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Domicilio
        {
            get { return this.domicilio; }
            set { this.domicilio = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Dni: " + this.dni;
        }

        public void guardarseEnBase()
        {
            ArrayList datosTitulares = this.algebraRelacional();
            Datos.GuardarTitular(datosTitulares);
        }
        public void eliminarTitular()
        {
            Datos.EliminarTitular(this.dni.ToString());
        }

        public ArrayList algebraRelacional()
        {
            ArrayList data = new ArrayList();

            data.Add(this.dni);
            data.Add(this.nombre);
            data.Add(this.apellido);
            data.Add(this.domicilio);

            return data;
        }

        public static List<Titular> TraerDataTitulares()
        {
            List<Titular> listaTitulares = new List<Titular>();
            Titular ti;

            string nom, ap, dom;
            int dn;


            ArrayList dataTit = Datos.TraerTitulares();

            for (int i = 0; i < dataTit.Count; i = i + 4)
            {
                dn = int.Parse(dataTit[i].ToString());
                nom = dataTit[i + 1].ToString();
                ap = dataTit[i + 2].ToString();
                dom = dataTit[i + 3].ToString();

                ti = new Titular(dn, nom, ap, dom);
                listaTitulares.Add(ti);

            }

            return listaTitulares;
        }
    }
}
