namespace SistemaBSPC
{
    partial class frmModificaionDeCaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaionDeCaso));
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.lsbxListaHerramientas = new System.Windows.Forms.ListBox();
            this.lblHerramientas = new System.Windows.Forms.Label();
            this.lblClaveInformacion = new System.Windows.Forms.Label();
            this.txtClaveCaso = new System.Windows.Forms.TextBox();
            this.btnModificarCaso = new System.Windows.Forms.Button();
            this.txtDireccionCaso = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDescripcionCaso = new System.Windows.Forms.TextBox();
            this.lblDescripcionCaso = new System.Windows.Forms.Label();
            this.cbTipoCaso = new System.Windows.Forms.ComboBox();
            this.lblTipoCaso = new System.Windows.Forms.Label();
            this.cBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.gvVista = new System.Windows.Forms.GroupBox();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.gbContenedor.SuspendLayout();
            this.gvVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.lsbxListaHerramientas);
            this.gbContenedor.Controls.Add(this.lblHerramientas);
            this.gbContenedor.Controls.Add(this.lblClaveInformacion);
            this.gbContenedor.Controls.Add(this.txtClaveCaso);
            this.gbContenedor.Controls.Add(this.btnModificarCaso);
            this.gbContenedor.Controls.Add(this.txtDireccionCaso);
            this.gbContenedor.Controls.Add(this.lblDireccion);
            this.gbContenedor.Controls.Add(this.txtDescripcionCaso);
            this.gbContenedor.Controls.Add(this.lblDescripcionCaso);
            this.gbContenedor.Controls.Add(this.cbTipoCaso);
            this.gbContenedor.Controls.Add(this.lblTipoCaso);
            this.gbContenedor.Controls.Add(this.cBoxLocalidad);
            this.gbContenedor.Controls.Add(this.label6);
            this.gbContenedor.Controls.Add(this.lblInformacion);
            this.gbContenedor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(14, 13);
            this.gbContenedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbContenedor.Size = new System.Drawing.Size(1236, 362);
            this.gbContenedor.TabIndex = 0;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Modificar casos";
            // 
            // lsbxListaHerramientas
            // 
            this.lsbxListaHerramientas.BackColor = System.Drawing.Color.White;
            this.lsbxListaHerramientas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbxListaHerramientas.FormattingEnabled = true;
            this.lsbxListaHerramientas.ItemHeight = 21;
            this.lsbxListaHerramientas.Location = new System.Drawing.Point(125, 287);
            this.lsbxListaHerramientas.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lsbxListaHerramientas.Name = "lsbxListaHerramientas";
            this.lsbxListaHerramientas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbxListaHerramientas.Size = new System.Drawing.Size(343, 67);
            this.lsbxListaHerramientas.TabIndex = 11;
            this.lsbxListaHerramientas.SelectedIndexChanged += new System.EventHandler(this.lsbxListaHerramientas_SelectedIndexChanged);
            // 
            // lblHerramientas
            // 
            this.lblHerramientas.AutoSize = true;
            this.lblHerramientas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerramientas.Location = new System.Drawing.Point(7, 287);
            this.lblHerramientas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHerramientas.Name = "lblHerramientas";
            this.lblHerramientas.Size = new System.Drawing.Size(107, 21);
            this.lblHerramientas.TabIndex = 10;
            this.lblHerramientas.Text = "Herramientas:";
            // 
            // lblClaveInformacion
            // 
            this.lblClaveInformacion.AutoSize = true;
            this.lblClaveInformacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveInformacion.Location = new System.Drawing.Point(8, 89);
            this.lblClaveInformacion.Name = "lblClaveInformacion";
            this.lblClaveInformacion.Size = new System.Drawing.Size(111, 21);
            this.lblClaveInformacion.TabIndex = 2;
            this.lblClaveInformacion.Text = "Clave del caso:";
            // 
            // txtClaveCaso
            // 
            this.txtClaveCaso.BackColor = System.Drawing.Color.White;
            this.txtClaveCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCaso.Location = new System.Drawing.Point(125, 81);
            this.txtClaveCaso.Name = "txtClaveCaso";
            this.txtClaveCaso.Size = new System.Drawing.Size(214, 29);
            this.txtClaveCaso.TabIndex = 3;
            // 
            // btnModificarCaso
            // 
            this.btnModificarCaso.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCaso.Image = global::SistemaBSPC.Properties.Resources.img6;
            this.btnModificarCaso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCaso.Location = new System.Drawing.Point(1084, 301);
            this.btnModificarCaso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnModificarCaso.Name = "btnModificarCaso";
            this.btnModificarCaso.Size = new System.Drawing.Size(132, 43);
            this.btnModificarCaso.TabIndex = 14;
            this.btnModificarCaso.Text = "Modificar";
            this.btnModificarCaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarCaso.UseVisualStyleBackColor = false;
            this.btnModificarCaso.Click += new System.EventHandler(this.btnModificarCaso_Click);
            // 
            // txtDireccionCaso
            // 
            this.txtDireccionCaso.BackColor = System.Drawing.Color.White;
            this.txtDireccionCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCaso.Location = new System.Drawing.Point(125, 229);
            this.txtDireccionCaso.Name = "txtDireccionCaso";
            this.txtDireccionCaso.Size = new System.Drawing.Size(343, 29);
            this.txtDireccionCaso.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(29, 237);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 21);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDescripcionCaso
            // 
            this.txtDescripcionCaso.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCaso.Location = new System.Drawing.Point(561, 126);
            this.txtDescripcionCaso.Multiline = true;
            this.txtDescripcionCaso.Name = "txtDescripcionCaso";
            this.txtDescripcionCaso.Size = new System.Drawing.Size(486, 157);
            this.txtDescripcionCaso.TabIndex = 13;
            // 
            // lblDescripcionCaso
            // 
            this.lblDescripcionCaso.AutoSize = true;
            this.lblDescripcionCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCaso.Location = new System.Drawing.Point(557, 89);
            this.lblDescripcionCaso.Name = "lblDescripcionCaso";
            this.lblDescripcionCaso.Size = new System.Drawing.Size(94, 21);
            this.lblDescripcionCaso.TabIndex = 12;
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
            this.cbTipoCaso.Location = new System.Drawing.Point(125, 126);
            this.cbTipoCaso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTipoCaso.Name = "cbTipoCaso";
            this.cbTipoCaso.Size = new System.Drawing.Size(224, 29);
            this.cbTipoCaso.TabIndex = 5;
            // 
            // lblTipoCaso
            // 
            this.lblTipoCaso.AutoSize = true;
            this.lblTipoCaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCaso.Location = new System.Drawing.Point(8, 134);
            this.lblTipoCaso.Name = "lblTipoCaso";
            this.lblTipoCaso.Size = new System.Drawing.Size(99, 21);
            this.lblTipoCaso.TabIndex = 4;
            this.lblTipoCaso.Text = "Tipo de caso:";
            // 
            // cBoxLocalidad
            // 
            this.cBoxLocalidad.BackColor = System.Drawing.Color.White;
            this.cBoxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLocalidad.FormattingEnabled = true;
            this.cBoxLocalidad.Location = new System.Drawing.Point(125, 176);
            this.cBoxLocalidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cBoxLocalidad.Name = "cBoxLocalidad";
            this.cBoxLocalidad.Size = new System.Drawing.Size(343, 29);
            this.cBoxLocalidad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Localidad:";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(10, 44);
            this.lblInformacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(473, 21);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Modificar la información correspondiente solicitada en los cuadros:";
            // 
            // gvVista
            // 
            this.gvVista.Controls.Add(this.dgvMuestra);
            this.gvVista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVista.Location = new System.Drawing.Point(12, 387);
            this.gvVista.Name = "gvVista";
            this.gvVista.Size = new System.Drawing.Size(1238, 282);
            this.gvVista.TabIndex = 1;
            this.gvVista.TabStop = false;
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.AllowUserToAddRows = false;
            this.dgvMuestra.AllowUserToDeleteRows = false;
            this.dgvMuestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuestra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(8, 29);
            this.dgvMuestra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.ReadOnly = true;
            this.dgvMuestra.RowHeadersWidth = 51;
            this.dgvMuestra.Size = new System.Drawing.Size(1222, 246);
            this.dgvMuestra.TabIndex = 15;
            // 
            // frmModificaionDeCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gvVista);
            this.Controls.Add(this.gbContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificaionDeCaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificaión de casos";
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            this.gvVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.GroupBox gvVista;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.TextBox txtDireccionCaso;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDescripcionCaso;
        private System.Windows.Forms.Label lblDescripcionCaso;
        private System.Windows.Forms.ComboBox cbTipoCaso;
        private System.Windows.Forms.Label lblTipoCaso;
        private System.Windows.Forms.ComboBox cBoxLocalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificarCaso;
        private System.Windows.Forms.Label lblClaveInformacion;
        private System.Windows.Forms.TextBox txtClaveCaso;
        private System.Windows.Forms.ListBox lsbxListaHerramientas;
        private System.Windows.Forms.Label lblHerramientas;
    }
}