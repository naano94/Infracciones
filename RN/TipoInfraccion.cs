using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class TipoInfraccion
    {
        private string codTipoInfraccion;
        private float valor;
        private string categoria;
        private string nombre;
  
        public TipoInfraccion(string cod, float val,string cat, string nom)
        {
            this.codTipoInfraccion = cod;
            this.valor = val;
            this.categoria = cat;
            this.nombre = nom;
        }

        public string darCodInfraccion()
        {
            return this.codTipoInfraccion;
        }

        public float Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        public string Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            return "Código: " + this.codTipoInfraccion + " - Nombre: " + this.nombre + " - Categoria: " + this.categoria + " - Valor: " + this.valor;
        }

        public void guardarseEnBase()
        {
            ArrayList datosTipoInfraccion = this.algebraRelacional();
            Datos.GuardarTipoInfraccion(datosTipoInfraccion);
        }
        public void eliminarTipoInfraccion()
        {
            Datos.EliminarTipoInfraccion(this.codTipoInfraccion);
        }

        public ArrayList algebraRelacional()
        {
            ArrayList data = new ArrayList();

            data.Add(this.codTipoInfraccion);
            data.Add(this.valor);
            data.Add(this.categoria);
            data.Add(this.nombre);           

            return data;
        }

        public static List<TipoInfraccion> TraerDataTipoInfracciones()
        {
            List<TipoInfraccion> listaTipoInfracciones = new List<TipoInfraccion>();
            TipoInfraccion ti;

            string cod,cat,nom;
            float imp;


            ArrayList dataInf = Datos.TraerTipoInfracciones();

            for (int i = 0; i < dataInf.Count; i = i + 4)
            {
                cod = dataInf[i].ToString();
                imp = float.Parse(dataInf[i + 1].ToString());
                cat = dataInf[i + 2].ToString();
                nom = dataInf[i + 3].ToString();
                
                ti = new TipoInfraccion(cod, imp, cat, nom);
                listaTipoInfracciones.Add(ti);

            }

            return listaTipoInfracciones;
        }
    }
}
