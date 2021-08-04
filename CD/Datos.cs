using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace CD
{
    public class Datos
    {
        private static string StrCon;
        private static OleDbConnection con;
        private static OleDbCommand cmd;
        private static OleDbDataAdapter da;
        private static DataSet ds;
        
        public static void PonerLugarBase(string lugar)
        {
           
            StrCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + lugar + @"\Infracciones.mdb";

        }

        public static void GuardarInfraccion(ArrayList data)
        {
            
            int num = int.Parse(data[0].ToString());
            string cod = data[1].ToString();
            string desc = data[2].ToString();
            float imp = float.Parse(data[3].ToString());
            string dom = data[4].ToString();
            string fecha = data[5].ToString();
            string fvencimiento = data[6].ToString();
            string paga = data[7].ToString();
            string tipo = data[8].ToString();
            string marca = data[9].ToString();
            string modelo = data[10].ToString();
            int dn = int.Parse(data[11].ToString());
            string nom = data[12].ToString();
            

            string consulta = "INSERT INTO Infracciones values ('" + num.ToString() + "','" + cod +
                "','" + desc + "','" + imp.ToString() + "','" + dom + "','" + fecha + "','" + fvencimiento +
                "','" + paga + "','" + tipo + "','" + marca + "','" + modelo + "','" + dn.ToString() + "','" + nom + "');";
            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();

            }
        }

        public static void EliminarInfraccion(string cod)
        {
            string consulta = "DELETE * FROM Infracciones WHERE NroInfraccion = '" + cod + "';";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public static void AbonarInfraccion(int cod)
        {
            string consulta = "UPDATE Infracciones SET Paga='Abonada' WHERE NroInfraccion = " + cod + ";";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public static ArrayList TraerInfracciones()
        {
            ArrayList dataInfracciones = new ArrayList();
            string consulta = "SELECT * FROM Infracciones";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[4]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[5]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[6]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[7]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[8]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[9]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[10]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[11]);
                    dataInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[12]);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dataInfracciones;
        }

        public static void GuardarPago(ArrayList data)
        {

            int nroPago = int.Parse(data[0].ToString());
            string fecha = data[1].ToString();
            float imp = float.Parse(data[2].ToString());
            int nroInfraccion = int.Parse(data[3].ToString());
            string tipoinf = data[4].ToString();
            int dni = int.Parse(data[5].ToString());
            string nombreTitular = data[6].ToString();
            string dominio = data[7].ToString();

            string consulta = "INSERT INTO Pagos values ('" + nroPago.ToString() + "','" + fecha + "','" + imp.ToString() + "','" + nroInfraccion.ToString() + "','" + tipoinf + "','" + dni.ToString() + "','" + nombreTitular + "','" + dominio + "');";
            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();

            }
        }

        public static ArrayList TraerPagos()
        {
            ArrayList dataPagos = new ArrayList();
            string consulta = "SELECT * FROM Pagos";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[4]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[5]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[6]);
                    dataPagos.Add(ds.Tables[0].Rows[i].ItemArray[7]);                    
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dataPagos;
        }

        public static void GuardarTipoInfraccion(ArrayList data)
        {

            string cod = data[0].ToString();
            float imp = float.Parse(data[1].ToString());
            string cat = data[2].ToString();
            string nom = data[3].ToString();


            string consulta = "INSERT INTO TipoInfracciones values ('" + cod + "','" + imp +
                "','" + cat + "','" + nom + "');";
            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();

            }
        }

        public static void EliminarTipoInfraccion(string cod)
        {
            string consulta = "DELETE * FROM TipoInfracciones WHERE CodTipoInfraccion = '" + cod + "';";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public static ArrayList TraerTipoInfracciones()
        {
            ArrayList dataTipoInfracciones = new ArrayList();
            string consulta = "SELECT * FROM TipoInfracciones";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataTipoInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    dataTipoInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    dataTipoInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    dataTipoInfracciones.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dataTipoInfracciones;
        }

        public static void GuardarTitular(ArrayList data)
        {
            int dn = int.Parse(data[0].ToString());
            string nom = data[1].ToString();
            string ap = data[2].ToString();
            string dom = data[3].ToString();

            string consulta = "INSERT INTO Titulares values ('" + dn + "','" + nom + "','" + ap + "','" + dom + "');";
            
            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();

            }
        }

        public static void EliminarTitular(string cod)
        {
            string consulta = "DELETE * FROM Titulares WHERE Dni = '" + cod + "';";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public static ArrayList TraerTitulares()
        {
            ArrayList dataTitulares = new ArrayList();
            string consulta = "SELECT * FROM Titulares";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataTitulares.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    dataTitulares.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    dataTitulares.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    dataTitulares.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dataTitulares;
        }


        public static void GuardarVehiculo(ArrayList data)
        {
            string dom = data[0].ToString();
            int dn = int.Parse(data[1].ToString());
            string marca = data[2].ToString();
            string modelo = data[3].ToString();
            string tipo = data[4].ToString();

            string consulta = "INSERT INTO Vehiculos values ('" + dom + "','" + dn + "','" + marca + "','" + modelo + "','" + tipo + "');";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();

            }
        }

        public static void EliminarVehiculo(string cod)
        {
            string consulta = "DELETE * FROM Vehiculos WHERE Dominio = '" + cod + "';";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                cmd = new OleDbCommand(consulta, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public static ArrayList TraerVehiculos()
        {
            ArrayList dataVehiculos = new ArrayList();
            string consulta = "SELECT * FROM Vehiculos";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataVehiculos.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    dataVehiculos.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    dataVehiculos.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    dataVehiculos.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    dataVehiculos.Add(ds.Tables[0].Rows[i].ItemArray[4]);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dataVehiculos;
        }

        public static ArrayList TraerUsuarios()
        {
            ArrayList dataUsuarios = new ArrayList();
            string consulta = "SELECT * FROM Usuarios";

            try
            {
                con = new OleDbConnection(StrCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataUsuarios.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    dataUsuarios.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();


            }
            return dataUsuarios;
        }
    }
}
