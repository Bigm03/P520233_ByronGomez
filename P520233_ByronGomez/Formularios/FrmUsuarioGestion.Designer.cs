namespace P520233_ByronGomez.Formularios
{
    partial class FrmUsuarioGestion
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
            this.LbBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.DgvListausuarios = new System.Windows.Forms.DataGridView();
            this.ColUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.TxtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUsuarioContrasennia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboxUsuarioTipoRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuarioCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuarioCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListausuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Location = new System.Drawing.Point(227, 19);
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(49, 13);
            this.LbBuscar.TabIndex = 0;
            this.LbBuscar.Text = "Buscar...";
            this.LbBuscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(282, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(252, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(650, 12);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(124, 17);
            this.CbVerActivos.TabIndex = 2;
            this.CbVerActivos.Text = "Ver Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            // 
            // DgvListausuarios
            // 
            this.DgvListausuarios.AllowUserToAddRows = false;
            this.DgvListausuarios.AllowUserToDeleteRows = false;
            this.DgvListausuarios.AllowUserToOrderColumns = true;
            this.DgvListausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListausuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUsuarioID,
            this.ColCedula,
            this.ColNombre,
            this.ColCorreo,
            this.ColTelefono,
            this.ColRol});
            this.DgvListausuarios.Location = new System.Drawing.Point(12, 50);
            this.DgvListausuarios.MultiSelect = false;
            this.DgvListausuarios.Name = "DgvListausuarios";
            this.DgvListausuarios.ReadOnly = true;
            this.DgvListausuarios.RowHeadersVisible = false;
            this.DgvListausuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListausuarios.Size = new System.Drawing.Size(762, 231);
            this.DgvListausuarios.TabIndex = 3;
            this.DgvListausuarios.VirtualMode = true;
            this.DgvListausuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListausuarios_CellContentClick);
            // 
            // ColUsuarioID
            // 
            this.ColUsuarioID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUsuarioID.DataPropertyName = "UsuarioID";
            this.ColUsuarioID.HeaderText = "CODIGO";
            this.ColUsuarioID.Name = "ColUsuarioID";
            this.ColUsuarioID.ReadOnly = true;
            this.ColUsuarioID.Width = 80;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "CÉDULA";
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "NOMBRE";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCorreo.DataPropertyName = "Correo";
            this.ColCorreo.HeaderText = "CORREO";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            this.ColCorreo.Width = 120;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "TELÉFONO";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColRol
            // 
            this.ColRol.DataPropertyName = "Rol";
            this.ColRol.HeaderText = "ROL DE USUARIO";
            this.ColRol.Name = "ColRol";
            this.ColRol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CbUsuarioActivo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.TxtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtUsuarioContrasennia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CboxUsuarioTipoRol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtUsuarioNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtUsuarioCedula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtUsuarioCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CbUsuarioActivo
            // 
            this.CbUsuarioActivo.AutoSize = true;
            this.CbUsuarioActivo.Location = new System.Drawing.Point(222, 35);
            this.CbUsuarioActivo.Name = "CbUsuarioActivo";
            this.CbUsuarioActivo.Size = new System.Drawing.Size(56, 17);
            this.CbUsuarioActivo.TabIndex = 16;
            this.CbUsuarioActivo.Text = "Activo";
            this.CbUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dirección";
            // 
            // TxtUsuarioDireccion
            // 
            this.TxtUsuarioDireccion.Location = new System.Drawing.Point(369, 112);
            this.TxtUsuarioDireccion.Multiline = true;
            this.TxtUsuarioDireccion.Name = "TxtUsuarioDireccion";
            this.TxtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUsuarioDireccion.Size = new System.Drawing.Size(352, 82);
            this.TxtUsuarioDireccion.TabIndex = 14;
            // 
            // TxtUsuarioTelefono
            // 
            this.TxtUsuarioTelefono.Location = new System.Drawing.Point(9, 190);
            this.TxtUsuarioTelefono.Name = "TxtUsuarioTelefono";
            this.TxtUsuarioTelefono.Size = new System.Drawing.Size(269, 20);
            this.TxtUsuarioTelefono.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Teléfono";
            // 
            // TxtUsuarioContrasennia
            // 
            this.TxtUsuarioContrasennia.Location = new System.Drawing.Point(369, 71);
            this.TxtUsuarioContrasennia.Name = "TxtUsuarioContrasennia";
            this.TxtUsuarioContrasennia.Size = new System.Drawing.Size(352, 20);
            this.TxtUsuarioContrasennia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CboxUsuarioTipoRol
            // 
            this.CboxUsuarioTipoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxUsuarioTipoRol.FormattingEnabled = true;
            this.CboxUsuarioTipoRol.Location = new System.Drawing.Point(369, 31);
            this.CboxUsuarioTipoRol.Name = "CboxUsuarioTipoRol";
            this.CboxUsuarioTipoRol.Size = new System.Drawing.Size(352, 21);
            this.CboxUsuarioTipoRol.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Usuario";
            // 
            // TxtUsuarioCorreo
            // 
            this.TxtUsuarioCorreo.Location = new System.Drawing.Point(9, 151);
            this.TxtUsuarioCorreo.Name = "TxtUsuarioCorreo";
            this.TxtUsuarioCorreo.Size = new System.Drawing.Size(269, 20);
            this.TxtUsuarioCorreo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // TxtUsuarioNombre
            // 
            this.TxtUsuarioNombre.Location = new System.Drawing.Point(9, 112);
            this.TxtUsuarioNombre.Name = "TxtUsuarioNombre";
            this.TxtUsuarioNombre.Size = new System.Drawing.Size(269, 20);
            this.TxtUsuarioNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // TxtUsuarioCedula
            // 
            this.TxtUsuarioCedula.Location = new System.Drawing.Point(9, 71);
            this.TxtUsuarioCedula.Name = "TxtUsuarioCedula";
            this.TxtUsuarioCedula.Size = new System.Drawing.Size(269, 20);
            this.TxtUsuarioCedula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula";
            // 
            // TxtUsuarioCodigo
            // 
            this.TxtUsuarioCodigo.Enabled = false;
            this.TxtUsuarioCodigo.Location = new System.Drawing.Point(9, 32);
            this.TxtUsuarioCodigo.Name = "TxtUsuarioCodigo";
            this.TxtUsuarioCodigo.Size = new System.Drawing.Size(207, 20);
            this.TxtUsuarioCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Usuario";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 520);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 29);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(146, 520);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(128, 29);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(280, 520);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(128, 29);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(474, 520);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(148, 29);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Sienna;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(626, 520);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(148, 29);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(52, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(52, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(52, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(454, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(454, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(366, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Datos Requeridos...";
            // 
            // FrmUsuarioGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 563);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListausuarios);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioGestion";
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarioGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListausuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.DataGridView DgvListausuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtUsuarioCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuarioCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuarioNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuarioCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxUsuarioTipoRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUsuarioTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUsuarioContrasennia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUsuarioDireccion;
        private System.Windows.Forms.CheckBox CbUsuarioActivo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}