namespace SistemaBSPC
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.lblInformacionClaveUsuario = new System.Windows.Forms.Label();
            this.lblRolAdministrativoUsuario = new System.Windows.Forms.Label();
            this.lblInformacionRolAdministrativo = new System.Windows.Forms.Label();
            this.gbLogos = new System.Windows.Forms.GroupBox();
            this.pbLogoBomberos = new System.Windows.Forms.PictureBox();
            this.pbLogoProteccionCivil = new System.Windows.Forms.PictureBox();
            this.pbEscudoSP = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblInformacionNombre = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbContenedor.SuspendLayout();
            this.gbLogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBomberos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoProteccionCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbContenedor.Controls.Add(this.lblClaveUsuario);
            this.gbContenedor.Controls.Add(this.lblInformacionClaveUsuario);
            this.gbContenedor.Controls.Add(this.lblRolAdministrativoUsuario);
            this.gbContenedor.Controls.Add(this.lblInformacionRolAdministrativo);
            this.gbContenedor.Controls.Add(this.gbLogos);
            this.gbContenedor.Controls.Add(this.lblNombreUsuario);
            this.gbContenedor.Controls.Add(this.lblInformacionNombre);
            this.gbContenedor.Controls.Add(this.pbPerfil);
            this.gbContenedor.Location = new System.Drawing.Point(12, 12);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(608, 378);
            this.gbContenedor.TabIndex = 2;
            this.gbContenedor.TabStop = false;
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Location = new System.Drawing.Point(303, 179);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(104, 21);
            this.lblClaveUsuario.TabIndex = 4;
            this.lblClaveUsuario.Text = "Clave usuario";
            // 
            // lblInformacionClaveUsuario
            // 
            this.lblInformacionClaveUsuario.AutoSize = true;
            this.lblInformacionClaveUsuario.Location = new System.Drawing.Point(169, 179);
            this.lblInformacionClaveUsuario.Name = "lblInformacionClaveUsuario";
            this.lblInformacionClaveUsuario.Size = new System.Drawing.Size(128, 21);
            this.lblInformacionClaveUsuario.TabIndex = 3;
            this.lblInformacionClaveUsuario.Text = "Clave de usuario:";
            // 
            // lblRolAdministrativoUsuario
            // 
            this.lblRolAdministrativoUsuario.AutoSize = true;
            this.lblRolAdministrativoUsuario.Location = new System.Drawing.Point(303, 256);
            this.lblRolAdministrativoUsuario.Name = "lblRolAdministrativoUsuario";
            this.lblRolAdministrativoUsuario.Size = new System.Drawing.Size(186, 21);
            this.lblRolAdministrativoUsuario.TabIndex = 8;
            this.lblRolAdministrativoUsuario.Text = "Secretario-Administrador";
            // 
            // lblInformacionRolAdministrativo
            // 
            this.lblInformacionRolAdministrativo.AutoSize = true;
            this.lblInformacionRolAdministrativo.Location = new System.Drawing.Point(157, 256);
            this.lblInformacionRolAdministrativo.Name = "lblInformacionRolAdministrativo";
            this.lblInformacionRolAdministrativo.Size = new System.Drawing.Size(140, 21);
            this.lblInformacionRolAdministrativo.TabIndex = 7;
            this.lblInformacionRolAdministrativo.Text = "Rol administrativo:";
            // 
            // gbLogos
            // 
            this.gbLogos.Controls.Add(this.lblTitulo);
            this.gbLogos.Controls.Add(this.pbLogoBomberos);
            this.gbLogos.Controls.Add(this.pbLogoProteccionCivil);
            this.gbLogos.Controls.Add(this.pbEscudoSP);
            this.gbLogos.Location = new System.Drawing.Point(0, 0);
            this.gbLogos.Name = "gbLogos";
            this.gbLogos.Size = new System.Drawing.Size(608, 100);
            this.gbLogos.TabIndex = 2;
            this.gbLogos.TabStop = false;
            // 
            // pbLogoBomberos
            // 
            this.pbLogoBomberos.Image = global::SistemaBSPC.Properties.Resources.img3;
            this.pbLogoBomberos.Location = new System.Drawing.Point(6, 22);
            this.pbLogoBomberos.Name = "pbLogoBomberos";
            this.pbLogoBomberos.Size = new System.Drawing.Size(62, 72);
            this.pbLogoBomberos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoBomberos.TabIndex = 3;
            this.pbLogoBomberos.TabStop = false;
            // 
            // pbLogoProteccionCivil
            // 
            this.pbLogoProteccionCivil.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoProteccionCivil.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoProteccionCivil.Image")));
            this.pbLogoProteccionCivil.Location = new System.Drawing.Point(393, 22);
            this.pbLogoProteccionCivil.Name = "pbLogoProteccionCivil";
            this.pbLogoProteccionCivil.Size = new System.Drawing.Size(110, 72);
            this.pbLogoProteccionCivil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoProteccionCivil.TabIndex = 4;
            this.pbLogoProteccionCivil.TabStop = false;
            // 
            // pbEscudoSP
            // 
            this.pbEscudoSP.Image = global::SistemaBSPC.Properties.Resources.img13;
            this.pbEscudoSP.Location = new System.Drawing.Point(526, 22);
            this.pbEscudoSP.Name = "pbEscudoSP";
            this.pbEscudoSP.Size = new System.Drawing.Size(90, 72);
            this.pbEscudoSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEscudoSP.TabIndex = 5;
            this.pbEscudoSP.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(303, 214);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(124, 21);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre usuario";
            // 
            // lblInformacionNombre
            // 
            this.lblInformacionNombre.AutoSize = true;
            this.lblInformacionNombre.Location = new System.Drawing.Point(226, 214);
            this.lblInformacionNombre.Name = "lblInformacionNombre";
            this.lblInformacionNombre.Size = new System.Drawing.Size(71, 21);
            this.lblInformacionNombre.TabIndex = 5;
            this.lblInformacionNombre.Text = "Nombre:";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::SistemaBSPC.Properties.Resources.img11;
            this.pbPerfil.Location = new System.Drawing.Point(27, 168);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(106, 119);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerfil.TabIndex = 0;
            this.pbPerfil.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Bomberos San Pedro Coahuila";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 402);
            this.Controls.Add(this.gbContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            this.gbLogos.ResumeLayout(false);
            this.gbLogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBomberos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoProteccionCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.Label lblInformacionClaveUsuario;
        private System.Windows.Forms.Label lblRolAdministrativoUsuario;
        private System.Windows.Forms.Label lblInformacionRolAdministrativo;
        private System.Windows.Forms.GroupBox gbLogos;
        private System.Windows.Forms.PictureBox pbLogoBomberos;
        private System.Windows.Forms.PictureBox pbLogoProteccionCivil;
        private System.Windows.Forms.PictureBox pbEscudoSP;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblInformacionNombre;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblTitulo;
    }
}