using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaBSPC
{
    public partial class frmUltimosCasosEstadistica : Form
    {
        DireccionBD direccionBD = new DireccionBD();
        SqlConnection con = new SqlConnection();
        private string cadenaConexion;
        private List<string> casosSeleccionados = new List<string>();
        public frmUltimosCasosEstadistica()
        {
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();
        }

        private void frmUltimosCasosEstadistica_Load(object sender, EventArgs e)
        {

            con.ConnectionString = cadenaConexion;
            con.Open();



            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            string query = "ContarAccidentesPorTipo2"; // Nombre del procedimiento almacenado

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                                string tipoAccidente = reader["tipoCaso"].ToString();
                                int totalAccidentes = Convert.ToInt32(reader["TotalAccidentes"]);

                                chart1.Series[0].Points.AddXY(tipoAccidente, totalAccidentes);

                        }
                    }
                }
            }
        }
       


        private void rbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = false;
        }

    
    }
}
