using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// El tuto para conectar SQL con Visual C#: https://www.youtube.com/watch?v=CmWleAx4CFw
// ejemplo conexión: https://www.dotnetperls.com/sqldataadapter

namespace DashboardAccidentes.Negocio
{
    public class DAO_SQL
    {
        public DataTable RealizarConsulta(string query)
        {
            //string constr = @"";
            string constr = @"Data Source=JOSENA-PC;Initial Catalog=AccidentesBD;Integrated Security=True";
            //string constr = @"Data Source=DESKTOP-DAVIDCR\SQLEXPRESS;Initial Catalog=AccidentesBD;Integrated Security=True";
            //string constr = @"STRING DE CONEXION PARA LAPTOP DE DAVID";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
