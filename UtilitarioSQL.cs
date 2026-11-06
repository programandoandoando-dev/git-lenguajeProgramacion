using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemVentas
{
    internal class UtilitarioSQL
    {
        private static SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CONX"].ConnectionString);

        public static void ConsultaProcedure(string procedure,DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(procedure, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grilla.DataSource = dt;
        }
        
    }
}
