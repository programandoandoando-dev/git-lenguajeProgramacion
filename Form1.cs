using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SystemVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CONX"].ConnectionString);

            SqlCommand cmd = new SqlCommand("PR_LISTADOPRODUCTOS", cnx);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgListadoProductos.DataSource = dt;


            //Configuramos el ancho de las columnas de la grilla
            dtgListadoProductos.Columns[0].Width = 100;
            dtgListadoProductos.Columns[1].Width = 300;
            dtgListadoProductos.Columns[2].Width = 125;
            dtgListadoProductos.Columns[3].Width = 125;
        }
    }
}
