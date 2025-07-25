using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaBSPC
{
    public partial class frmModificaionDeCaso : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet dataSet;
        DireccionBD direccionBD = new DireccionBD();

        string cadenaConexion;

        // Diccionario para almacenar las herramientas seleccionadas y sus cantidades
        private Dictionary<string, int> herramientasConCantidad = new Dictionary<string, int>();

        // Declaración e inicialización de la lista para almacenar las herramientas seleccionadas con sus cantidades
        private List<string> herramientasSeleccionadas = new List<string>();

        public frmModificaionDeCaso()
        {
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();
            CargarLocalidades();
            CargarInformacion();
            CargarHerramientas();
        }

        public void CargarLocalidades()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                using (SqlCommand command = new SqlCommand("SELECT Localidad FROM vwLocalidades ORDER BY Localidad ASC", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string localidad = reader["Localidad"].ToString();
                            cBoxLocalidad.Items.Add(localidad);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autocompletar las localidades: " + ex.Message);
            }
        }

        private void CargarInformacion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                // Consulta SQL para seleccionar los datos de la tabla
                string consulta = "SELECT * FROM vwModificarCaso ORDER BY Fecha DESC";
                adaptador = new SqlDataAdapter(consulta, conexion);
                dataSet = new DataSet();

                // Llenar el DataGridView con los datos de la tabla
                adaptador.Fill(dataSet, "vwModificarCaso");
                dgvMuestra.DataSource = dataSet.Tables["vwModificarCaso"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar informacion: " + ex);
            }
        }

        private void CargarHerramientas()
        {
            // Defincición de la consulta SQL
            string query = "SELECT nombreInventario FROM Inventario ORDER BY nombreInventario";

            // Establece la conexión y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Limpia el ListBox antes de llenarlo
                    lsbxListaHerramientas.Items.Clear();

                    // Lee los datos y los agrega al ListBox
                    while (reader.Read())
                    {
                        lsbxListaHerramientas.Items.Add(reader["nombreInventario"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                }
            }
        }
        private void btnModificarCaso_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles del formulario
                long idCaso = long.Parse(txtClaveCaso.Text);
                string descripcionCaso = txtDescripcionCaso.Text;
                string direccionCaso = txtDireccionCaso.Text;
                string tipoCaso = cbTipoCaso.Text;
                string nombreLocalidad = cBoxLocalidad.Text;

                // Validar que ningún campo esté vacío
                if (string.IsNullOrEmpty(descripcionCaso) ||
                    string.IsNullOrEmpty(direccionCaso) ||
                    string.IsNullOrEmpty(tipoCaso) ||
                    string.IsNullOrEmpty(nombreLocalidad))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener las herramientas seleccionadas con cantidades
                string herramientas = string.Join(", ", herramientasSeleccionadas);

                // Validar que al menos una herramienta esté seleccionada
                if (string.IsNullOrEmpty(herramientas))
                {
                    MessageBox.Show("Por favor, seleccione al menos una herramienta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el ID de la localidad utilizando el procedimiento almacenado
                int idLocalidad = ObtenerIdLocalidad(nombreLocalidad);

                // Verificar que el ID de la localidad obtenido sea válido
                if (idLocalidad != -1)
                {
                    // Llamar al procedimiento almacenado para modificar el caso
                    ModificarCaso(idCaso, descripcionCaso, direccionCaso, tipoCaso, herramientas, idLocalidad);
                    MessageBox.Show("Caso modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La localidad seleccionada no es válida.");
                }

                txtDescripcionCaso.Text = string.Empty;
                txtDireccionCaso.Text = string.Empty;
                cBoxLocalidad.SelectedItem = null;
                cbTipoCaso.SelectedItem = null;
                txtClaveCaso.Text = string.Empty;
                herramientasSeleccionadas.Clear();
                herramientasConCantidad.Clear();
                lsbxListaHerramientas.ClearSelected();
                CargarInformacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el caso: " + ex.Message);
            }
        }
        private void ModificarCaso(long idCaso, string descripcionCaso, string direccionCaso, string tipoCaso, string herramientas, int idLocalidades)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                using (SqlCommand command = new SqlCommand("spModificarCaso", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Definir los parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@idCaso", idCaso);
                    command.Parameters.AddWithValue("@descripcionCaso", descripcionCaso);
                    command.Parameters.AddWithValue("@direccionCaso", direccionCaso);
                    command.Parameters.AddWithValue("@tipoCaso", tipoCaso);
                    command.Parameters.AddWithValue("@herramientas", herramientas);
                    command.Parameters.AddWithValue("@idLocalidades", idLocalidades);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ObtenerIdLocalidad(string nombreLocalidad)
        {
            int idLocalidad = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                using (SqlCommand command = new SqlCommand("spObtenerIdLocalidad", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombreLocalidad", nombreLocalidad);
                    SqlParameter parameter = new SqlParameter("@idLocalidad", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parameter);
                    connection.Open();
                    command.ExecuteNonQuery();
                    idLocalidad = (int)command.Parameters["@idLocalidad"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la localidad: " + ex.Message);
            }

            return idLocalidad;
        }

        private void lsbxListaHerramientas_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> nuevasSelecciones = new List<string>();
            foreach (string herramienta in lsbxListaHerramientas.SelectedItems)
            {
                if (!herramientasConCantidad.ContainsKey(herramienta))
                {
                    nuevasSelecciones.Add(herramienta);
                }
            }
            foreach (string herramienta in nuevasSelecciones)
            {
                using (frmCantidadHerramientas frm = new frmCantidadHerramientas(herramienta))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        herramientasConCantidad[herramienta] = frm.Cantidad;
                    }
                }
            }
            ActualizarHerramientasSeleccionadas();
        }
        private void ActualizarHerramientasSeleccionadas()
        {
            herramientasSeleccionadas.Clear();
            foreach (var item in herramientasConCantidad)
            {
                herramientasSeleccionadas.Add($"{item.Key} ({item.Value})");
            }
        }
    }
}
