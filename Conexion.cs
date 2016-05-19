using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control_Llamadas
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Control_Llamadas;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }



        public string insertar(string usuario, string descripcion, string observaciones, string fecha, string horaInicio, string horaFin, string tiempoTotal, int idDia)
        {
            string salida = "Si se insertó";
            try
            {
                cmd = new SqlCommand("Insert into Llamadas(Usuario,Descripcion,Observaciones,Fecha,Hora_Inicio,Hora_Fin,Tiempo_Total,ID_Dia) values('" + usuario + "','" + descripcion + "','" + observaciones + "','" + fecha + "' ,'" + horaInicio + "', '" + horaFin + "','" + tiempoTotal + "'," + idDia + " )", cn);
                //cmd.Parameters.AddWithValue("@Auxiliar");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }
            return salida;
        }



        public int MaximoID()
        {
            int MaxID = 0;
            cmd = new SqlCommand("SELECT MAX(ID_Llamada) from Llamadas;", cn);
            if (!DBNull.Value.Equals(cmd.ExecuteScalar()))
            {
                MaxID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return MaxID;
        }

    }
}
