namespace SistemaBSPC
{
    partial class frmHerramienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHerramienta));
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarHerramienta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.txtModificarHerramientaClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtModificarHerramienta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInsertar = new System.Windows.Forms.GroupBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtInsertarHerramienta = new System.Windows.Forms.TextBox();
            this.lblInsertar = new System.Windows.Forms.Label();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.gbInformacion.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            this.gbModificar.SuspendLayout();
            this.gbInsertar.SuspendLayout();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.gbEliminar);
            this.gbInformacion.Controls.Add(this.gbModificar);
            this.gbInformacion.Controls.Add(this.gbInsertar);
            this.gbInformacion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(13, 13);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(333, 462);
            this.gbInformacion.TabIndex = 0;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Instrucciones";
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.txtEliminarHerramienta);
            this.gbEliminar.Controls.Add(this.label2);
            this.gbEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminar.Location = new System.Drawing.Point(6, 348);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(321, 108);
            this.gbEliminar.TabIndex = 2;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SistemaBSPC.Properties.Resources.img7;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(214, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 33);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarHerramienta
            // 
            this.txtEliminarHerramienta.BackColor = System.Drawing.Color.White;
            this.txtEliminarHerramienta.Location = new System.Drawing.Point(12, 59);
            this.txtEliminarHerramienta.Name = "txtEliminarHerramienta";
            this.txtEliminarHerramienta.Size = new System.Drawing.Size(153, 29);
            this.txtEliminarHerramienta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribir la clave de la herramienta";
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.txtModificarHerramientaClave);
            this.gbModificar.Controls.Add(this.label3);
            this.gbModificar.Controls.Add(this.btnModificar);
            this.gbModificar.Controls.Add(this.txtModificarHerramienta);
            this.gbModificar.Controls.Add(this.label1);
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificar.Location = new System.Drawing.Point(6, 157);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(321, 185);
            this.gbModificar.TabIndex = 1;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar";
            // 
            // txtModificarHerramientaClave
            // 
            this.txtModificarHerramientaClave.BackColor = System.Drawing.Color.White;
            this.txtModificarHerramientaClave.Location = new System.Drawing.Point(14, 133);
            this.txtModificarHerramientaClave.Name = "txtModificarHerramientaClave";
            this.txtModificarHerramientaClave.Size = new System.Drawing.Size(151, 29);
            this.txtModificarHerramientaClave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escribir la clave de la herramienta";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::SistemaBSPC.Properties.Resources.img6;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(204, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 33);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtModificarHerramienta
            // 
            this.txtModificarHerramienta.BackColor = System.Drawing.Color.White;
            this.txtModificarHerramienta.Location = new System.Drawing.Point(12, 58);
            this.txtModificarHerramienta.Name = "txtModificarHerramienta";
            this.txtModificarHerramienta.Size = new System.Drawing.Size(196, 29);
            this.txtModificarHerramienta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribir el nombre de la herramienta";
            // 
            // gbInsertar
            // 
            this.gbInsertar.Controls.Add(this.btnInsertar);
            this.gbInsertar.Controls.Add(this.txtInsertarHerramienta);
            this.gbInsertar.Controls.Add(this.lblInsertar);
            this.gbInsertar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertar.Location = new System.Drawing.Point(7, 29);
            this.gbInsertar.Name = "gbInsertar";
            this.gbInsertar.Size = new System.Drawing.Size(320, 122);
            this.gbInsertar.TabIndex = 0;
            this.gbInsertar.TabStop = false;
            this.gbInsertar.Text = "Insertar";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.White;
            this.btnInsertar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Image = global::SistemaBSPC.Properties.Resources.img8;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(213, 83);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(101, 33);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtInsertarHerramienta
            // 
            this.txtInsertarHerramienta.BackColor = System.Drawing.Color.White;
            this.txtInsertarHerramienta.Location = new System.Drawing.Point(11, 63);
            this.txtInsertarHerramienta.Name = "txtInsertarHerramienta";
            this.txtInsertarHerramienta.Size = new System.Drawing.Size(196, 29);
            this.txtInsertarHerramienta.TabIndex = 1;
            // 
            // lblInsertar
            // 
            this.lblInsertar.AutoSize = true;
            this.lblInsertar.Location = new System.Drawing.Point(7, 29);
            this.lblInsertar.Name = "lblInsertar";
            this.lblInsertar.Size = new System.Drawing.Size(308, 21);
            this.lblInsertar.TabIndex = 0;
            this.lblInsertar.Text = "Escribir el nombre de la nueva herramienta";
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.dgvMuestra);
            this.gbContenedor.Location = new System.Drawing.Point(352, 13);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(383, 462);
            this.gbContenedor.TabIndex = 1;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Información";
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
            this.dgvMuestra.Size = new System.Drawing.Size(371, 428);
            this.dgvMuestra.TabIndex = 0;
            // 
            // frmHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 487);
            this.Controls.Add(this.gbContenedor);
            this.Controls.Add(this.gbInformacion);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHerramienta";
            this.Text = "Herramienta";
            this.gbInformacion.ResumeLayout(false);
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.gbInsertar.ResumeLayout(false);
            this.gbInsertar.PerformLayout();
            this.gbContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.GroupBox gbInsertar;
        private System.Windows.Forms.Label lblInsertar;
        private System.Windows.Forms.TextBox txtEliminarHerramienta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtModificarHerramienta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtInsertarHerramienta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtModificarHerramientaClave;
        private System.Windows.Forms.Label label3;
    }
}