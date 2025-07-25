namespace SistemaBSPC
{
    partial class frmRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarUsuario));
            this.gbNuevoUsuario = new System.Windows.Forms.GroupBox();
            this.cbRolUsuarioCrear = new System.Windows.Forms.ComboBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.pbOcultarContrasena = new System.Windows.Forms.PictureBox();
            this.txtConfirmarContrasenaNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenaNuevoUsuario = new System.Windows.Forms.Label();
            this.txtContrasenaNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenaNuevoUsuario = new System.Windows.Forms.Label();
            this.lblRolNuevoUsuario = new System.Windows.Forms.Label();
            this.txtNombreNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevoNombreUsuario = new System.Windows.Forms.Label();
            this.lblCodigoNuevoUsuario = new System.Windows.Forms.Label();
            this.gbModificarUsuario = new System.Windows.Forms.GroupBox();
            this.cbSeleccionarRol = new System.Windows.Forms.ComboBox();
            this.txtCodigoUsuarioModificar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.pbMostrarOcultarContrasenaModificar = new System.Windows.Forms.PictureBox();
            this.txtConfirmarContrasenaModificar = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenaModificar = new System.Windows.Forms.Label();
            this.txtContraseñaUsuarioModificar = new System.Windows.Forms.TextBox();
            this.lblContraseñaUsuarioModificar = new System.Windows.Forms.Label();
            this.lblRolUsuarioModificar = new System.Windows.Forms.Label();
            this.txtNombreUsuarioModificar = new System.Windows.Forms.TextBox();
            this.lblNombreUsuarioModificar = new System.Windows.Forms.Label();
            this.gbEliminarUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtCodigoUsuarioEliminar = new System.Windows.Forms.TextBox();
            this.lblCodigoUsuarioEliminar = new System.Windows.Forms.Label();
            this.gbMuestra = new System.Windows.Forms.GroupBox();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.gbNuevoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarContrasena)).BeginInit();
            this.gbModificarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarOcultarContrasenaModificar)).BeginInit();
            this.gbEliminarUsuario.SuspendLayout();
            this.gbMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoUsuario
            // 
            this.gbNuevoUsuario.Controls.Add(this.cbRolUsuarioCrear);
            this.gbNuevoUsuario.Controls.Add(this.btnCrearUsuario);
            this.gbNuevoUsuario.Controls.Add(this.pbOcultarContrasena);
            this.gbNuevoUsuario.Controls.Add(this.txtConfirmarContrasenaNuevoUsuario);
            this.gbNuevoUsuario.Controls.Add(this.lblConfirmarContrasenaNuevoUsuario);
            this.gbNuevoUsuario.Controls.Add(this.txtContrasenaNuevoUsuario);
            this.gbNuevoUsuario.Controls.Add(this.lblContrasenaNuevoUsuario);
            this.gbNuevoUsuario.Controls.Add(this.lblRolNuevoUsuario);
            this.gbNuevoUsuario.Controls.Add(this.txtNombreNuevoUsuario);
            this.gbNuevoUsuario.Controls.Add(this.lblNuevoNombreUsuario);
            this.gbNuevoUsuario.Controls.Add(this.lblCodigoNuevoUsuario);
            this.gbNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNuevoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoUsuario.Location = new System.Drawing.Point(15, 15);
            this.gbNuevoUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.gbNuevoUsuario.Name = "gbNuevoUsuario";
            this.gbNuevoUsuario.Padding = new System.Windows.Forms.Padding(6);
            this.gbNuevoUsuario.Size = new System.Drawing.Size(1226, 278);
            this.gbNuevoUsuario.TabIndex = 0;
            this.gbNuevoUsuario.TabStop = false;
            this.gbNuevoUsuario.Text = "Crear nuevo usuario";
            // 
            // cbRolUsuarioCrear
            // 
            this.cbRolUsuarioCrear.BackColor = System.Drawing.Color.White;
            this.cbRolUsuarioCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRolUsuarioCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRolUsuarioCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRolUsuarioCrear.FormattingEnabled = true;
            this.cbRolUsuarioCrear.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria(o)"});
            this.cbRolUsuarioCrear.Location = new System.Drawing.Point(197, 129);
            this.cbRolUsuarioCrear.Margin = new System.Windows.Forms.Padding(6);
            this.cbRolUsuarioCrear.Name = "cbRolUsuarioCrear";
            this.cbRolUsuarioCrear.Size = new System.Drawing.Size(470, 29);
            this.cbRolUsuarioCrear.TabIndex = 4;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.White;
            this.btnCrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Image = global::SistemaBSPC.Properties.Resources.img8;
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearUsuario.Location = new System.Drawing.Point(1031, 206);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(183, 48);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Crear usuario   ";
            this.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // pbOcultarContrasena
            // 
            this.pbOcultarContrasena.Image = global::SistemaBSPC.Properties.Resources.img1;
            this.pbOcultarContrasena.Location = new System.Drawing.Point(697, 216);
            this.pbOcultarContrasena.Margin = new System.Windows.Forms.Padding(6);
            this.pbOcultarContrasena.Name = "pbOcultarContrasena";
            this.pbOcultarContrasena.Size = new System.Drawing.Size(37, 33);
            this.pbOcultarContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultarContrasena.TabIndex = 10;
            this.pbOcultarContrasena.TabStop = false;
            this.pbOcultarContrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOcultarContrasena_MouseDown);
            this.pbOcultarContrasena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbOcultarContrasena_MouseUp);
            // 
            // txtConfirmarContrasenaNuevoUsuario
            // 
            this.txtConfirmarContrasenaNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.txtConfirmarContrasenaNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasenaNuevoUsuario.Location = new System.Drawing.Point(197, 220);
            this.txtConfirmarContrasenaNuevoUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirmarContrasenaNuevoUsuario.MaxLength = 100;
            this.txtConfirmarContrasenaNuevoUsuario.Name = "txtConfirmarContrasenaNuevoUsuario";
            this.txtConfirmarContrasenaNuevoUsuario.Size = new System.Drawing.Size(470, 29);
            this.txtConfirmarContrasenaNuevoUsuario.TabIndex = 8;
            this.txtConfirmarContrasenaNuevoUsuario.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasenaNuevoUsuario
            // 
            this.lblConfirmarContrasenaNuevoUsuario.AutoSize = true;
            this.lblConfirmarContrasenaNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasenaNuevoUsuario.Location = new System.Drawing.Point(21, 228);
            this.lblConfirmarContrasenaNuevoUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmarContrasenaNuevoUsuario.Name = "lblConfirmarContrasenaNuevoUsuario";
            this.lblConfirmarContrasenaNuevoUsuario.Size = new System.Drawing.Size(164, 21);
            this.lblConfirmarContrasenaNuevoUsuario.TabIndex = 7;
            this.lblConfirmarContrasenaNuevoUsuario.Text = "Confirmar contraseña:";
            // 
            // txtContrasenaNuevoUsuario
            // 
            this.txtContrasenaNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.txtContrasenaNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaNuevoUsuario.Location = new System.Drawing.Point(197, 177);
            this.txtContrasenaNuevoUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtContrasenaNuevoUsuario.MaxLength = 100;
            this.txtContrasenaNuevoUsuario.Name = "txtContrasenaNuevoUsuario";
            this.txtContrasenaNuevoUsuario.Size = new System.Drawing.Size(470, 29);
            this.txtContrasenaNuevoUsuario.TabIndex = 6;
            this.txtContrasenaNuevoUsuario.UseSystemPasswordChar = true;
            // 
            // lblContrasenaNuevoUsuario
            // 
            this.lblContrasenaNuevoUsuario.AutoSize = true;
            this.lblContrasenaNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaNuevoUsuario.Location = new System.Drawing.Point(12, 185);
            this.lblContrasenaNuevoUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContrasenaNuevoUsuario.Name = "lblContrasenaNuevoUsuario";
            this.lblContrasenaNuevoUsuario.Size = new System.Drawing.Size(173, 21);
            this.lblContrasenaNuevoUsuario.TabIndex = 5;
            this.lblContrasenaNuevoUsuario.Text = "Contraseña del usuario:";
            // 
            // lblRolNuevoUsuario
            // 
            this.lblRolNuevoUsuario.AutoSize = true;
            this.lblRolNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolNuevoUsuario.Location = new System.Drawing.Point(59, 137);
            this.lblRolNuevoUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRolNuevoUsuario.Name = "lblRolNuevoUsuario";
            this.lblRolNuevoUsuario.Size = new System.Drawing.Size(117, 21);
            this.lblRolNuevoUsuario.TabIndex = 3;
            this.lblRolNuevoUsuario.Text = "Rol del usuario:";
            // 
            // txtNombreNuevoUsuario
            // 
            this.txtNombreNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevoUsuario.Location = new System.Drawing.Point(197, 82);
            this.txtNombreNuevoUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreNuevoUsuario.MaxLength = 100;
            this.txtNombreNuevoUsuario.Name = "txtNombreNuevoUsuario";
            this.txtNombreNuevoUsuario.Size = new System.Drawing.Size(470, 29);
            this.txtNombreNuevoUsuario.TabIndex = 2;
            // 
            // lblNuevoNombreUsuario
            // 
            this.lblNuevoNombreUsuario.AutoSize = true;
            this.lblNuevoNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombreUsuario.Location = new System.Drawing.Point(37, 90);
            this.lblNuevoNombreUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNuevoNombreUsuario.Name = "lblNuevoNombreUsuario";
            this.lblNuevoNombreUsuario.Size = new System.Drawing.Size(148, 21);
            this.lblNuevoNombreUsuario.TabIndex = 1;
            this.lblNuevoNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblCodigoNuevoUsuario
            // 
            this.lblCodigoNuevoUsuario.AutoSize = true;
            this.lblCodigoNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoNuevoUsuario.Location = new System.Drawing.Point(8, 37);
            this.lblCodigoNuevoUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoNuevoUsuario.Name = "lblCodigoNuevoUsuario";
            this.lblCodigoNuevoUsuario.Size = new System.Drawing.Size(459, 21);
            this.lblCodigoNuevoUsuario.TabIndex = 0;
            this.lblCodigoNuevoUsuario.Text = "Escribir la información para agregar un nuevo usuario al sistema.";
            // 
            // gbModificarUsuario
            // 
            this.gbModificarUsuario.Controls.Add(this.cbSeleccionarRol);
            this.gbModificarUsuario.Controls.Add(this.txtCodigoUsuarioModificar);
            this.gbModificarUsuario.Controls.Add(this.label1);
            this.gbModificarUsuario.Controls.Add(this.btnModificarUsuario);
            this.gbModificarUsuario.Controls.Add(this.pbMostrarOcultarContrasenaModificar);
            this.gbModificarUsuario.Controls.Add(this.txtConfirmarContrasenaModificar);
            this.gbModificarUsuario.Controls.Add(this.lblConfirmarContrasenaModificar);
            this.gbModificarUsuario.Controls.Add(this.txtContraseñaUsuarioModificar);
            this.gbModificarUsuario.Controls.Add(this.lblContraseñaUsuarioModificar);
            this.gbModificarUsuario.Controls.Add(this.lblRolUsuarioModificar);
            this.gbModificarUsuario.Controls.Add(this.txtNombreUsuarioModificar);
            this.gbModificarUsuario.Controls.Add(this.lblNombreUsuarioModificar);
            this.gbModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbModificarUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificarUsuario.Location = new System.Drawing.Point(15, 15);
            this.gbModificarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.gbModificarUsuario.Name = "gbModificarUsuario";
            this.gbModificarUsuario.Padding = new System.Windows.Forms.Padding(6);
            this.gbModificarUsuario.Size = new System.Drawing.Size(1226, 278);
            this.gbModificarUsuario.TabIndex = 1;
            this.gbModificarUsuario.TabStop = false;
            this.gbModificarUsuario.Text = "Modificar usuario";
            // 
            // cbSeleccionarRol
            // 
            this.cbSeleccionarRol.BackColor = System.Drawing.Color.White;
            this.cbSeleccionarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccionarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSeleccionarRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarRol.FormattingEnabled = true;
            this.cbSeleccionarRol.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria(o)"});
            this.cbSeleccionarRol.Location = new System.Drawing.Point(197, 129);
            this.cbSeleccionarRol.Margin = new System.Windows.Forms.Padding(6);
            this.cbSeleccionarRol.Name = "cbSeleccionarRol";
            this.cbSeleccionarRol.Size = new System.Drawing.Size(455, 29);
            this.cbSeleccionarRol.Sorted = true;
            this.cbSeleccionarRol.TabIndex = 5;
            // 
            // txtCodigoUsuarioModificar
            // 
            this.txtCodigoUsuarioModificar.BackColor = System.Drawing.Color.White;
            this.txtCodigoUsuarioModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuarioModificar.Location = new System.Drawing.Point(318, 41);
            this.txtCodigoUsuarioModificar.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoUsuarioModificar.MaxLength = 100;
            this.txtCodigoUsuarioModificar.Name = "txtCodigoUsuarioModificar";
            this.txtCodigoUsuarioModificar.Size = new System.Drawing.Size(359, 29);
            this.txtCodigoUsuarioModificar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribir el códido del usuario a modificar:";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.White;
            this.btnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Image = global::SistemaBSPC.Properties.Resources.img6;
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(1016, 218);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(198, 48);
            this.btnModificarUsuario.TabIndex = 10;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // pbMostrarOcultarContrasenaModificar
            // 
            this.pbMostrarOcultarContrasenaModificar.Image = global::SistemaBSPC.Properties.Resources.img1;
            this.pbMostrarOcultarContrasenaModificar.Location = new System.Drawing.Point(674, 213);
            this.pbMostrarOcultarContrasenaModificar.Margin = new System.Windows.Forms.Padding(6);
            this.pbMostrarOcultarContrasenaModificar.Name = "pbMostrarOcultarContrasenaModificar";
            this.pbMostrarOcultarContrasenaModificar.Size = new System.Drawing.Size(42, 33);
            this.pbMostrarOcultarContrasenaModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarOcultarContrasenaModificar.TabIndex = 19;
            this.pbMostrarOcultarContrasenaModificar.TabStop = false;
            this.pbMostrarOcultarContrasenaModificar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMostrarOcultarContrasenaModificar_MouseDown);
            this.pbMostrarOcultarContrasenaModificar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMostrarOcultarContrasenaModificar_MouseUp);
            // 
            // txtConfirmarContrasenaModificar
            // 
            this.txtConfirmarContrasenaModificar.BackColor = System.Drawing.Color.White;
            this.txtConfirmarContrasenaModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasenaModificar.Location = new System.Drawing.Point(197, 217);
            this.txtConfirmarContrasenaModificar.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirmarContrasenaModificar.MaxLength = 100;
            this.txtConfirmarContrasenaModificar.Name = "txtConfirmarContrasenaModificar";
            this.txtConfirmarContrasenaModificar.Size = new System.Drawing.Size(455, 29);
            this.txtConfirmarContrasenaModificar.TabIndex = 9;
            this.txtConfirmarContrasenaModificar.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasenaModificar
            // 
            this.lblConfirmarContrasenaModificar.AutoSize = true;
            this.lblConfirmarContrasenaModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasenaModificar.Location = new System.Drawing.Point(21, 225);
            this.lblConfirmarContrasenaModificar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmarContrasenaModificar.Name = "lblConfirmarContrasenaModificar";
            this.lblConfirmarContrasenaModificar.Size = new System.Drawing.Size(164, 21);
            this.lblConfirmarContrasenaModificar.TabIndex = 8;
            this.lblConfirmarContrasenaModificar.Text = "Confirmar contraseña:";
            // 
            // txtContraseñaUsuarioModificar
            // 
            this.txtContraseñaUsuarioModificar.BackColor = System.Drawing.Color.White;
            this.txtContraseñaUsuarioModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaUsuarioModificar.Location = new System.Drawing.Point(197, 173);
            this.txtContraseñaUsuarioModificar.Margin = new System.Windows.Forms.Padding(6);
            this.txtContraseñaUsuarioModificar.MaxLength = 100;
            this.txtContraseñaUsuarioModificar.Name = "txtContraseñaUsuarioModificar";
            this.txtContraseñaUsuarioModificar.Size = new System.Drawing.Size(455, 29);
            this.txtContraseñaUsuarioModificar.TabIndex = 7;
            this.txtContraseñaUsuarioModificar.UseSystemPasswordChar = true;
            // 
            // lblContraseñaUsuarioModificar
            // 
            this.lblContraseñaUsuarioModificar.AutoSize = true;
            this.lblContraseñaUsuarioModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaUsuarioModificar.Location = new System.Drawing.Point(12, 181);
            this.lblContraseñaUsuarioModificar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContraseñaUsuarioModificar.Name = "lblContraseñaUsuarioModificar";
            this.lblContraseñaUsuarioModificar.Size = new System.Drawing.Size(173, 21);
            this.lblContraseñaUsuarioModificar.TabIndex = 6;
            this.lblContraseñaUsuarioModificar.Text = "Contraseña del usuario:";
            // 
            // lblRolUsuarioModificar
            // 
            this.lblRolUsuarioModificar.AutoSize = true;
            this.lblRolUsuarioModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuarioModificar.Location = new System.Drawing.Point(68, 137);
            this.lblRolUsuarioModificar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRolUsuarioModificar.Name = "lblRolUsuarioModificar";
            this.lblRolUsuarioModificar.Size = new System.Drawing.Size(117, 21);
            this.lblRolUsuarioModificar.TabIndex = 4;
            this.lblRolUsuarioModificar.Text = "Rol del usuario:";
            // 
            // txtNombreUsuarioModificar
            // 
            this.txtNombreUsuarioModificar.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuarioModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuarioModificar.Location = new System.Drawing.Point(197, 87);
            this.txtNombreUsuarioModificar.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreUsuarioModificar.MaxLength = 100;
            this.txtNombreUsuarioModificar.Name = "txtNombreUsuarioModificar";
            this.txtNombreUsuarioModificar.Size = new System.Drawing.Size(455, 29);
            this.txtNombreUsuarioModificar.TabIndex = 3;
            // 
            // lblNombreUsuarioModificar
            // 
            this.lblNombreUsuarioModificar.AutoSize = true;
            this.lblNombreUsuarioModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioModificar.Location = new System.Drawing.Point(37, 95);
            this.lblNombreUsuarioModificar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreUsuarioModificar.Name = "lblNombreUsuarioModificar";
            this.lblNombreUsuarioModificar.Size = new System.Drawing.Size(148, 21);
            this.lblNombreUsuarioModificar.TabIndex = 2;
            this.lblNombreUsuarioModificar.Text = "Nombre de usuario:";
            // 
            // gbEliminarUsuario
            // 
            this.gbEliminarUsuario.Controls.Add(this.btnEliminarUsuario);
            this.gbEliminarUsuario.Controls.Add(this.txtCodigoUsuarioEliminar);
            this.gbEliminarUsuario.Controls.Add(this.lblCodigoUsuarioEliminar);
            this.gbEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminarUsuario.Location = new System.Drawing.Point(15, 15);
            this.gbEliminarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.gbEliminarUsuario.Name = "gbEliminarUsuario";
            this.gbEliminarUsuario.Padding = new System.Windows.Forms.Padding(6);
            this.gbEliminarUsuario.Size = new System.Drawing.Size(1226, 278);
            this.gbEliminarUsuario.TabIndex = 2;
            this.gbEliminarUsuario.TabStop = false;
            this.gbEliminarUsuario.Text = "Eliminar usuario";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Image = global::SistemaBSPC.Properties.Resources.img7;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(1031, 214);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(183, 52);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // txtCodigoUsuarioEliminar
            // 
            this.txtCodigoUsuarioEliminar.BackColor = System.Drawing.Color.White;
            this.txtCodigoUsuarioEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuarioEliminar.Location = new System.Drawing.Point(309, 69);
            this.txtCodigoUsuarioEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoUsuarioEliminar.MaxLength = 8;
            this.txtCodigoUsuarioEliminar.Name = "txtCodigoUsuarioEliminar";
            this.txtCodigoUsuarioEliminar.Size = new System.Drawing.Size(411, 29);
            this.txtCodigoUsuarioEliminar.TabIndex = 1;
            // 
            // lblCodigoUsuarioEliminar
            // 
            this.lblCodigoUsuarioEliminar.AutoSize = true;
            this.lblCodigoUsuarioEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoUsuarioEliminar.Location = new System.Drawing.Point(12, 77);
            this.lblCodigoUsuarioEliminar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoUsuarioEliminar.Name = "lblCodigoUsuarioEliminar";
            this.lblCodigoUsuarioEliminar.Size = new System.Drawing.Size(285, 21);
            this.lblCodigoUsuarioEliminar.TabIndex = 0;
            this.lblCodigoUsuarioEliminar.Text = "Escribir el código del usuario a eliminar:";
            // 
            // gbMuestra
            // 
            this.gbMuestra.Controls.Add(this.dgvMuestra);
            this.gbMuestra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMuestra.Location = new System.Drawing.Point(15, 305);
            this.gbMuestra.Margin = new System.Windows.Forms.Padding(6);
            this.gbMuestra.Name = "gbMuestra";
            this.gbMuestra.Padding = new System.Windows.Forms.Padding(6);
            this.gbMuestra.Size = new System.Drawing.Size(1226, 361);
            this.gbMuestra.TabIndex = 3;
            this.gbMuestra.TabStop = false;
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.AllowUserToAddRows = false;
            this.dgvMuestra.AllowUserToDeleteRows = false;
            this.dgvMuestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuestra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(12, 34);
            this.dgvMuestra.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.ReadOnly = true;
            this.dgvMuestra.Size = new System.Drawing.Size(1202, 315);
            this.dgvMuestra.TabIndex = 15;
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbEliminarUsuario);
            this.Controls.Add(this.gbModificarUsuario);
            this.Controls.Add(this.gbMuestra);
            this.Controls.Add(this.gbNuevoUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de usuario";
            this.Load += new System.EventHandler(this.frmRegistrarUsuario_Load);
            this.gbNuevoUsuario.ResumeLayout(false);
            this.gbNuevoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarContrasena)).EndInit();
            this.gbModificarUsuario.ResumeLayout(false);
            this.gbModificarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarOcultarContrasenaModificar)).EndInit();
            this.gbEliminarUsuario.ResumeLayout(false);
            this.gbEliminarUsuario.PerformLayout();
            this.gbMuestra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoUsuario;
        private System.Windows.Forms.GroupBox gbModificarUsuario;
        private System.Windows.Forms.GroupBox gbEliminarUsuario;
        private System.Windows.Forms.GroupBox gbMuestra;
        private System.Windows.Forms.Label lblRolNuevoUsuario;
        private System.Windows.Forms.TextBox txtNombreNuevoUsuario;
        private System.Windows.Forms.Label lblNuevoNombreUsuario;
        private System.Windows.Forms.Label lblCodigoNuevoUsuario;
        private System.Windows.Forms.Label lblContrasenaNuevoUsuario;
        private System.Windows.Forms.Label lblConfirmarContrasenaNuevoUsuario;
        private System.Windows.Forms.TextBox txtContrasenaNuevoUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContrasenaNuevoUsuario;
        private System.Windows.Forms.PictureBox pbOcultarContrasena;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.PictureBox pbMostrarOcultarContrasenaModificar;
        private System.Windows.Forms.TextBox txtConfirmarContrasenaModificar;
        private System.Windows.Forms.Label lblConfirmarContrasenaModificar;
        private System.Windows.Forms.TextBox txtContraseñaUsuarioModificar;
        private System.Windows.Forms.Label lblContraseñaUsuarioModificar;
        private System.Windows.Forms.Label lblRolUsuarioModificar;
        private System.Windows.Forms.TextBox txtNombreUsuarioModificar;
        private System.Windows.Forms.Label lblNombreUsuarioModificar;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.TextBox txtCodigoUsuarioModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtCodigoUsuarioEliminar;
        private System.Windows.Forms.Label lblCodigoUsuarioEliminar;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.ComboBox cbSeleccionarRol;
        private System.Windows.Forms.ComboBox cbRolUsuarioCrear;
    }
}