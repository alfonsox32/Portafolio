using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBSPC
{
    public partial class frmPerfil : Form
    {
        DireccionBD direccionBD = new DireccionBD();
        //Conexion con la Base de Datos
        private SqlConnection conexion;
        private string cadenaConexion;

        public frmPerfil()
        {
            InitializeComponent();
            conexion = new SqlConnection(cadenaConexion);
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
        }
        //----------------------------------------- Funciones -----------------------------------------
        public void Refresh(string claveUsuario, int tipoUsuarioLogeado)
        {
            string nombreUsuario = ObtenerNombreUsuario(claveUsuario);
            lblNombreUsuario.Text = nombreUsuario;
            lblClaveUsuario.Text = claveUsuario;
            if (tipoUsuarioLogeado == 1)
            {
                lblRolAdministrativoUsuario.Text = "Administrador/a";
            }
            else
            {
                lblRolAdministrativoUsuario.Text = "Secretario/a";
            }
        }

        private string ObtenerNombreUsuario(string idUsuario)
        {
            string nombreUsuario = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "EXEC spObtenerNombreUsuario @idUsuario";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                        nombreUsuario = comando.ExecuteScalar() as string;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombreUsuario;
        }
    }
}
