namespace SistemaBSPC
{
    partial class frmMostrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarUsuarios));
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.gbMostrarBD = new System.Windows.Forms.GroupBox();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gbContenedor.SuspendLayout();
            this.gbMostrarBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.gbMostrarBD);
            this.gbContenedor.Controls.Add(this.lblMensaje);
            this.gbContenedor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(15, 15);
            this.gbContenedor.Margin = new System.Windows.Forms.Padding(6);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Padding = new System.Windows.Forms.Padding(6);
            this.gbContenedor.Size = new System.Drawing.Size(1234, 651);
            this.gbContenedor.TabIndex = 2;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Información";
            // 
            // gbMostrarBD
            // 
            this.gbMostrarBD.Controls.Add(this.dgvMuestra);
            this.gbMostrarBD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMostrarBD.Location = new System.Drawing.Point(10, 68);
            this.gbMostrarBD.Name = "gbMostrarBD";
            this.gbMostrarBD.Size = new System.Drawing.Size(1215, 574);
            this.gbMostrarBD.TabIndex = 2;
            this.gbMostrarBD.TabStop = false;
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
            this.dgvMuestra.Size = new System.Drawing.Size(1203, 540);
            this.dgvMuestra.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(13, 44);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(397, 21);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Aquí se muestran los usuarios registrados en el sistema.";
            // 
            // frmMostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios registrados";
            this.Load += new System.EventHandler(this.frmMostrarUsuarios_Load);
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            this.gbMostrarBD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.GroupBox gbMostrarBD;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.Label lblMensaje;
    }
}