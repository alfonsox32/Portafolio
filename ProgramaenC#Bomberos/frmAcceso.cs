using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBSPC
{
    public partial class frmAcceso : Form
    {
        //Declaracion del form como una variable
        DireccionBD direccionBD = new DireccionBD();
        //Conexion con la Base de Datos
        private SqlConnection conexion;
        private string cadenaConexion;

        public frmAcceso()
        {
            InitializeComponent();
            conexion = new SqlConnection(cadenaConexion);
            cadenaConexion = "Data Source =" + direccionBD.DireccionesBD() + "; Initial Catalog = BOMBEROSSPC; Integrated Security = true";
        }
        //Eventos
        //-------------------------------------- Evento Click --------------------------------------

        //Evento Click para el botón 'btnAceptar' que conectará con la base de datos y de validarse la
        //información mostrar el siguiente formulario
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //menuAcceso = new frmMenu();
            try
            {
                string idUsuario = txtNombreUsuario.Text;
                string contrasena = txtContrasena.Text;
                int usuarioLogeado;

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT rol FROM Usuario WHERE idUsuario = @idUsuario AND contrasena = @Contrasena";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                        comando.Parameters.AddWithValue("@Contrasena", contrasena);
                        object result = comando.ExecuteScalar();
                        if (result != null)
                        {
                            int esAdmin = (int)result;
                            if (esAdmin == 0)
                            {
                                usuarioLogeado = 0;
                                frmMenu menuAcceso = new frmMenu(idUsuario,usuarioLogeado);
                                menuAcceso.Refresh(usuarioLogeado);
                                //perfilUsuario.Refresh(idUsuario, usuarioLogeado);
                                this.Hide();
                                DialogResult resultado = menuAcceso.ShowDialog();
                                if (resultado == DialogResult.OK)
                                {
                                    this.Show();
                                }
                                else
                                {
                                    menuAcceso.Close();
                                    this.Show();
                                }
                            }
                            else if (esAdmin == 1)
                            {
                                usuarioLogeado = 1;
                                frmMenu menuAcceso = new frmMenu(idUsuario, usuarioLogeado);
                                menuAcceso.Refresh(usuarioLogeado);
                                this.Hide();
                                DialogResult resultado = menuAcceso.ShowDialog();
                                if (resultado == DialogResult.OK)
                                {
                                    this.Show();
                                }
                                else
                                {
                                    menuAcceso.Close();
                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        txtNombreUsuario.Text = null;
                        txtContrasena.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNombreUsuario.Text = null;
                txtContrasena.Text = null;
                conexion.Close(); // Cierra la conexión 
            }
        }

        //Evento Click para el botón 'btnSalir' que cierra el formulario actual para regresar al formulario
        //anterior
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------- Evento KeyDown --------------------------------------

        //Evento KeyDown para el textBox 'txtContrasena' encargado de realizar la conexión de igual manera
        //que el evento configurado para el botón 'btnAceptar'
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string idUsuario = txtNombreUsuario.Text;
                    string contrasena = txtContrasena.Text;
                    int usuarioLogeado;
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string query = "SELECT rol FROM Usuario WHERE idUsuario = @idUsuario AND contrasena = @Contrasena";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                            comando.Parameters.AddWithValue("@Contrasena", contrasena);
                            object result = comando.ExecuteScalar();
                            if (result != null)
                            {
                                int esAdmin = (int)result;
                                if (esAdmin == 0)
                                {
                                    usuarioLogeado = 0;
                                    frmMenu menuAcceso = new frmMenu(idUsuario, usuarioLogeado);
                                    menuAcceso.Refresh(usuarioLogeado);
                                    this.Hide();
                                    DialogResult resultado = menuAcceso.ShowDialog();
                                    if (resultado == DialogResult.OK)
                                    {
                                        this.Show();
                                    }
                                    else
                                    {
                                        menuAcceso.Close();
                                        this.Show();
                                    }
                                }
                                else if (esAdmin == 1)
                                {
                                    usuarioLogeado = 1;
                                    frmMenu menuAcceso = new frmMenu(idUsuario, usuarioLogeado);
                                    menuAcceso.Refresh(usuarioLogeado);
                                    this.Hide();
                                    DialogResult resultado = menuAcceso.ShowDialog();
                                    if (resultado == DialogResult.OK)
                                    {
                                        this.Show();
                                    }
                                    else
                                    {
                                        menuAcceso.Close();
                                        this.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                txtNombreUsuario.Text = null;
                                txtContrasena.Text = null;
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            txtNombreUsuario.Text = null;
                            txtContrasena.Text = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close(); // Cierra la conexión 
                }
                txtNombreUsuario.Select();
            }
        }

        //Evento KeyDown para el textBox 'txtNombreUsuario'
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            //Sí se presiona la tecla 'Enter' pasar al siiguiente textBox
            if (e.KeyCode==Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        //-------------------------------------- Evento Mouse --------------------------------------
        //Evento MouseDown para el pictureBox 'OcultarMostrarContraseña'
        private void pbOcultarMostrarConrtraseña_MouseDown(object sender, MouseEventArgs e)
        {
            //Mostrar el texto para la contraseña
            txtContrasena.UseSystemPasswordChar = false;
        }
        //Evento MouseUp para el pictureBox 'OcultarMostrarContraseña'
        private void pbOcultarMostrarConrtraseña_MouseUp(object sender, MouseEventArgs e)
        {
            //Ocultar el texto para la contraseña
            txtContrasena.UseSystemPasswordChar = true;
        }
    }
}
