namespace Control_Llamadas
{
    partial class FormControl
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNombreUsuario1 = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ID_Llamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPaginas = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.lblTotalMints = new System.Windows.Forms.Label();
            this.lblTiempoFin = new System.Windows.Forms.Label();
            this.lblTiempoInicio = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            this.tpBuscar = new System.Windows.Forms.TabPage();
            this.txtIDllamada = new System.Windows.Forms.TextBox();
            this.lblIDllamada = new System.Windows.Forms.Label();
            this.txtTotalMints = new System.Windows.Forms.TextBox();
            this.txtTiempoFin = new System.Windows.Forms.TextBox();
            this.txtTiempoInicio = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario2 = new System.Windows.Forms.Label();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblInicio2 = new System.Windows.Forms.Label();
            this.lblFin2 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.txtNombreUsuario2 = new System.Windows.Forms.TextBox();
            this.txtObservaciones2 = new System.Windows.Forms.TextBox();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.tpReportes = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tcPaginas.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            this.tpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(62, 67);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(107, 13);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "- Nombre de Usuario:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(62, 94);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "- Descripción:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(62, 122);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(87, 13);
            this.lblObservaciones.TabIndex = 2;
            this.lblObservaciones.Text = "- Observaciones:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(104, 258);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "- Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(104, 287);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(82, 13);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "- Hora de Inicio:";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(104, 315);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(71, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "- Hora de Fin:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(104, 342);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "- Total de Minutos:";
            // 
            // txtNombreUsuario1
            // 
            this.txtNombreUsuario1.Location = new System.Drawing.Point(176, 64);
            this.txtNombreUsuario1.Name = "txtNombreUsuario1";
            this.txtNombreUsuario1.Size = new System.Drawing.Size(305, 20);
            this.txtNombreUsuario1.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(176, 91);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(305, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(65, 138);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(416, 107);
            this.txtObservaciones.TabIndex = 9;
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(343, 336);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 23);
            this.btInsertar.TabIndex = 11;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(479, 206);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 25);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(479, 24);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 25);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(398, 24);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 25);
            this.btBuscar.TabIndex = 15;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(218, 251);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 16;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Llamada,
            this.Usuario,
            this.Descripcion,
            this.Fecha,
            this.ID_Dia});
            this.dgvDatos.Location = new System.Drawing.Point(10, 53);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(544, 140);
            this.dgvDatos.TabIndex = 17;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // ID_Llamada
            // 
            this.ID_Llamada.DataPropertyName = "ID_Llamada";
            this.ID_Llamada.HeaderText = "ID";
            this.ID_Llamada.Name = "ID_Llamada";
            this.ID_Llamada.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // ID_Dia
            // 
            this.ID_Dia.DataPropertyName = "ID_Dia";
            this.ID_Dia.HeaderText = "Llamada del día número:";
            this.ID_Dia.Name = "ID_Dia";
            this.ID_Dia.ReadOnly = true;
            // 
            // tcPaginas
            // 
            this.tcPaginas.Controls.Add(this.tpAgregar);
            this.tcPaginas.Controls.Add(this.tpBuscar);
            this.tcPaginas.Controls.Add(this.tpReportes);
            this.tcPaginas.Location = new System.Drawing.Point(12, 12);
            this.tcPaginas.Name = "tcPaginas";
            this.tcPaginas.SelectedIndex = 0;
            this.tcPaginas.Size = new System.Drawing.Size(572, 477);
            this.tcPaginas.TabIndex = 18;
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.lblTotalMints);
            this.tpAgregar.Controls.Add(this.lblTiempoFin);
            this.tpAgregar.Controls.Add(this.lblTiempoInicio);
            this.tpAgregar.Controls.Add(this.btFinalizar);
            this.tpAgregar.Controls.Add(this.btIniciar);
            this.tpAgregar.Controls.Add(this.lblNombreUsuario);
            this.tpAgregar.Controls.Add(this.lblDescripcion);
            this.tpAgregar.Controls.Add(this.dtpFecha);
            this.tpAgregar.Controls.Add(this.lblObservaciones);
            this.tpAgregar.Controls.Add(this.btInsertar);
            this.tpAgregar.Controls.Add(this.lblFecha);
            this.tpAgregar.Controls.Add(this.lblInicio);
            this.tpAgregar.Controls.Add(this.lblFin);
            this.tpAgregar.Controls.Add(this.lblTotal);
            this.tpAgregar.Controls.Add(this.txtNombreUsuario1);
            this.tpAgregar.Controls.Add(this.txtObservaciones);
            this.tpAgregar.Controls.Add(this.txtDescripcion);
            this.tpAgregar.Location = new System.Drawing.Point(4, 22);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(564, 451);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            this.tpAgregar.Click += new System.EventHandler(this.tpAgregar_Click);
            // 
            // lblTotalMints
            // 
            this.lblTotalMints.AutoSize = true;
            this.lblTotalMints.Location = new System.Drawing.Point(215, 341);
            this.lblTotalMints.Name = "lblTotalMints";
            this.lblTotalMints.Size = new System.Drawing.Size(49, 13);
            this.lblTotalMints.TabIndex = 21;
            this.lblTotalMints.Text = "00:00:00";
            // 
            // lblTiempoFin
            // 
            this.lblTiempoFin.AutoSize = true;
            this.lblTiempoFin.Location = new System.Drawing.Point(215, 313);
            this.lblTiempoFin.Name = "lblTiempoFin";
            this.lblTiempoFin.Size = new System.Drawing.Size(34, 13);
            this.lblTiempoFin.TabIndex = 20;
            this.lblTiempoFin.Text = "00:00";
            // 
            // lblTiempoInicio
            // 
            this.lblTiempoInicio.AutoSize = true;
            this.lblTiempoInicio.Location = new System.Drawing.Point(215, 287);
            this.lblTiempoInicio.Name = "lblTiempoInicio";
            this.lblTiempoInicio.Size = new System.Drawing.Size(34, 13);
            this.lblTiempoInicio.TabIndex = 19;
            this.lblTiempoInicio.Text = "00:00";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(343, 308);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 18;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(343, 277);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 17;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // tpBuscar
            // 
            this.tpBuscar.Controls.Add(this.txtIDllamada);
            this.tpBuscar.Controls.Add(this.btEliminar);
            this.tpBuscar.Controls.Add(this.btModificar);
            this.tpBuscar.Controls.Add(this.lblIDllamada);
            this.tpBuscar.Controls.Add(this.txtTotalMints);
            this.tpBuscar.Controls.Add(this.txtTiempoFin);
            this.tpBuscar.Controls.Add(this.txtTiempoInicio);
            this.tpBuscar.Controls.Add(this.lblNombreUsuario2);
            this.tpBuscar.Controls.Add(this.lblDescripcion2);
            this.tpBuscar.Controls.Add(this.dtpFecha2);
            this.tpBuscar.Controls.Add(this.label5);
            this.tpBuscar.Controls.Add(this.lblFecha2);
            this.tpBuscar.Controls.Add(this.lblInicio2);
            this.tpBuscar.Controls.Add(this.lblFin2);
            this.tpBuscar.Controls.Add(this.lblTotal2);
            this.tpBuscar.Controls.Add(this.txtNombreUsuario2);
            this.tpBuscar.Controls.Add(this.txtObservaciones2);
            this.tpBuscar.Controls.Add(this.txtDescripcion2);
            this.tpBuscar.Controls.Add(this.dgvDatos);
            this.tpBuscar.Controls.Add(this.btBuscar);
            this.tpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tpBuscar.Name = "tpBuscar";
            this.tpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuscar.Size = new System.Drawing.Size(564, 451);
            this.tpBuscar.TabIndex = 1;
            this.tpBuscar.Text = "Buscar";
            this.tpBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIDllamada
            // 
            this.txtIDllamada.Location = new System.Drawing.Point(120, 26);
            this.txtIDllamada.Name = "txtIDllamada";
            this.txtIDllamada.Size = new System.Drawing.Size(272, 20);
            this.txtIDllamada.TabIndex = 37;
            // 
            // lblIDllamada
            // 
            this.lblIDllamada.AutoSize = true;
            this.lblIDllamada.Location = new System.Drawing.Point(7, 29);
            this.lblIDllamada.Name = "lblIDllamada";
            this.lblIDllamada.Size = new System.Drawing.Size(81, 13);
            this.lblIDllamada.TabIndex = 36;
            this.lblIDllamada.Text = "- ID de llamada:";
            // 
            // txtTotalMints
            // 
            this.txtTotalMints.Location = new System.Drawing.Point(434, 413);
            this.txtTotalMints.Name = "txtTotalMints";
            this.txtTotalMints.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMints.TabIndex = 35;
            // 
            // txtTiempoFin
            // 
            this.txtTiempoFin.Location = new System.Drawing.Point(434, 367);
            this.txtTiempoFin.Name = "txtTiempoFin";
            this.txtTiempoFin.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoFin.TabIndex = 34;
            this.txtTiempoFin.TextChanged += new System.EventHandler(this.txtTiempoFin_TextChanged);
            // 
            // txtTiempoInicio
            // 
            this.txtTiempoInicio.Location = new System.Drawing.Point(434, 325);
            this.txtTiempoInicio.Name = "txtTiempoInicio";
            this.txtTiempoInicio.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoInicio.TabIndex = 33;
            // 
            // lblNombreUsuario2
            // 
            this.lblNombreUsuario2.AutoSize = true;
            this.lblNombreUsuario2.Location = new System.Drawing.Point(7, 211);
            this.lblNombreUsuario2.Name = "lblNombreUsuario2";
            this.lblNombreUsuario2.Size = new System.Drawing.Size(107, 13);
            this.lblNombreUsuario2.TabIndex = 22;
            this.lblNombreUsuario2.Text = "- Nombre de Usuario:";
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Location = new System.Drawing.Point(7, 238);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(72, 13);
            this.lblDescripcion2.TabIndex = 23;
            this.lblDescripcion2.Text = "- Descripción:";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(120, 272);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(219, 20);
            this.dtpFecha2.TabIndex = 32;
            this.dtpFecha2.Value = new System.DateTime(2016, 5, 14, 17, 49, 46, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "- Observaciones:";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(7, 276);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(46, 13);
            this.lblFecha2.TabIndex = 25;
            this.lblFecha2.Text = "- Fecha:";
            // 
            // lblInicio2
            // 
            this.lblInicio2.AutoSize = true;
            this.lblInicio2.Location = new System.Drawing.Point(321, 329);
            this.lblInicio2.Name = "lblInicio2";
            this.lblInicio2.Size = new System.Drawing.Size(82, 13);
            this.lblInicio2.TabIndex = 26;
            this.lblInicio2.Text = "- Hora de Inicio:";
            // 
            // lblFin2
            // 
            this.lblFin2.AutoSize = true;
            this.lblFin2.Location = new System.Drawing.Point(321, 371);
            this.lblFin2.Name = "lblFin2";
            this.lblFin2.Size = new System.Drawing.Size(71, 13);
            this.lblFin2.TabIndex = 27;
            this.lblFin2.Text = "- Hora de Fin:";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(321, 413);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(95, 13);
            this.lblTotal2.TabIndex = 28;
            this.lblTotal2.Text = "- Total de Minutos:";
            // 
            // txtNombreUsuario2
            // 
            this.txtNombreUsuario2.Location = new System.Drawing.Point(120, 211);
            this.txtNombreUsuario2.Name = "txtNombreUsuario2";
            this.txtNombreUsuario2.Size = new System.Drawing.Size(353, 20);
            this.txtNombreUsuario2.TabIndex = 29;
            // 
            // txtObservaciones2
            // 
            this.txtObservaciones2.Location = new System.Drawing.Point(10, 326);
            this.txtObservaciones2.Multiline = true;
            this.txtObservaciones2.Name = "txtObservaciones2";
            this.txtObservaciones2.Size = new System.Drawing.Size(305, 107);
            this.txtObservaciones2.TabIndex = 31;
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(120, 238);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(434, 20);
            this.txtDescripcion2.TabIndex = 30;
            // 
            // tpReportes
            // 
            this.tpReportes.Location = new System.Drawing.Point(4, 22);
            this.tpReportes.Name = "tpReportes";
            this.tpReportes.Size = new System.Drawing.Size(564, 451);
            this.tpReportes.TabIndex = 2;
            this.tpReportes.Text = "Reportes";
            this.tpReportes.UseVisualStyleBackColor = true;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 502);
            this.Controls.Add(this.tcPaginas);
            this.Name = "FormControl";
            this.Text = "Control de Llamadas";
            this.Load += new System.EventHandler(this.FormControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tcPaginas.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            this.tpBuscar.ResumeLayout(false);
            this.tpBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNombreUsuario1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TabControl tcPaginas;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.TabPage tpBuscar;
        private System.Windows.Forms.TabPage tpReportes;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.TextBox txtTotalMints;
        private System.Windows.Forms.TextBox txtTiempoFin;
        private System.Windows.Forms.TextBox txtTiempoInicio;
        private System.Windows.Forms.Label lblNombreUsuario2;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblInicio2;
        private System.Windows.Forms.Label lblFin2;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.TextBox txtNombreUsuario2;
        private System.Windows.Forms.TextBox txtObservaciones2;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.TextBox txtIDllamada;
        private System.Windows.Forms.Label lblIDllamada;
        private System.Windows.Forms.Label lblTotalMints;
        private System.Windows.Forms.Label lblTiempoFin;
        private System.Windows.Forms.Label lblTiempoInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Llamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dia;
    }
}

