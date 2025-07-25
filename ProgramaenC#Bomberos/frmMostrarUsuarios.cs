using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBSPC
{
    public partial class frmMostrarUsuarios : Form
    {
        DireccionBD direccionBD = new DireccionBD();
        private string cadenaConexion;
        public frmMostrarUsuarios()
        {
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();            
        }

        private void frmMostrarUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

        }

        private void CargarUsuarios()
        {
            try
            {
                string consultaSql = "SELECT * FROM vwMostrarUsuarios";

                // Crea una conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Crea un adaptador de datos para ejecutar la consulta y llenar un DataTable
                    SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, conexion);
                    DataTable tablaDatos = new DataTable();

                    // Abre la conexión y llena el DataTable con los resultados de la consulta
                    conexion.Open();
                    adaptador.Fill(tablaDatos);

                    // Asigna el DataTable como origen de datos del DataGridView
                    dgvMuestra.DataSource = tablaDatos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
