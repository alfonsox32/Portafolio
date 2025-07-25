using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBSPC
{
    public partial class frmBusquedaAvanzadaCasos : Form
    {
        private SqlConnection conexion;
        DireccionBD direccionBD = new DireccionBD();
        private string cadenaConexion;

        public frmBusquedaAvanzadaCasos()
        {
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            InitializeComponent();
            CargarLocalidades();
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Hide();
            lblFecha.Hide();
            cbIntervencion.Hide();
            lblIntervencion.Hide();
            cbCP.Hide();
            lblCP.Hide();
        }

        // Eventos CheckedChanged
        private void chbFecha_CheckedChanged(object sender, EventArgs e)
        {
            MostrarFiltros();
        }

        private void chbIntervencion_CheckedChanged(object sender, EventArgs e)
        {
            MostrarFiltros();
        }

        private void chbCP_CheckedChanged(object sender, EventArgs e)
        {
            MostrarFiltros();
        }

        private void MostrarFiltros()
        {
            dtpFecha.Visible = chbFecha.Checked;
            lblFecha.Visible = chbFecha.Checked;
            rbAntiguo.Visible = chbFecha.Checked;
            rbReciente.Visible = chbFecha.Checked;
            cbIntervencion.Visible = chbIntervencion.Checked;
            lblIntervencion.Visible = chbIntervencion.Checked;
            cbCP.Visible = chbCP.Checked;
            lblCP.Visible = chbCP.Checked;
        }

        private void frmBusquedaAvanzadaCasos_Load(object sender, EventArgs e)
        {
            CargarCasos();
        }

        private void rbReciente_CheckedChanged(object sender, EventArgs e)
        {
            dgvMuestra.Sort(dgvMuestra.Columns["Fecha"], ListSortDirection.Ascending);
        }

        private void rbAntiguo_CheckedChanged(object sender, EventArgs e)
        {
            dgvMuestra.Sort(dgvMuestra.Columns["Fecha"], ListSortDirection.Descending);
        }

        private void dgvMuestra_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosSeleccionados();
        }

        private void dgvMuestra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosSeleccionados();
        }

        private void CargarDatosSeleccionados()
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
                else
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCaso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtHerramientas.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFecha.Text = string.Empty;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DataTable dt = ConvertDataGridViewToDataTable();
            frmReporte reporte = new frmReporte(dt);
            reporte.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chbCP.Checked && chbFecha.Checked && chbIntervencion.Checked)
            {
                CargarCasosPorTipoFechaLocalidad(cbIntervencion.Text, dtpFecha.Value, cbCP.Text);
            }
            else if (chbCP.Checked && chbFecha.Checked)
            {
                CargarCasosPorFechaLocalidad(dtpFecha.Value, cbCP.Text);
            }
            else if (chbCP.Checked && chbIntervencion.Checked)
            {
                CargarCasosPorTipoLocalidad(cbIntervencion.Text, cbCP.Text);
            }
            else if (chbFecha.Checked && chbIntervencion.Checked)
            {
                CargarCasosPorFechaYTipo(dtpFecha.Value, cbIntervencion.Text);
            }
            else if (chbCP.Checked)
            {
                CargarCasosPorLocalidad(cbCP.Text);
            }
            else if (chbFecha.Checked)
            {
                CargarCasosPorFecha(dtpFecha.Value);
            }
            else if (chbIntervencion.Checked)
            {
                CargarCasosPorTipo(cbIntervencion.Text);
            }
            else
            {
                CargarCasos();
            }
        }

        private void EjecutarConsulta(string storedProcedure, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comando = new SqlCommand(storedProcedure, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaDatos = new DataTable();

                    conexion.Open();
                    adaptador.Fill(tablaDatos);

                    dgvMuestra.DataSource = tablaDatos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCasos()
        {
            EjecutarConsulta("spObtenerCasos");
        }

        private void CargarCasosPorFecha(DateTime fechaSeleccionada)
        {
            EjecutarConsulta("spObtenerCasosPorFecha", new SqlParameter("@FechaSeleccionada", fechaSeleccionada.Date));
        }

        private void CargarCasosPorFechaYTipo(DateTime fechaSeleccionada, string tipoCaso)
        {
            EjecutarConsulta("spObtenerCasosPorFechaYTipo",
                new SqlParameter("@FechaSeleccionada", fechaSeleccionada.Date),
                new SqlParameter("@TipoCaso", tipoCaso));
        }

        private void CargarCasosPorTipo(string tipoCaso)
        {
            EjecutarConsulta("spObtenerCasosPorTipo", new SqlParameter("@TipoCaso", tipoCaso));
        }

        private void CargarCasosPorLocalidad(string localidad)
        {
            EjecutarConsulta("spObtenerCasosPorLocalidad", new SqlParameter("@Localidad", localidad));
        }

        private void CargarCasosPorFechaLocalidad(DateTime fechaSeleccionada, string localidad)
        {
            EjecutarConsulta("spObtenerCasosPorFechaLocalidad",
                new SqlParameter("@FechaSeleccionada", fechaSeleccionada.Date),
                new SqlParameter("@Localidad", localidad));
        }

        private void CargarCasosPorTipoLocalidad(string tipoCaso, string localidad)
        {
            EjecutarConsulta("spObtenerCasosPorTipoLocalidad",
                new SqlParameter("@TipoCaso", tipoCaso),
                new SqlParameter("@Localidad", localidad));
        }

        private void CargarCasosPorTipoFechaLocalidad(string tipoCaso, DateTime fechaSeleccionada, string localidad)
        {
            EjecutarConsulta("spObtenerCasosPorTipoFechaLocalidad",
                new SqlParameter("@TipoCaso", tipoCaso),
                new SqlParameter("@FechaSeleccionada", fechaSeleccionada.Date),
                new SqlParameter("@Localidad", localidad));
        }

        private void CargarLocalidades()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comando = new SqlCommand("SELECT DISTINCT [Colonia/Ejido] FROM vwMostrarCasos2", conexion))
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        cbCP.Items.Add(reader["Colonia/Ejido"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar localidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertDataGridViewToDataTable()
        {
            DataTable dt = new DataTable();

            // Crear las columnas en el DataTable
            foreach (DataGridViewColumn column in dgvMuestra.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            // Agregar las filas en el DataTable
            foreach (DataGridViewRow row in dgvMuestra.Rows)
            {
                DataRow dtRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dtRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dtRow);
            }

            return dt;
        }
            
    }
}
