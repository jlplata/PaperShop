using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerías para acceder al appconfig
using System.Configuration;
using System.Collections.Specialized;
//Librerías para acceder el cliente de la BD
using System.Data.SqlClient;

namespace PaperShop
{
    class Connection
    {
        public static bool ExecuteQuery(string qry, string msgDone = null, string msgError = "ERROR.")
        {
            //Variable para leer datos tipo sql
            SqlDataReader sqlDR = null;
            try
            {   
                //Extrae la configuración del appconfig
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                //Conecta a la BD
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                //Guarda el objeto o comando
                SqlCommand sqlCMD = new SqlCommand();
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexión al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexión
                sqlCNX.Open();
                //Asignamos ejecutado el comando al sqlDR
                sqlDR = sqlCMD.ExecuteReader();

                bool HasRows = sqlDR.HasRows;

                //Cerramos la conexión
                sqlCNX.Close();

                if (msgDone != null)
                {
                    MessageBox.Show(msgDone, "SI");
                }

                //Retornamos el objeto sqlDR
                return HasRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(msgError + " " + ex.Message.ToString(), "SI");
                //Retornamos el objeto sqlDR
                return false;
            }

        }

        public static SqlDataAdapter ExecuteQueryAdapter(string qry, string msgDone = null, string msgError = "ERROR.")
        {
            //Variable para el adaptador
            SqlDataAdapter sqlDA = null;
            try
            {
                //Extrae la configuración del appconfig
                string cadenaconexion = ConfigurationManager.AppSettings.Get("cadenaconexion");
                //Conecta a la BD
                SqlConnection sqlCNX = new SqlConnection(cadenaconexion);
                //Guarda el objeto o comando
                SqlCommand sqlCMD = new SqlCommand();
                //Asignamos la consulta al comando
                sqlCMD.CommandText = qry;
                //Asignamos la conexión al comando
                sqlCMD.Connection = sqlCNX;
                //Abrimos la conexión
                sqlCNX.Open();
                //Asignamos ejecutado el comando al sqlDR
                sqlDA = new SqlDataAdapter(sqlCMD);

                //Cerramos la conexión
                sqlCNX.Close();


                if (msgDone != null)
                {
                    MessageBox.Show(msgDone, "SI");
                }

                //Retornamos el objeto sqlDR
                return sqlDA;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(msgError + " " + ex.Message.ToString(), "SI");
                //Retornamos el objeto sqlDR
                return sqlDA;
            }

        }
    }
}
