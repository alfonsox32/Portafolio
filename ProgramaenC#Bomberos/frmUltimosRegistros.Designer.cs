namespace SistemaBSPC
{
    partial class frmUltimosRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUltimosRegistros));
            this.gbUltimosCasosRegistrados = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gbUltimosCasosRegistrados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUltimosCasosRegistrados
            // 
            this.gbUltimosCasosRegistrados.Controls.Add(this.groupBox1);
            this.gbUltimosCasosRegistrados.Controls.Add(this.lblMensaje);
            this.gbUltimosCasosRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUltimosCasosRegistrados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUltimosCasosRegistrados.Location = new System.Drawing.Point(15, 15);
            this.gbUltimosCasosRegistrados.Margin = new System.Windows.Forms.Padding(6);
            this.gbUltimosCasosRegistrados.Name = "gbUltimosCasosRegistrados";
            this.gbUltimosCasosRegistrados.Padding = new System.Windows.Forms.Padding(6);
            this.gbUltimosCasosRegistrados.Size = new System.Drawing.Size(1234, 651);
            this.gbUltimosCasosRegistrados.TabIndex = 1;
            this.gbUltimosCasosRegistrados.TabStop = false;
            this.gbUltimosCasosRegistrados.Text = "Últimas intervenciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCP);
            this.groupBox1.Controls.Add(this.lblColonia);
            this.groupBox1.Controls.Add(this.lbDireccion);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.txtCP);
            this.groupBox1.Controls.Add(this.txtColonia);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtHerramientas);
            this.groupBox1.Controls.Add(this.lblHerramientas);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtCaso);
            this.groupBox1.Controls.Add(this.lblCaso);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.dgvMuestra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 582);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Location = new System.Drawing.Point(763, 21);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(105, 21);
            this.lbCP.TabIndex = 8;
            this.lbCP.Text = "Código Postal";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(208, 21);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(106, 21);
            this.lblColonia.TabIndex = 4;
            this.lblColonia.Text = "Colonia/Ejido:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(384, 21);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(78, 21);
            this.lbDireccion.TabIndex = 6;
            this.lbDireccion.Text = "Dirección:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(942, 21);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(53, 21);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.Text = "Fecha:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(767, 45);
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.Size = new System.Drawing.Size(158, 29);
            this.txtCP.TabIndex = 9;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(209, 45);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ReadOnly = true;
            this.txtColonia.Size = new System.Drawing.Size(158, 29);
            this.txtColonia.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(388, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(359, 29);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(946, 45);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(256, 29);
            this.txtFecha.TabIndex = 11;
            // 
            // txtHerramientas
            // 
            this.txtHerramientas.Location = new System.Drawing.Point(388, 118);
            this.txtHerramientas.Multiline = true;
            this.txtHerramientas.Name = "txtHerramientas";
            this.txtHerramientas.ReadOnly = true;
            this.txtHerramientas.Size = new System.Drawing.Size(306, 111);
            this.txtHerramientas.TabIndex = 15;
            // 
            // lblHerramientas
            // 
            this.lblHerramientas.AutoSize = true;
            this.lblHerramientas.Location = new System.Drawing.Point(384, 94);
            this.lblHerramientas.Name = "lblHerramientas";
            this.lblHerramientas.Size = new System.Drawing.Size(176, 21);
            this.lblHerramientas.TabIndex = 14;
            this.lblHerramientas.Text = "Herramientas utilizadas:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 94);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 21);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCaso
            // 
            this.txtCaso.Location = new System.Drawing.Point(6, 45);
            this.txtCaso.Name = "txtCaso";
            this.txtCaso.ReadOnly = true;
            this.txtCaso.Size = new System.Drawing.Size(184, 29);
            this.txtCaso.TabIndex = 3;
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.Location = new System.Drawing.Point(6, 21);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(47, 21);
            this.lblCaso.TabIndex = 2;
            this.lblCaso.Text = "Caso:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 118);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(361, 111);
            this.txtDescripcion.TabIndex = 13;
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.AllowUserToAddRows = false;
            this.dgvMuestra.AllowUserToDeleteRows = false;
            this.dgvMuestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuestra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(6, 250);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.ReadOnly = true;
            this.dgvMuestra.Size = new System.Drawing.Size(1196, 313);
            this.dgvMuestra.TabIndex = 16;
            this.dgvMuestra.SelectionChanged += new System.EventHandler(this.dgvMuestra_SelectionChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 36);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(683, 21);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Aquí se muestran las ultimas intervenciones que ha tenido el cuerpo de bomberos r" +
    "ecientemente.";
            // 
            // frmUltimosRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbUltimosCasosRegistrados);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUltimosRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimos casos registrados";
            this.Load += new System.EventHandler(this.frmUltimosRegistros_Load);
            this.gbUltimosCasosRegistrados.ResumeLayout(false);
            this.gbUltimosCasosRegistrados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUltimosCasosRegistrados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHerramientas;
        private System.Windows.Forms.Label lblHerramientas;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCaso;
        private System.Windows.Forms.Label lblCaso;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}