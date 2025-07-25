namespace SistemaBSPC
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mstpMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiAltaDeCasos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistroCaso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarUnCaso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUltimosRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaAvanzada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUltimosCasosEstadistica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaAzanzadaEstadistica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfigurarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiVerPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Latencia = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLatencia = new System.Windows.Forms.TextBox();
            this.txtCoordenada2 = new System.Windows.Forms.TextBox();
            this.txtCoordenada1 = new System.Windows.Forms.TextBox();
            this.btn_ir_a = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.mstpMenuPrincipal.SuspendLayout();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstpMenuPrincipal
            // 
            this.mstpMenuPrincipal.BackColor = System.Drawing.Color.White;
            this.mstpMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstpMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstpMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaDeCasos,
            this.tsmiConsulta,
            this.tsmiEstadisticas,
            this.perfilToolStripMenuItem,
            this.tsmiUsuarios});
            this.mstpMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstpMenuPrincipal.Name = "mstpMenuPrincipal";
            this.mstpMenuPrincipal.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.mstpMenuPrincipal.Size = new System.Drawing.Size(1264, 32);
            this.mstpMenuPrincipal.TabIndex = 0;
            this.mstpMenuPrincipal.Text = "menuStrip1";
            // 
            // tsmiAltaDeCasos
            // 
            this.tsmiAltaDeCasos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistroCaso,
            this.tsmiModificarUnCaso});
            this.tsmiAltaDeCasos.Name = "tsmiAltaDeCasos";
            this.tsmiAltaDeCasos.Size = new System.Drawing.Size(109, 24);
            this.tsmiAltaDeCasos.Text = "Alta de casos";
            // 
            // tsmiRegistroCaso
            // 
            this.tsmiRegistroCaso.Name = "tsmiRegistroCaso";
            this.tsmiRegistroCaso.Size = new System.Drawing.Size(196, 24);
            this.tsmiRegistroCaso.Text = "Registrar un caso";
            this.tsmiRegistroCaso.Click += new System.EventHandler(this.tsmiRegistroCaso_Click);
            // 
            // tsmiModificarUnCaso
            // 
            this.tsmiModificarUnCaso.Name = "tsmiModificarUnCaso";
            this.tsmiModificarUnCaso.Size = new System.Drawing.Size(196, 24);
            this.tsmiModificarUnCaso.Text = "Modificar un caso";
            this.tsmiModificarUnCaso.Click += new System.EventHandler(this.tsmiModificarUnCaso_Click);
            // 
            // tsmiConsulta
            // 
            this.tsmiConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUltimosRegistros,
            this.tsmiBusquedaAvanzada});
            this.tsmiConsulta.Name = "tsmiConsulta";
            this.tsmiConsulta.Size = new System.Drawing.Size(78, 24);
            this.tsmiConsulta.Text = "Consulta";
            // 
            // tsmiUltimosRegistros
            // 
            this.tsmiUltimosRegistros.Name = "tsmiUltimosRegistros";
            this.tsmiUltimosRegistros.Size = new System.Drawing.Size(210, 24);
            this.tsmiUltimosRegistros.Text = "Últimos registros";
            this.tsmiUltimosRegistros.Click += new System.EventHandler(this.tsmiUltimosRegistros_Click);
            // 
            // tsmiBusquedaAvanzada
            // 
            this.tsmiBusquedaAvanzada.Name = "tsmiBusquedaAvanzada";
            this.tsmiBusquedaAvanzada.Size = new System.Drawing.Size(210, 24);
            this.tsmiBusquedaAvanzada.Text = "Búsqueda avanzada";
            this.tsmiBusquedaAvanzada.Click += new System.EventHandler(this.tsmiBusquedaAvanzada_Click);
            // 
            // tsmiEstadisticas
            // 
            this.tsmiEstadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUltimosCasosEstadistica,
            this.tsmiConsultaAzanzadaEstadistica});
            this.tsmiEstadisticas.Name = "tsmiEstadisticas";
            this.tsmiEstadisticas.Size = new System.Drawing.Size(97, 24);
            this.tsmiEstadisticas.Text = "Estadísticas";
            // 
            // tsmiUltimosCasosEstadistica
            // 
            this.tsmiUltimosCasosEstadistica.Name = "tsmiUltimosCasosEstadistica";
            this.tsmiUltimosCasosEstadistica.Size = new System.Drawing.Size(202, 24);
            this.tsmiUltimosCasosEstadistica.Text = "Últimos casos";
            this.tsmiUltimosCasosEstadistica.Click += new System.EventHandler(this.tsmiUltimosCasosEstadistica_Click);
            // 
            // tsmiConsultaAzanzadaEstadistica
            // 
            this.tsmiConsultaAzanzadaEstadistica.Name = "tsmiConsultaAzanzadaEstadistica";
            this.tsmiConsultaAzanzadaEstadistica.Size = new System.Drawing.Size(202, 24);
            this.tsmiConsultaAzanzadaEstadistica.Text = "Consulta avanzada";
            this.tsmiConsultaAzanzadaEstadistica.Click += new System.EventHandler(this.tsmiConsultaAzanzadaEstadistica_Click);
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConfigurarUsuarios,
            this.tsmiConsultarUsuarios});
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(77, 24);
            this.tsmiUsuarios.Text = "Usuarios";
            this.tsmiUsuarios.Visible = false;
            // 
            // tsmiConfigurarUsuarios
            // 
            this.tsmiConfigurarUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoUsuario,
            this.tsmiModificarUsuario,
            this.tsmiEliminarUsuario});
            this.tsmiConfigurarUsuarios.Name = "tsmiConfigurarUsuarios";
            this.tsmiConfigurarUsuarios.Size = new System.Drawing.Size(206, 24);
            this.tsmiConfigurarUsuarios.Text = "Configurar usuarios";
            // 
            // tsmiNuevoUsuario
            // 
            this.tsmiNuevoUsuario.Name = "tsmiNuevoUsuario";
            this.tsmiNuevoUsuario.Size = new System.Drawing.Size(194, 24);
            this.tsmiNuevoUsuario.Text = "Nuevo Usuario";
            this.tsmiNuevoUsuario.Click += new System.EventHandler(this.tsmiNuevoUsuario_Click);
            // 
            // tsmiModificarUsuario
            // 
            this.tsmiModificarUsuario.Name = "tsmiModificarUsuario";
            this.tsmiModificarUsuario.Size = new System.Drawing.Size(194, 24);
            this.tsmiModificarUsuario.Text = "Modificar usuario";
            this.tsmiModificarUsuario.Click += new System.EventHandler(this.tsmiModificarUsuario_Click);
            // 
            // tsmiEliminarUsuario
            // 
            this.tsmiEliminarUsuario.Name = "tsmiEliminarUsuario";
            this.tsmiEliminarUsuario.Size = new System.Drawing.Size(194, 24);
            this.tsmiEliminarUsuario.Text = "Eliminar usuario";
            this.tsmiEliminarUsuario.Click += new System.EventHandler(this.tsmiEliminarUsuario_Click);
            // 
            // tsmiConsultarUsuarios
            // 
            this.tsmiConsultarUsuarios.Name = "tsmiConsultarUsuarios";
            this.tsmiConsultarUsuarios.Size = new System.Drawing.Size(206, 24);
            this.tsmiConsultarUsuarios.Text = "Consultar usuarios";
            this.tsmiConsultarUsuarios.Click += new System.EventHandler(this.tsmiConsultarUsuarios_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiVerPerfil});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // tmsiVerPerfil
            // 
            this.tmsiVerPerfil.Name = "tmsiVerPerfil";
            this.tmsiVerPerfil.Size = new System.Drawing.Size(180, 24);
            this.tmsiVerPerfil.Text = "Ver Perfil";
            this.tmsiVerPerfil.Click += new System.EventHandler(this.tmsiVerPerfil_Click);
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.splitContainer1);
            this.gbContenedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbContenedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(15, 38);
            this.gbContenedor.Margin = new System.Windows.Forms.Padding(6);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Padding = new System.Windows.Forms.Padding(6);
            this.gbContenedor.Size = new System.Drawing.Size(1234, 594);
            this.gbContenedor.TabIndex = 1;
            this.gbContenedor.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Latencia);
            this.splitContainer1.Panel1.Controls.Add(this.txtLongitud);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtLatencia);
            this.splitContainer1.Panel1.Controls.Add(this.txtCoordenada2);
            this.splitContainer1.Panel1.Controls.Add(this.txtCoordenada1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ir_a);
            this.splitContainer1.Size = new System.Drawing.Size(1222, 560);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mapa Offline";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Longitud";
            // 
            // Latencia
            // 
            this.Latencia.AutoSize = true;
            this.Latencia.Location = new System.Drawing.Point(40, 366);
            this.Latencia.Name = "Latencia";
            this.Latencia.Size = new System.Drawing.Size(67, 21);
            this.Latencia.TabIndex = 11;
            this.Latencia.Text = "Latencia";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(143, 412);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(208, 29);
            this.txtLongitud.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Latencia de las marcas";
            // 
            // txtLatencia
            // 
            this.txtLatencia.Location = new System.Drawing.Point(143, 366);
            this.txtLatencia.Name = "txtLatencia";
            this.txtLatencia.Size = new System.Drawing.Size(208, 29);
            this.txtLatencia.TabIndex = 8;
            // 
            // txtCoordenada2
            // 
            this.txtCoordenada2.Location = new System.Drawing.Point(25, 101);
            this.txtCoordenada2.Name = "txtCoordenada2";
            this.txtCoordenada2.Size = new System.Drawing.Size(208, 29);
            this.txtCoordenada2.TabIndex = 6;
            // 
            // txtCoordenada1
            // 
            this.txtCoordenada1.Location = new System.Drawing.Point(25, 39);
            this.txtCoordenada1.Name = "txtCoordenada1";
            this.txtCoordenada1.Size = new System.Drawing.Size(208, 29);
            this.txtCoordenada1.TabIndex = 5;
            // 
            // btn_ir_a
            // 
            this.btn_ir_a.Location = new System.Drawing.Point(25, 170);
            this.btn_ir_a.Name = "btn_ir_a";
            this.btn_ir_a.Size = new System.Drawing.Size(208, 50);
            this.btn_ir_a.TabIndex = 0;
            this.btn_ir_a.Text = "Cargar Coordenadas";
            this.btn_ir_a.UseVisualStyleBackColor = true;
            this.btn_ir_a.Click += new System.EventHandler(this.btn_ir_a_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1178, 638);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 34);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "24:00 a.m.\r\n00/00/0000";
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gbContenedor);
            this.Controls.Add(this.mstpMenuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstpMenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema BSPC";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mstpMenuPrincipal.ResumeLayout(false);
            this.mstpMenuPrincipal.PerformLayout();
            this.gbContenedor.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstpMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaDeCasos;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistroCaso;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmiUltimosRegistros;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarUnCaso;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaAvanzada;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem tsmiUltimosCasosEstadistica;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaAzanzadaEstadistica;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigurarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarUsuario;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiVerPerfil;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_ir_a;
        private System.Windows.Forms.TextBox txtCoordenada2;
        private System.Windows.Forms.TextBox txtCoordenada1;
        private System.Windows.Forms.TextBox txtLatencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Latencia;
        private System.Windows.Forms.Button button1;
    }
}

