using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaTomadeDecisiones
{
    public class conexion
    {
        public DataTable getClientes()
        {
            DataTable dt = new DataTable();
            var connectionString = ConfigurationManager.ConnectionStrings[0].ToString();
            string queryString = "SELECT RUC, DENOMINACION, DUEDA FROM TABLA;";
            using (var connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(queryString, connectionString);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
