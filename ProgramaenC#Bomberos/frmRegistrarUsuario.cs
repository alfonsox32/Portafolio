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
    public partial class frmRegistrarUsuario : Form
    {
        DireccionBD direccionBD = new DireccionBD();
        private string cadenaConexion;
        private string idUsuarioLogeado;
        public frmRegistrarUsuario(string idUsuario)
        {
            InitializeComponent();
            gbNuevoUsuario.Hide();
            gbModificarUsuario.Hide();
            gbEliminarUsuario.Hide();
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
            this.idUsuarioLogeado = idUsuario;
        }
        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            Refresh();
        }

        
        private void pbOcultarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasenaNuevoUsuario.UseSystemPasswordChar = false;
            txtConfirmarContrasenaNuevoUsuario.UseSystemPasswordChar = false;
        }

        private void pbOcultarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasenaNuevoUsuario.UseSystemPasswordChar = true;
            txtConfirmarContrasenaNuevoUsuario.UseSystemPasswordChar = true;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNuevoUsuario.Text;
            string rol = cbRolUsuarioCrear.Text;
            string contrasena = txtContrasenaNuevoUsuario.Text;
            string confirmarContrasena = txtConfirmarContrasenaNuevoUsuario.Text;
            // Validar que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreNuevoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasenaNuevoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContrasenaNuevoUsuario.Text) ||
                string.IsNullOrWhiteSpace(cbRolUsuarioCrear.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Filtros extras
            if (!ValidarContraseñas(contrasena, nombre))
            {
                return;
            }
            
            // Validar que las contraseñas sean iguales
            if (contrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Una vez pasados todos los filtros comenzará el proceso de creación de un nuevo usuario
            try
            {
                // Realizar la conexión con la base de datos
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    int rolBol;
                    // Abrir la conexión
                    connection.Open();
                    // Mandar a llamar el StoredProcedure
                    SqlCommand command = new SqlCommand("spInsertarUsuario", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    if (rol== "Secretaria(o)")
                    {
                        rolBol = 0;
                    }
                    else
                    {
                        rolBol = 1;
                    }
                    command.Parameters.AddWithValue("@Rol", rolBol);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                // Limpiar los cuadros de texto
                txtNombreNuevoUsuario.Text = string.Empty;               
                txtContrasenaNuevoUsuario.Text = string.Empty;
                txtConfirmarContrasenaNuevoUsuario.Text = string.Empty;
                cbRolUsuarioCrear.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Actualizar los usuarios
            CargarUsuarios();
            
        }

        private void pbMostrarOcultarContrasenaModificar_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmarContrasenaModificar.UseSystemPasswordChar = false;
            txtContraseñaUsuarioModificar.UseSystemPasswordChar = false;
        }

        private void pbMostrarOcultarContrasenaModificar_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmarContrasenaModificar.UseSystemPasswordChar = true;
            txtContraseñaUsuarioModificar.UseSystemPasswordChar = true;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string idUsuarioEliminar = txtCodigoUsuarioEliminar.Text;
            // Obtener los valores de los campos
            string idUsuario = txtCodigoUsuarioModificar.Text;
            string nuevoNombre = txtNombreUsuarioModificar.Text;
            string nuevoRol = cbSeleccionarRol.Text;
            string nuevaContrasena = txtContraseñaUsuarioModificar.Text;
            string confirmarContrasena = txtConfirmarContrasenaModificar.Text;

            // Validar que ningún campo esté vacío
            if (string.IsNullOrEmpty(idUsuario) ||
                string.IsNullOrEmpty(nuevoNombre) ||
                string.IsNullOrEmpty(nuevaContrasena) ||
                string.IsNullOrEmpty(confirmarContrasena) ||
                string.IsNullOrWhiteSpace(nuevoRol))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las contraseñas coincidan
            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Filtros extras
            if (!ValidarContraseñas(nuevaContrasena, nuevoNombre))
            {
                return;
            }
            
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    int rolBol;
                    connection.Open();

                    SqlCommand command = new SqlCommand("spModificarUsuario", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                    if (nuevoRol == "Secretaria(o)")
                    {
                        rolBol = 0;
                    }
                    else
                    {
                        rolBol = 1;
                    }
                    command.Parameters.AddWithValue("@NuevoRol", rolBol);
                    command.Parameters.AddWithValue("@NuevaContrasena", nuevaContrasena);
                                        
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoUsuarioModificar.Text = string.Empty;
                        txtNombreUsuarioModificar.Text = string.Empty;
                        txtContraseñaUsuarioModificar.Text = string.Empty;
                        txtConfirmarContrasenaModificar.Text = string.Empty;
                        cbSeleccionarRol.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //Actualizar los usuarios
            CargarUsuarios();
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string idUsuarioEliminar = txtCodigoUsuarioEliminar.Text;

            //Validar que se ingrese un dato
            if (string.IsNullOrEmpty(idUsuarioEliminar))
            {
                MessageBox.Show("Por favor, ingresa el ID del usuario a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (idUsuarioEliminar == idUsuarioLogeado)
            {
                MessageBox.Show("No se puede eliminar el usuario logeado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Llamar al procedimiento almacenado para eliminar el usuario
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("spEliminarUsuario", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsuarioEliminar", idUsuarioEliminar);

                        cmd.ExecuteNonQuery();
                        if (txtCodigoUsuarioEliminar.Text != "admin")
                        {
                            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Limpiar datos
                            txtCodigoUsuarioEliminar.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar el usuario: " + txtCodigoUsuarioEliminar.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Actualizar los usuarios
            CargarUsuarios();
        }

        //------------------------------------------- Funciones --------------------------------------
        //Funcion refresh
        public void Refresh(string tipoAcceso)
        {
            switch (tipoAcceso)
            {
                case "Crear":
                    gbNuevoUsuario.Show();
                    gbModificarUsuario.Hide();
                    gbEliminarUsuario.Hide();
                    break;
                case "Eliminar":
                    gbNuevoUsuario.Hide();
                    gbModificarUsuario.Hide();
                    gbEliminarUsuario.Show();
                    break;
                case "Modificar":
                    gbNuevoUsuario.Hide();
                    gbModificarUsuario.Show();
                    gbEliminarUsuario.Hide();
                    break;
                default:
                    gbNuevoUsuario.Hide();
                    gbModificarUsuario.Hide();
                    gbEliminarUsuario.Hide();
                    break;
            }
        }

        //Función cargarUsuarios para mostrar los usuarios en la base de datos
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
        private bool ValidarContraseñas(string contrasena, string nombre)
        {
            if (contrasena.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contrasena.Equals(nombre))
            {
                MessageBox.Show("La contraseña no puede ser igual al nombre del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contrasena.All(char.IsDigit))
            {
                MessageBox.Show("La contraseña no puede ser una secuencia de números como '12345678' o contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contrasena == "contraseña" || contrasena == "Contraseña" || contrasena == "CONTRASEÑA" ||
                contrasena == "CONTRASENA" || contrasena == "password" || contrasena == "Password" ||
                contrasena == "PASSWORD")
            {
                MessageBox.Show("La contraseña es demasiado débil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
