using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaTomadeDecisiones
{
    public class conexion
    {
        public static string GetConexion()
        {
            return ConfigurationManager.ConnectionStrings["dbCnx"].ConnectionString;
        }
    }
}
