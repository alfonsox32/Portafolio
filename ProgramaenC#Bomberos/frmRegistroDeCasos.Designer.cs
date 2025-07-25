namespace SistemaBSPC
{
    partial class frmRegistroDeCasos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeCasos));
            this.gbNuevoCaso = new System.Windows.Forms.GroupBox();
            this.btnNuevaHerramienta = new System.Windows.Forms.Button();
            this.lsbxListaHerramientas = new System.Windows.Forms.ListBox();
            this.lblHerramientas = new System.Windows.Forms.Label();
            this.txtDireccionCaso = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDescripcionCaso = new System.Windows.Forms.TextBox();
            this.lblDescripcionCaso = new System.Windows.Forms.Label();
            this.cbTipoCaso = new System.Windows.Forms.ComboBox();
            this.lblTipoCaso = new System.Windows.Forms.Label();
            this.cBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.btnAgregarCaso = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.dgvCasos = new System.Windows.Forms.DataGridView();
            this.gbNuevoCaso.SuspendLayout();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoCaso
            // 
            this.gbNuevoCaso.Controls.Add(this.btnNuevaHerramienta);
            this.gbNuevoCaso.Controls.Add(this.lsbxListaHerramientas);
            this.gbNuevoCaso.Controls.Add(this.lblHerramientas);
            this.gbNuevoCaso.Controls.Add(this.txtDireccionCaso);
            this.gbNuevoCaso.Controls.Add(this.lblDireccion);
            this.gbNuevoCaso.Controls.Add(this.txtDescripcionCaso);
            this.gbNuevoCaso.Controls.Add(this.lblDescripcionCaso);
            this.gbNuevoCaso.Controls.Add(this.cbTipoCaso);
            this.gbNuevoCaso.Controls.Add(this.lblTipoCaso);
            this.gbNuevoCaso.Controls.Add(this.cBoxLocalidad);
            this.gbNuevoCaso.Controls.Add(this.btnAgregarCaso);
            this.gbNuevoCaso.Controls.Add(this.label6);
            this.gbNuevoCaso.Controls.Add(this.lblInstruccion);
            this.gbNuevoCaso.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoCaso.Location = new System.Drawing.Point(13, 13);
            this.gbNuevoCaso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbNuevoCaso.Name = "gbNuevoCaso";
            this.gbNuevoCaso.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbNuevoCaso.Size = new System.Drawing.Size(1243, 394);
            this.gbNuevoCaso.TabIndex = 0;
            this.gbNuevoCaso.TabStop = false;
            this.gbNuevoCaso.Text = "Crear nuevo caso";
            // 
            // btnNuevaHerramienta
            // 
            this.btnNuevaHerramienta.BackColor = System.Drawing.Color.White;
            this.btnNuevaHerramienta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevaHerramienta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnNuevaHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaHerramienta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaHerramienta.Image = global::SistemaBSPC.Properties.Resources.img10;
            this.btnNuevaHerramienta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaHerramienta.Location = new System.Drawing.Point(473, 247);
            this.btnNuevaHerramienta.Name = "btnNuevaHerramienta";
            this.btnNuevaHerramienta.Size = new System.Drawing.Size(242, 35);
            this.btnNuevaHerramienta.TabIndex = 9;
            this.btnNuevaHerramienta.Text = "Registrar nueva herramienta";
            this.btnNuevaHerramienta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaHerramienta.UseVisualStyleBackColor = false;
            this.btnNuevaHerramienta.Click += new System.EventHandler(this.btnNuevaHerramienta_Click);
            // 
            // lsbxListaHerramientas
            // 
            this.lsbxListaHerramientas.BackColor = System.Drawing.Color.White;
            this.lsbxListaHerramientas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbxListaHerramientas.FormattingEnabled = true;
            this.lsbxListaHerramientas.ItemHeight = 21;
            this.lsbxListaHerramientas.Location = new System.Drawing.Point(125, 226);
            this.lsbxListaHerramientas.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lsbxListaHerramientas.Name = "lsbxListaHerramientas";
            this.lsbxListaHerramientas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbxListaHerramientas.Size = new System.Drawing.Size(343, 67);
            this.lsbxListaHerramientas.TabIndex = 8;
            this.lsbxListaHerramientas.SelectedIndexChanged += new System.EventHandler(this.lsbxListaHerramientas_SelectedIndexChanged);
            // 
            // lblHerramientas
            // 
            this.lblHerramientas.AutoSize = true;
            this.lblHerramientas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerramientas.Location = new System.Drawing.Point(7, 226);
            this.lblHerramientas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHerramientas.Name = "lblHerramientas";
            this.lblHerramientas.Size = new System.Drawing.Size(107, 21);
            this.lblHerramientas.TabIndex = 7;
            this.lblHerramientas.Text = "Herramientas:";
            // 
            // txtDireccionCaso
            // 
            this.txtDireccionCaso.BackColor = System.Drawing.Color.White;
            this.txtDireccionCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCaso.Location = new System.Drawing.Point(125, 180);
            this.txtDireccionCaso.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDireccionCaso.Name = "txtDireccionCaso";
            this.txtDireccionCaso.Size = new System.Drawing.Size(343, 29);
            this.txtDireccionCaso.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(37, 189);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 21);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDescripcionCaso
            // 
            this.txtDescripcionCaso.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCaso.Location = new System.Drawing.Point(125, 312);
            this.txtDescripcionCaso.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDescripcionCaso.Multiline = true;
            this.txtDescripcionCaso.Name = "txtDescripcionCaso";
            this.txtDescripcionCaso.Size = new System.Drawing.Size(486, 74);
            this.txtDescripcionCaso.TabIndex = 11;
            // 
            // lblDescripcionCaso
            // 
            this.lblDescripcionCaso.AutoSize = true;
            this.lblDescripcionCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCaso.Location = new System.Drawing.Point(21, 312);
            this.lblDescripcionCaso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionCaso.Name = "lblDescripcionCaso";
            this.lblDescripcionCaso.Size = new System.Drawing.Size(94, 21);
            this.lblDescripcionCaso.TabIndex = 10;
            this.lblDescripcionCaso.Text = "Descripción:";
            // 
            // cbTipoCaso
            // 
            this.cbTipoCaso.BackColor = System.Drawing.Color.White;
            this.cbTipoCaso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCaso.FormattingEnabled = true;
            this.cbTipoCaso.Items.AddRange(new object[] {
            "Accidentes",
            "Ayuda comunitaria",
            "Alojamientos",
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
            this.cbTipoCaso.Location = new System.Drawing.Point(125, 86);
            this.cbTipoCaso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTipoCaso.Name = "cbTipoCaso";
            this.cbTipoCaso.Size = new System.Drawing.Size(224, 29);
            this.cbTipoCaso.TabIndex = 1;
            // 
            // lblTipoCaso
            // 
            this.lblTipoCaso.AutoSize = true;
            this.lblTipoCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCaso.Location = new System.Drawing.Point(16, 94);
            this.lblTipoCaso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCaso.Name = "lblTipoCaso";
            this.lblTipoCaso.Size = new System.Drawing.Size(99, 21);
            this.lblTipoCaso.TabIndex = 1;
            this.lblTipoCaso.Text = "Tipo de caso:";
            // 
            // cBoxLocalidad
            // 
            this.cBoxLocalidad.BackColor = System.Drawing.Color.White;
            this.cBoxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLocalidad.FormattingEnabled = true;
            this.cBoxLocalidad.Location = new System.Drawing.Point(125, 133);
            this.cBoxLocalidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cBoxLocalidad.Name = "cBoxLocalidad";
            this.cBoxLocalidad.Size = new System.Drawing.Size(343, 29);
            this.cBoxLocalidad.TabIndex = 4;
            // 
            // btnAgregarCaso
            // 
            this.btnAgregarCaso.BackColor = System.Drawing.Color.White;
            this.btnAgregarCaso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarCaso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnAgregarCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCaso.Image = global::SistemaBSPC.Properties.Resources.img8;
            this.btnAgregarCaso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCaso.Location = new System.Drawing.Point(1102, 338);
            this.btnAgregarCaso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarCaso.Name = "btnAgregarCaso";
            this.btnAgregarCaso.Size = new System.Drawing.Size(131, 48);
            this.btnAgregarCaso.TabIndex = 12;
            this.btnAgregarCaso.Text = "Agregar   ";
            this.btnAgregarCaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCaso.UseVisualStyleBackColor = false;
            this.btnAgregarCaso.Click += new System.EventHandler(this.btnAgregarCaso_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Localidad:";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(12, 40);
            this.lblInstruccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(306, 21);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Favor de ingresar la información solicitada.";
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.dgvCasos);
            this.gbContenedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(13, 414);
            this.gbContenedor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbContenedor.Size = new System.Drawing.Size(1240, 254);
            this.gbContenedor.TabIndex = 2;
            this.gbContenedor.TabStop = false;
            // 
            // dgvCasos
            // 
            this.dgvCasos.AllowUserToAddRows = false;
            this.dgvCasos.AllowUserToDeleteRows = false;
            this.dgvCasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCasos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasos.Location = new System.Drawing.Point(9, 29);
            this.dgvCasos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvCasos.Name = "dgvCasos";
            this.dgvCasos.ReadOnly = true;
            this.dgvCasos.RowHeadersWidth = 51;
            this.dgvCasos.RowTemplate.Height = 24;
            this.dgvCasos.Size = new System.Drawing.Size(1224, 217);
            this.dgvCasos.TabIndex = 13;
            // 
            // frmRegistroDeCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbContenedor);
            this.Controls.Add(this.gbNuevoCaso);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroDeCasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de casos";
            this.gbNuevoCaso.ResumeLayout(false);
            this.gbNuevoCaso.PerformLayout();
            this.gbContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoCaso;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarCaso;
        private System.Windows.Forms.ComboBox cBoxLocalidad;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.DataGridView dgvCasos;
        private System.Windows.Forms.ComboBox cbTipoCaso;
        private System.Windows.Forms.Label lblTipoCaso;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDescripcionCaso;
        private System.Windows.Forms.Label lblDescripcionCaso;
        private System.Windows.Forms.TextBox txtDireccionCaso;
        private System.Windows.Forms.Label lblHerramientas;
        private System.Windows.Forms.ListBox lsbxListaHerramientas;
        private System.Windows.Forms.Button btnNuevaHerramienta;
    }
}