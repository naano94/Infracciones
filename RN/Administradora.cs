using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class Administradora
    {
        private List<Infraccion> infracciones;
        private List<Pago> pagos;
        private List<TipoInfraccion> tipoInfracciones;
        private List<Titular> titulares;
        private List<Vehiculo> vehiculos;

        public Administradora()
        {
            this.infracciones = new List<Infraccion>();
            this.pagos = new List<Pago>();
            this.tipoInfracciones = new List<TipoInfraccion>();
            this.titulares = new List<Titular>();
            this.vehiculos = new List<Vehiculo>();
        }

        public static void PonerPath(string x)
        {
            Datos.PonerLugarBase(x);
        }

        public List<Infraccion> Infracciones
        {
            get { return this.infracciones; }
            set { this.infracciones = value; }
        }

        public List<Pago> Pagos
        {
            get { return this.pagos; }
            set { this.pagos = value; }
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
            set { this.vehiculos = value; }
        }

        public List<Titular> Titulares
        {
            get { return this.titulares; }
            set { this.titulares = value; }
        }

        public List<TipoInfraccion> TipoInfracciones
        {
            get { return this.tipoInfracciones; }
            set { this.tipoInfracciones = value; }
        }

        public void AgregarInfraccion(Infraccion i)
        {
            i.guardarseEnBase();
            this.infracciones.Add(i);
        }

        public void AgregarPago(Pago p)
        {
            p.guardarseEnBase();
            this.pagos.Add(p);
        }

        public void AgregarTipoInfraccion(TipoInfraccion ti)
        {
            ti.guardarseEnBase();
            this.tipoInfracciones.Add(ti);
        }

        public void AgregarTitular(Titular t)
        {
            t.guardarseEnBase();
            this.titulares.Add(t);
        }

        public void AgregarVehiculo(Vehiculo v)
        {
            v.guardarseEnBase();
            this.vehiculos.Add(v);
        }

        public void RemoverInfraccion(Infraccion i)
        {
            i.eliminarInfraccion();
            this.infracciones.Remove(i);
        }

        public void RemoverTipoInfraccion(TipoInfraccion ti)
        {
            ti.eliminarTipoInfraccion();
            this.tipoInfracciones.Remove(ti);
        }

        public void RemoverTitular(Titular t)
        {
            t.eliminarTitular();
            this.titulares.Remove(t);
        }

        public void RemoverVehiculo(Vehiculo v)
        {
            v.eliminarVehiculo();
            this.vehiculos.Remove(v);
        }

        public List<Infraccion> darListaInfracciones()
        {
            return this.infracciones;
        }

        public List<Pago> darListaPagos()
        {
            return this.pagos;
        }

        public List<TipoInfraccion> darListaTipoInfracciones()
        {
            return this.tipoInfracciones;
        }

        public List<Titular> darListaTitulares()
        {
            return this.titulares;
        }

        public List<Vehiculo> darListaVehiculos()
        {
            return this.vehiculos;
        }

        public Vehiculo buscarVehiculo(string dom)
        {
            Vehiculo v = null;

            for(int i=0;i<vehiculos.Count();i++)
            {
                if(vehiculos[i].Dominio==dom)
                {
                    v = vehiculos[i];
                    break;
                }
            }

            return v;
        }

        public Titular buscarTitular(int dn)
        {
            Titular t = null;

            for (int i = 0; i < titulares.Count(); i++)
            {
                if (titulares[i].Dni == dn)
                {
                    t = titulares[i];
                    break;
                }
            }

            return t;
        }
    }
}
