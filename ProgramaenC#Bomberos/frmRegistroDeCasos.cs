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
    public partial class frmRegistroDeCasos : Form
    {
        //private Dictionary<string, List<string>> localidadesCodigosPostales = new Dictionary<string, List<string>>();

        private string cadenaConexion ;
        frmHerramienta formHerramienta;
        DireccionBD direccionBD = new DireccionBD();
        // Declaración e inicialización de la lista para almacenar las herramientas seleccionadas con sus cantidades
        private List<string> herramientasSeleccionadas = new List<string>();
        private Dictionary<string, int> herramientasConCantidad = new Dictionary<string, int>();

        public frmRegistroDeCasos()
        {
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();
            CargarCasos();
            CargarLocalidades();
            CargarHerramientas();
        }

        
        //Metodo para mostrar los casos registrados 
        private void CargarCasos()
        {
            try
            {
                // Crea una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    // Abre la conexión
                    connection.Open();

                    // Crea un SqlDataAdapter para la vista
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM vwMostrarCasos", connection);

                    // Crea un DataTable para almacenar los datos
                    DataTable table = new DataTable();

                    // Llena el DataTable con los datos de la vista
                    adapter.Fill(table);

                    // Enlaza el DataTable a la DataGridView
                    dgvCasos.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si algo salió mal
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Cargar Herramientas
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
        //-------------------------------------------------
        private void btnAgregarCaso_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcionCaso = txtDescripcionCaso.Text;
                string direccionCaso = txtDireccionCaso.Text;
                string tipoCaso = cbTipoCaso.Text;
                string nombreLocalidad = cBoxLocalidad.Text;

                if (string.IsNullOrEmpty(descripcionCaso) ||
                    string.IsNullOrEmpty(direccionCaso) ||
                    string.IsNullOrEmpty(tipoCaso) ||
                    string.IsNullOrEmpty(nombreLocalidad))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string herramientas = string.Join(", ", herramientasSeleccionadas);

                if (string.IsNullOrEmpty(herramientas))
                {
                    MessageBox.Show("Por favor, seleccione al menos una herramienta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idLocalidad = ObtenerIdLocalidad(nombreLocalidad);

                if (idLocalidad != -1)
                {
                    InsertarCaso(descripcionCaso, direccionCaso, tipoCaso, herramientas, idLocalidad);
                    MessageBox.Show("Caso insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La localidad seleccionada no es válida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el caso: " + ex.Message);
            }

            txtDescripcionCaso.Text = string.Empty;
            txtDireccionCaso.Text = string.Empty;
            cBoxLocalidad.SelectedItem = null;
            cbTipoCaso.SelectedItem = null;
            herramientasSeleccionadas.Clear();
            herramientasConCantidad.Clear();
            lsbxListaHerramientas.ClearSelected();
            CargarCasos();
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

        private void InsertarCaso(string descripcionCaso, string direccionCaso, string tipoCaso, string herramientas, int idLocalidades)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                using (SqlCommand command = new SqlCommand("spInsertarCaso", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

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

        private void btnNuevaHerramienta_Click(object sender, EventArgs e)
        {
            formHerramienta = new frmHerramienta();
            this.Hide();
            DialogResult result = formHerramienta.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                formHerramienta.Close();
                CargarHerramientas();
                this.Show();
            }
        }
        
        private void lsbxListaHerramientas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lista para almacenar las nuevas selecciones
            List<string> nuevasSelecciones = new List<string>();

            // Iterar sobre cada elemento seleccionado en el ListBox
            foreach (string herramienta in lsbxListaHerramientas.SelectedItems)
            {
                // Verificar si la herramienta ya fue seleccionada anteriormente
                if (!herramientasConCantidad.ContainsKey(herramienta))
                {
                    nuevasSelecciones.Add(herramienta);
                }
            }

            // Abrir el formulario para cada nueva herramienta seleccionada
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

            // Actualizar la lista de herramientas seleccionadas
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