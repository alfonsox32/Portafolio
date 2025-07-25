using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBSPC
{
    public partial class frmCantidadHerramientas : Form
    {
        // Almacenar la cantidad
        public int Cantidad { get; private set; }
        // Constructor 
        public frmCantidadHerramientas(string herramienta)
        {
            InitializeComponent();
            gbContenedor.Text = herramienta;
        }
        // Eventos
        // Evento clic
        // Evento clic que se activa al seleccionar el boton y convierte la información del txtCantidad
        // a un numero entero y lo guarda en Cantidad en la variable cantidad para después cerrar el form
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                Cantidad = cantidad;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }
    }
}
