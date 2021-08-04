using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class Vehiculo
    {
        private string dominio;
        private string marca;
        private string modelo;
        private int dniTitular;
        private string tipo;

        public Vehiculo(string dom,string marc,string mod,int dni,string tip)
        {
            this.dominio = dom;
            this.marca = marc;
            this.modelo = mod;
            this.dniTitular = dni;
            this.tipo = tip;
        }

        public string Dominio
        {
            get { return this.dominio; }
            set { this.dominio = value; }
        }
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public int DniTitular
        {
            get { return this.dniTitular; }
            set { this.dniTitular = value; }
        }

        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public override string ToString()
        {
            return "Marca: " + this.marca + " - Modelo: " + this.modelo + " - Dominio: " + this.dominio + " - Tipo: " + this.tipo + " - Dni Titular: " + this.dniTitular;
        }

        public void guardarseEnBase()
        {
            ArrayList datosVehiculos = this.algebraRelacional();
            Datos.GuardarVehiculo(datosVehiculos);
        }
        public void eliminarVehiculo()
        {
            Datos.EliminarVehiculo(this.Dominio);
        }

        public ArrayList algebraRelacional()
        {
            ArrayList data = new ArrayList();

            data.Add(this.dominio);
            data.Add(this.dniTitular);
            data.Add(this.marca);
            data.Add(this.modelo);
            data.Add(this.tipo);

            return data;
        }

        public static List<Vehiculo> TraerDataVehiculos()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            Vehiculo v;

            string dom, marca, mod,tipo;
            int dn;


            ArrayList dataVeh = Datos.TraerVehiculos();

            for (int i = 0; i < dataVeh.Count; i = i + 5)
            {
                dom = dataVeh[i].ToString();
                dn = int.Parse(dataVeh[i+1].ToString());
                marca = dataVeh[i + 2].ToString();
                mod = dataVeh[i + 3].ToString();
                tipo = dataVeh[i + 4].ToString();

                v = new Vehiculo(dom,marca,mod,dn,tipo);
                listaVehiculos.Add(v);

            }

            return listaVehiculos;
        }
    }
}
