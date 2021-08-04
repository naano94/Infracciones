using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD;

namespace RN
{
    public class Usuario
    {
        protected string usuario;
        protected string contraseña;

        public Usuario(string nro, string ps)
        {
            this.usuario = nro;
            this.contraseña = ps;
        }
        public string getContraseña
        {
            get { return contraseña; }
        }
        public string getUsuario
        {
            get { return usuario; }
        }

        public static List<Usuario> TraerDataUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            string us, ps;

            ArrayList dataUsuario = Datos.TraerUsuarios();

            for (int i = 0; i < dataUsuario.Count; i = i + 2)
            {
                us = dataUsuario[i + 0].ToString();
                ps = dataUsuario[i + 1].ToString();

                Usuario u = new Usuario(us, ps);
                listaUsuarios.Add(u);
            }

            return listaUsuarios;
        }
    }
}
