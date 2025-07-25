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
    public partial class frmHerramienta : Form
    {
        string conexion;
        DireccionBD direccionBD = new DireccionBD();
        public frmHerramienta()
        {
            conexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();
            MostrarHerramientas();
        }

        private void AgregarHerramienta(string nombreInventario)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand("spAgregarHerramienta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreInventario", nombreInventario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Herramienta agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la herramienta: " + ex.Message);
                }
            }
        }

        private void MostrarHerramientas()
        {

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                string query = "SELECT * FROM vwHerramientas";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dgvMuestra.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar las herramientas: " + ex.Message);
                }
            }
        }

        private void ModificarHerramienta(int idInventario, string nombreInventario)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand("spModificarHerramienta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idInventario", idInventario);
                command.Parameters.AddWithValue("@nombreInventario", nombreInventario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Herramienta modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la herramienta: " + ex.Message);
                }
            }
        }

        private void EliminarHerramienta(int idInventario)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand("spEliminarHerramienta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idInventario", idInventario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Herramienta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la herramienta: " + ex.Message);
                }
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombreInventario = txtInsertarHerramienta.Text; 

            if (!string.IsNullOrWhiteSpace(nombreInventario))
            {
                AgregarHerramienta(nombreInventario);
                txtInsertarHerramienta.Text = string.Empty; 
                MostrarHerramientas(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para la herramienta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idInventario = int.Parse(txtModificarHerramientaClave.Text); 
            string nombreInventario = txtModificarHerramienta.Text;

            if (idInventario > 0 && !string.IsNullOrWhiteSpace(nombreInventario))
            {
                ModificarHerramienta(idInventario, nombreInventario);
                txtModificarHerramienta.Text = string.Empty;
                txtModificarHerramientaClave.Text = string.Empty;
                MostrarHerramientas(); 
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idInventario = int.Parse(txtEliminarHerramienta.Text); 
            if (idInventario > 0)
            {
                EliminarHerramienta(idInventario);
                txtEliminarHerramienta.Text = string.Empty;
                MostrarHerramientas(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
