namespace SistemaBSPC
{
    partial class frmBusquedaAvanzadaCasos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaAvanzadaCasos));
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.rbAntiguo = new System.Windows.Forms.RadioButton();
            this.rbReciente = new System.Windows.Forms.RadioButton();
            this.chbCP = new System.Windows.Forms.CheckBox();
            this.chbIntervencion = new System.Windows.Forms.CheckBox();
            this.chbFecha = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbIntervencion = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIntervencion = new System.Windows.Forms.Label();
            this.gbContenedorFiltro = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCP = new System.Windows.Forms.Label();
            this.cbCP = new System.Windows.Forms.ComboBox();
            this.gbContenedorVista = new System.Windows.Forms.GroupBox();
            this.lbCP = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHerramientas = new System.Windows.Forms.TextBox();
            this.lblHerramientas = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCaso = new System.Windows.Forms.TextBox();
            this.lblCaso = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbContenedorMuestra = new System.Windows.Forms.GroupBox();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.gbContenedor.SuspendLayout();
            this.gbContenedorFiltro.SuspendLayout();
            this.gbContenedorVista.SuspendLayout();
            this.gbContenedorMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.rbAntiguo);
            this.gbContenedor.Controls.Add(this.rbReciente);
            this.gbContenedor.Controls.Add(this.chbCP);
            this.gbContenedor.Controls.Add(this.chbIntervencion);
            this.gbContenedor.Controls.Add(this.chbFecha);
            this.gbContenedor.Controls.Add(this.lblMensaje);
            this.gbContenedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbContenedor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(15, 15);
            this.gbContenedor.Margin = new System.Windows.Forms.Padding(6);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Padding = new System.Windows.Forms.Padding(6);
            this.gbContenedor.Size = new System.Drawing.Size(349, 202);
            this.gbContenedor.TabIndex = 0;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Información";
            // 
            // rbAntiguo
            // 
            this.rbAntiguo.AutoSize = true;
            this.rbAntiguo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAntiguo.Location = new System.Drawing.Point(248, 89);
            this.rbAntiguo.Name = "rbAntiguo";
            this.rbAntiguo.Size = new System.Drawing.Size(83, 25);
            this.rbAntiguo.TabIndex = 3;
            this.rbAntiguo.TabStop = true;
            this.rbAntiguo.Text = "Antiguo";
            this.rbAntiguo.UseVisualStyleBackColor = true;
            this.rbAntiguo.Visible = false;
            this.rbAntiguo.CheckedChanged += new System.EventHandler(this.rbAntiguo_CheckedChanged);
            // 
            // rbReciente
            // 
            this.rbReciente.AutoSize = true;
            this.rbReciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReciente.Location = new System.Drawing.Point(141, 89);
            this.rbReciente.Name = "rbReciente";
            this.rbReciente.Size = new System.Drawing.Size(87, 25);
            this.rbReciente.TabIndex = 2;
            this.rbReciente.TabStop = true;
            this.rbReciente.Text = "Reciente";
            this.rbReciente.UseVisualStyleBackColor = true;
            this.rbReciente.Visible = false;
            this.rbReciente.CheckedChanged += new System.EventHandler(this.rbReciente_CheckedChanged);
            // 
            // chbCP
            // 
            this.chbCP.AutoSize = true;
            this.chbCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCP.Location = new System.Drawing.Point(11, 163);
            this.chbCP.Margin = new System.Windows.Forms.Padding(6);
            this.chbCP.Name = "chbCP";
            this.chbCP.Size = new System.Drawing.Size(91, 25);
            this.chbCP.TabIndex = 5;
            this.chbCP.Text = "Dirección";
            this.chbCP.UseVisualStyleBackColor = true;
            this.chbCP.CheckedChanged += new System.EventHandler(this.chbCP_CheckedChanged);
            // 
            // chbIntervencion
            // 
            this.chbIntervencion.AutoSize = true;
            this.chbIntervencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbIntervencion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIntervencion.Location = new System.Drawing.Point(12, 126);
            this.chbIntervencion.Margin = new System.Windows.Forms.Padding(6);
            this.chbIntervencion.Name = "chbIntervencion";
            this.chbIntervencion.Size = new System.Drawing.Size(112, 25);
            this.chbIntervencion.TabIndex = 4;
            this.chbIntervencion.Text = "Intervención";
            this.chbIntervencion.UseVisualStyleBackColor = true;
            this.chbIntervencion.CheckedChanged += new System.EventHandler(this.chbIntervencion_CheckedChanged);
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFecha.Location = new System.Drawing.Point(12, 89);
            this.chbFecha.Margin = new System.Windows.Forms.Padding(6);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(66, 25);
            this.chbFecha.TabIndex = 1;
            this.chbFecha.Text = "Fecha";
            this.chbFecha.UseVisualStyleBackColor = true;
            this.chbFecha.CheckedChanged += new System.EventHandler(this.chbFecha_CheckedChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 32);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(322, 42);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Selecciona los filtros necesarios para realizar \r\nla búsqueda de las intervencion" +
    "es realizadas.";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(13, 66);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(320, 29);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Value = new System.DateTime(2024, 5, 20, 22, 6, 26, 0);
            // 
            // cbIntervencion
            // 
            this.cbIntervencion.BackColor = System.Drawing.Color.White;
            this.cbIntervencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIntervencion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntervencion.FormattingEnabled = true;
            this.cbIntervencion.Items.AddRange(new object[] {
            "Accidentes",
            "Capacitaciones",
            "Cables colgados, reventados o en corto circuito",
            "Enjambres",
            "Fuga de gas",
            "Incendios",
            "Poda de árboles",
            "Rondines de rin de semana",
            "Simulacros",
            "Traslado de agua",
            "Traslados (Ambulancia)",
            "Vehículos incendiados",
            "Verificación de negocios"});
            this.cbIntervencion.Location = new System.Drawing.Point(13, 153);
            this.cbIntervencion.Margin = new System.Windows.Forms.Padding(6);
            this.cbIntervencion.Name = "cbIntervencion";
            this.cbIntervencion.Size = new System.Drawing.Size(320, 29);
            this.cbIntervencion.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(13, 32);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(133, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Seleccionar fecha:";
            // 
            // lblIntervencion
            // 
            this.lblIntervencion.AutoSize = true;
            this.lblIntervencion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervencion.Location = new System.Drawing.Point(13, 113);
            this.lblIntervencion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIntervencion.Name = "lblIntervencion";
            this.lblIntervencion.Size = new System.Drawing.Size(182, 21);
            this.lblIntervencion.TabIndex = 8;
            this.lblIntervencion.Text = "Seleccionar intervención:";
            // 
            // gbContenedorFiltro
            // 
            this.gbContenedorFiltro.Controls.Add(this.btnReporte);
            this.gbContenedorFiltro.Controls.Add(this.btnBuscar);
            this.gbContenedorFiltro.Controls.Add(this.lblCP);
            this.gbContenedorFiltro.Controls.Add(this.cbCP);
            this.gbContenedorFiltro.Controls.Add(this.dtpFecha);
            this.gbContenedorFiltro.Controls.Add(this.lblIntervencion);
            this.gbContenedorFiltro.Controls.Add(this.cbIntervencion);
            this.gbContenedorFiltro.Controls.Add(this.lblFecha);
            this.gbContenedorFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbContenedorFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedorFiltro.Location = new System.Drawing.Point(15, 229);
            this.gbContenedorFiltro.Margin = new System.Windows.Forms.Padding(6);
            this.gbContenedorFiltro.Name = "gbContenedorFiltro";
            this.gbContenedorFiltro.Padding = new System.Windows.Forms.Padding(6);
            this.gbContenedorFiltro.Size = new System.Drawing.Size(349, 440);
            this.gbContenedorFiltro.TabIndex = 6;
            this.gbContenedorFiltro.TabStop = false;
            this.gbContenedorFiltro.Text = "Filtros";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(9, 382);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(187, 46);
            this.btnReporte.TabIndex = 28;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(9, 319);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 46);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(13, 208);
            this.lblCP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(159, 21);
            this.lblCP.TabIndex = 10;
            this.lblCP.Text = "Seleccionar dirección:";
            // 
            // cbCP
            // 
            this.cbCP.BackColor = System.Drawing.Color.White;
            this.cbCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCP.FormattingEnabled = true;
            this.cbCP.ItemHeight = 21;
            this.cbCP.Location = new System.Drawing.Point(13, 248);
            this.cbCP.Margin = new System.Windows.Forms.Padding(6);
            this.cbCP.Name = "cbCP";
            this.cbCP.Size = new System.Drawing.Size(318, 29);
            this.cbCP.TabIndex = 11;
            // 
            // gbContenedorVista
            // 
            this.gbContenedorVista.Controls.Add(this.lbCP);
            this.gbContenedorVista.Controls.Add(this.lblColonia);
            this.gbContenedorVista.Controls.Add(this.lbDireccion);
            this.gbContenedorVista.Controls.Add(this.lbFecha);
            this.gbContenedorVista.Controls.Add(this.txtCP);
            this.gbContenedorVista.Controls.Add(this.txtColonia);
            this.gbContenedorVista.Controls.Add(this.txtDireccion);
            this.gbContenedorVista.Controls.Add(this.txtFecha);
            this.gbContenedorVista.Controls.Add(this.txtHerramientas);
            this.gbContenedorVista.Controls.Add(this.lblHerramientas);
            this.gbContenedorVista.Controls.Add(this.lblDescripcion);
            this.gbContenedorVista.Controls.Add(this.txtCaso);
            this.gbContenedorVista.Controls.Add(this.lblCaso);
            this.gbContenedorVista.Controls.Add(this.txtDescripcion);
            this.gbContenedorVista.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedorVista.Location = new System.Drawing.Point(375, 13);
            this.gbContenedorVista.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbContenedorVista.Name = "gbContenedorVista";
            this.gbContenedorVista.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbContenedorVista.Size = new System.Drawing.Size(877, 254);
            this.gbContenedorVista.TabIndex = 8;
            this.gbContenedorVista.TabStop = false;
            this.gbContenedorVista.Text = "Resultado";
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCP.Location = new System.Drawing.Point(702, 30);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(108, 21);
            this.lbCP.TabIndex = 19;
            this.lbCP.Text = "Código Postal:";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(197, 30);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(106, 21);
            this.lblColonia.TabIndex = 15;
            this.lblColonia.Text = "Colonia/Ejido:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(373, 30);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(78, 21);
            this.lbDireccion.TabIndex = 17;
            this.lbDireccion.Text = "Dirección:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(702, 111);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(53, 21);
            this.lbFecha.TabIndex = 25;
            this.lbFecha.Text = "Fecha:";
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(705, 54);
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.Size = new System.Drawing.Size(164, 29);
            this.txtCP.TabIndex = 20;
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(201, 54);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ReadOnly = true;
            this.txtColonia.Size = new System.Drawing.Size(158, 29);
            this.txtColonia.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(377, 54);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(304, 29);
            this.txtDireccion.TabIndex = 18;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(706, 135);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(164, 29);
            this.txtFecha.TabIndex = 26;
            // 
            // txtHerramientas
            // 
            this.txtHerramientas.BackColor = System.Drawing.Color.White;
            this.txtHerramientas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerramientas.Location = new System.Drawing.Point(377, 135);
            this.txtHerramientas.Multiline = true;
            this.txtHerramientas.Name = "txtHerramientas";
            this.txtHerramientas.ReadOnly = true;
            this.txtHerramientas.Size = new System.Drawing.Size(306, 111);
            this.txtHerramientas.TabIndex = 24;
            // 
            // lblHerramientas
            // 
            this.lblHerramientas.AutoSize = true;
            this.lblHerramientas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerramientas.Location = new System.Drawing.Point(373, 111);
            this.lblHerramientas.Name = "lblHerramientas";
            this.lblHerramientas.Size = new System.Drawing.Size(176, 21);
            this.lblHerramientas.TabIndex = 23;
            this.lblHerramientas.Text = "Herramientas utilizadas:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 21);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCaso
            // 
            this.txtCaso.BackColor = System.Drawing.Color.White;
            this.txtCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaso.Location = new System.Drawing.Point(8, 54);
            this.txtCaso.Name = "txtCaso";
            this.txtCaso.ReadOnly = true;
            this.txtCaso.Size = new System.Drawing.Size(176, 29);
            this.txtCaso.TabIndex = 14;
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaso.Location = new System.Drawing.Point(8, 30);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(47, 21);
            this.lblCaso.TabIndex = 13;
            this.lblCaso.Text = "Caso:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(8, 135);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(351, 111);
            this.txtDescripcion.TabIndex = 22;
            // 
            // gbContenedorMuestra
            // 
            this.gbContenedorMuestra.Controls.Add(this.dgvMuestra);
            this.gbContenedorMuestra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedorMuestra.Location = new System.Drawing.Point(375, 274);
            this.gbContenedorMuestra.Name = "gbContenedorMuestra";
            this.gbContenedorMuestra.Size = new System.Drawing.Size(877, 395);
            this.gbContenedorMuestra.TabIndex = 9;
            this.gbContenedorMuestra.TabStop = false;
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.AllowUserToAddRows = false;
            this.dgvMuestra.AllowUserToDeleteRows = false;
            this.dgvMuestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuestra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(6, 28);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.ReadOnly = true;
            this.dgvMuestra.RowHeadersWidth = 51;
            this.dgvMuestra.Size = new System.Drawing.Size(864, 355);
            this.dgvMuestra.TabIndex = 27;
            this.dgvMuestra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestra_CellClick);
            this.dgvMuestra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestra_CellClick);
            // 
            // frmBusquedaAvanzadaCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbContenedorMuestra);
            this.Controls.Add(this.gbContenedorVista);
            this.Controls.Add(this.gbContenedorFiltro);
            this.Controls.Add(this.gbContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaAvanzadaCasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda avanzada";
            this.Load += new System.EventHandler(this.frmBusquedaAvanzadaCasos_Load);
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            this.gbContenedorFiltro.ResumeLayout(false);
            this.gbContenedorFiltro.PerformLayout();
            this.gbContenedorVista.ResumeLayout(false);
            this.gbContenedorVista.PerformLayout();
            this.gbContenedorMuestra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.CheckBox chbCP;
        private System.Windows.Forms.CheckBox chbIntervencion;
        private System.Windows.Forms.CheckBox chbFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbIntervencion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIntervencion;
        private System.Windows.Forms.GroupBox gbContenedorFiltro;
        private System.Windows.Forms.ComboBox cbCP;
        private System.Windows.Forms.GroupBox gbContenedorVista;
        private System.Windows.Forms.RadioButton rbAntiguo;
        private System.Windows.Forms.RadioButton rbReciente;
        private System.Windows.Forms.Label lblCaso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHerramientas;
        private System.Windows.Forms.Label lblHerramientas;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCaso;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbContenedorMuestra;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.Label lblCP;
    }
}