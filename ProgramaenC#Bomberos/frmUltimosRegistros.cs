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

namespace SistemaBSPC
{
    public partial class frmUltimosRegistros : Form
    {
        private SqlConnection conexion;
        private string cadenaConexion ;
        DireccionBD direccionBD = new DireccionBD();
        public frmUltimosRegistros()
        {
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();
            conexion = new SqlConnection(cadenaConexion);
            
        }

        private void frmUltimosRegistros_Load(object sender, EventArgs e)
        {
            CargarCasos();
            
        }
        private void CargarCasos()
        {
            try
            {
                string consultaSql = "SELECT * FROM vwMostrarCasos ORDER BY Fecha DESC";

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
        private void dgvMuestra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMuestra.CurrentRow != null)
                {
                    DataGridViewRow row = dgvMuestra.CurrentRow;

                    txtCaso.Text = row.Cells[0].Value?.ToString();
                    txtDescripcion.Text = row.Cells[1].Value?.ToString();
                    txtHerramientas.Text = row.Cells[2].Value?.ToString();
                    txtCP.Text = row.Cells[3].Value?.ToString();
                    txtColonia.Text = row.Cells[4].Value?.ToString();
                    txtDireccion.Text = row.Cells[5].Value?.ToString();
                    txtFecha.Text = row.Cells[6].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
