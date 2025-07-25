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
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaBSPC
{
    public partial class frmConsultaAvanzadaEstadistica : Form
    {
        DireccionBD direccionBD = new DireccionBD();
        SqlConnection con = new SqlConnection();
        private string cadenaConexion;
        public frmConsultaAvanzadaEstadistica()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "   dd 'de' MMMM, yyyy";
        }

        public void ObtenerDatos(DateTime fechaSeleccionada)
        {
            try
            {
                cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand("ObtenerDatosPorFecha123", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    // Añadir parámetro
                    comando.Parameters.AddWithValue("@FechaSeleccionada", fechaSeleccionada);

                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string tipoAccidente = reader["tipoCaso"].ToString();
                        int totalAccidentes = Convert.ToInt32(reader["TotalAccidentes"]);
                        try
                        {
                            chart4.Refresh();
                            chart4.Update();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        chart4.Series[0].Points.AddXY(tipoAccidente, totalAccidentes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                chart4.Series[0].Points.Clear();

                if (radioButton1.Checked==true)
                {
                    cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
                    string query = "ContarAccidentesPorTipoFECHAsemana"; // Nombre del procedimiento almacenado

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

                                    chart4.Series[0].Points.AddXY(tipoAccidente, totalAccidentes);
                                }
                            }
                        }
                    }

                }
            }
            if (radioButton2.Checked==true)
            {
                chart4.Series[0].Points.Clear();

                if (radioButton2.Checked)
                {
                    cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
                    string query = "ContarAccidentesPorTipoFECHAmes"; // Nombre del procedimiento almacenado

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

                                    chart4.Series[0].Points.AddXY(tipoAccidente, totalAccidentes);

                                }
                            }
                        }
                    }
                }               
            }
            if (radioButton3.Checked==true)
            {
                chart4.Series[0].Points.Clear();

                if (radioButton3.Checked)
                {
                    cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
                    string query = "ContarAccidentesPorTipoFECHAano"; // Nombre del procedimiento almacenado

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

                                    chart4.Series[0].Points.AddXY(tipoAccidente, totalAccidentes);

                                }
                            }
                        }
                    }

                }
            }
            if (rbNinguno.Checked == true)
            {
                DateTime fechaSeleccionada = dateTimePicker1.Value;
                chart4.Series[0].Points.Clear();
                ObtenerDatos(fechaSeleccionada);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //chart1.Update();
        }

        private void rbNinguno_CheckedChanged(object sender, EventArgs e)
        {
            chart4.Series[0].Points.Clear();

        }
    }
}
