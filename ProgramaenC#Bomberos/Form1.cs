using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsPresentation;
using GMapMarker = GMap.NET.WindowsForms.GMapMarker;

namespace SistemaBSPC
{
    public partial class frmMenu : Form
    {
        //Gmap 
        GMap.NET.WindowsForms.GMapControl mapita;
        private GMapOverlay markersOverlay;



        //Instanciar los forms
        frmRegistroDeCasos registroDeCasos;
        frmModificaionDeCaso modificaionDeCaso;
        frmUltimosRegistros ultimosRegistros;
        frmBusquedaAvanzadaCasos busquedaAvanzadaCasos;
        frmUltimosCasosEstadistica ultimosCasosEstadistica;
        frmConsultaAvanzadaEstadistica consultaAvanzadaEstadistica;
        frmRegistrarUsuario registrarUsuario;
        frmMostrarUsuarios mostrarUsuarios;
        frmPerfil perfilUsuario;
        mapaOffline mapaOff;
        //Variables compartidas
        private string idUsuario1;
        private int usuarioLogeado1;
        

        public frmMenu(string idUsuario, int usuarioLogeado)
        {
            InitializeComponent();
            tmrTick.Tick += tmrTick_Tick;
            tmrTick.Start();
            this.idUsuario1 = idUsuario;
            this.usuarioLogeado1 = usuarioLogeado;
           
            //Gmap
            mapita = new GMap.NET.WindowsForms.GMapControl();
            mapita.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            mapita.Dock = DockStyle.Fill;
            mapita.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            mapita.ShowCenter = false;
            mapita.MinZoom = 1;
            mapita.MaxZoom = 20;
            splitContainer1.Panel2.Controls.Add(mapita);
            mapita.DragButton = MouseButtons.Left;
            markersOverlay = new GMapOverlay("Marca");
            mapita.Overlays.Add(markersOverlay);
            mapita.MouseDoubleClick += new MouseEventHandler(Mapita_MouseDoubleClick);
            mapita.MouseClick += new MouseEventHandler(Mapita_MouseClick);
        }

        //Eventos
        //Evento Click
        //Evento Click para el ToolStrpMenuItem RegistroCaso
        private void tsmiRegistroCaso_Click(object sender, EventArgs e)
        {
            registroDeCasos = new frmRegistroDeCasos();
            this.Hide();
            DialogResult result = registroDeCasos.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                registroDeCasos.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem ModificarUnCaso
        private void tsmiModificarUnCaso_Click(object sender, EventArgs e)
        {
            modificaionDeCaso = new frmModificaionDeCaso();
            this.Hide();
            DialogResult result = modificaionDeCaso.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                modificaionDeCaso.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem ÚltimosRegistros
        private void tsmiUltimosRegistros_Click(object sender, EventArgs e)
        {
            ultimosRegistros = new frmUltimosRegistros();
            this.Hide();
            DialogResult result = ultimosRegistros.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                ultimosRegistros.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem BusquedaAvanzadaCasos
        private void tsmiBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            busquedaAvanzadaCasos = new frmBusquedaAvanzadaCasos();
            this.Hide();
            DialogResult result = busquedaAvanzadaCasos.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                busquedaAvanzadaCasos.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem ÚltimosCasosEstadistica
        private void tsmiUltimosCasosEstadistica_Click(object sender, EventArgs e)
        {
            ultimosCasosEstadistica = new frmUltimosCasosEstadistica();
            this.Hide();
            DialogResult result = ultimosCasosEstadistica.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                ultimosCasosEstadistica.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem ConsultaAvanzadaEstadistica
        private void tsmiConsultaAzanzadaEstadistica_Click(object sender, EventArgs e)
        {
            consultaAvanzadaEstadistica = new frmConsultaAvanzadaEstadistica();
            this.Hide();
            DialogResult result = consultaAvanzadaEstadistica.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                consultaAvanzadaEstadistica.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem RegistrarNuevoUsuario
        private void tsmiNuevoUsuario_Click(object sender, EventArgs e)
        {
            string identificador = "Crear";
            registrarUsuario = new frmRegistrarUsuario(idUsuario1);
            registrarUsuario.Refresh(identificador);
            this.Hide();
            DialogResult result = registrarUsuario.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                registrarUsuario.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem ModificarUsuario
        private void tsmiModificarUsuario_Click(object sender, EventArgs e)
        {
            string identificador = "Modificar";
            registrarUsuario = new frmRegistrarUsuario(idUsuario1);
            registrarUsuario.Refresh(identificador); ;
            this.Hide();
            DialogResult result = registrarUsuario.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                registrarUsuario.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem EliminarUsuario
        private void tsmiEliminarUsuario_Click(object sender, EventArgs e)
        {
            string identificador = "Eliminar";
            registrarUsuario = new frmRegistrarUsuario(idUsuario1);
            registrarUsuario.Refresh(identificador);
            this.Hide();
            DialogResult result = registrarUsuario.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                registrarUsuario.Close();
                this.Show();
            }
        }
        //Evento Click para el ToolStrpMenuItem ConsultarUsuario
        private void tsmiConsultarUsuarios_Click(object sender, EventArgs e)
        {
            mostrarUsuarios = new frmMostrarUsuarios();
            this.Hide();
            DialogResult result = mostrarUsuarios.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                mostrarUsuarios.Close();
                this.Show();
            }
        }
        //Evento refresh
        public void Refresh(int acceso)
        {
            if (acceso == 1)
            {
                tsmiUsuarios.Visible = true;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            string coordenada1, coordenada2;
            txtCoordenada1.Text = "25.757772";
            txtCoordenada2.Text = "-102.983941";
            coordenada1 = txtCoordenada1.Text;
            coordenada2 = txtCoordenada2.Text;
            mapita.Position = new PointLatLng(Convert.ToDouble(coordenada1), 
                Convert.ToDouble(coordenada2));
            mapita.Zoom = 14;
            Refresh();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("hh:mm tt\ndd/MM/yyyy");
        }

        //Evento Click para el ToolStrpMenuItem VerPerfil
        private void tmsiVerPerfil_Click(object sender, EventArgs e)
        {
            perfilUsuario = new frmPerfil();
            perfilUsuario.Refresh(idUsuario1, usuarioLogeado1);
            this.Hide();
            DialogResult result = perfilUsuario.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                perfilUsuario.Close();
                this.Show();
            }
        }

        private void btn_ir_a_Click(object sender, EventArgs e)
        {
            mapita.Position = new PointLatLng(Convert.ToDouble(txtCoordenada1.Text), Convert.ToDouble(txtCoordenada2.Text));
            mapita.Zoom = 5;
            mapita.Update();
            mapita.Refresh();
        }

        

        private void btnArrastrar_Click(object sender, EventArgs e)
        {
            mapita.DragButton = MouseButtons.Left;

        }

        private void btnMouseMove_Click(object sender, EventArgs e)
        {
            mapita.MouseClick += gmap_MouseClick;
        }

        void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("X:" + e.X.ToString() + " and Y:" + e.Y.ToString());
        }

        
        PointLatLng point;
        private void Mapita_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Obtener las coordenadas donde se hizo clic
                point = mapita.FromLocalToLatLng(e.X, e.Y);

                //Crear un nuevo marcador en esa posición
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                //Añadir el marcador a la capa de marcadores
                markersOverlay.Markers.Add(marker);

                txtLatencia.Text = $"{point.Lat}";
                txtLongitud.Text = $"{point.Lng}";
            }
        }

        private void Mapita_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                markersOverlay.Markers.Clear();
                txtLatencia.Clear();
                txtLongitud.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapaOff = new mapaOffline();
            this.Hide();
            DialogResult result = mapaOff.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                mapaOff.Close();
                this.Show();
            }
        }

    }
}
