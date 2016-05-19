namespace Control_Llamadas
{
    partial class FormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// /// 


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ID_Llamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPaginas = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.btLimpiarCampos = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.lblTiempoFin = new System.Windows.Forms.Label();
            this.lblTiempoInicio = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            this.tpBuscar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLimpiarCampos2 = new System.Windows.Forms.Button();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.lblLlamadaID = new System.Windows.Forms.Label();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.txtObservaciones2 = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario2 = new System.Windows.Forms.TextBox();
            this.lblConsecutivo = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblFin2 = new System.Windows.Forms.Label();
            this.lblInicio2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempoTotal = new System.Windows.Forms.TextBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.txtTiempoFin = new System.Windows.Forms.TextBox();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.txtTiempoInicio = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario2 = new System.Windows.Forms.Label();
            this.txtIDllamada = new System.Windows.Forms.TextBox();
            this.lblIDllamada = new System.Windows.Forms.Label();
            this.tpReportes = new System.Windows.Forms.TabPage();
            this.timerHoras = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tcPaginas.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpBuscar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(10, 16);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(159, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "- Nombre de Usuario:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(10, 51);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(105, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "- Descripción:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblObservaciones.Location = new System.Drawing.Point(10, 282);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(127, 20);
            this.lblObservaciones.TabIndex = 2;
            this.lblObservaciones.Text = "- Observaciones:";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechas.Location = new System.Drawing.Point(8, 10);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(67, 20);
            this.lblFechas.TabIndex = 3;
            this.lblFechas.Text = "- Fecha:";
            this.lblFechas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInicio.Location = new System.Drawing.Point(8, 51);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(120, 20);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "- Hora de Inicio:";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFin.Location = new System.Drawing.Point(8, 86);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(105, 20);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "- Hora de Fin:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(8, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "- Tiempo Total:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(175, 16);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(383, 26);
            this.txtNombreUsuario.TabIndex = 7;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario1_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescripcion.Location = new System.Drawing.Point(175, 48);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(383, 26);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtObservaciones.Location = new System.Drawing.Point(19, 305);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(539, 130);
            this.txtObservaciones.TabIndex = 9;
            // 
            // btInsertar
            // 
            this.btInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btInsertar.Location = new System.Drawing.Point(307, 115);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(174, 26);
            this.btInsertar.TabIndex = 11;
            this.btInsertar.Text = "Insertar ";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(387, 6);
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
            this.btBuscar.Text = "Mostrar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Llamada,
            this.Usuario,
            this.Descripcion,
            this.Fecha,
            this.ID_Dia});
            this.dgvDatos.Location = new System.Drawing.Point(16, 53);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(537, 140);
            this.dgvDatos.TabIndex = 17;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // ID_Llamada
            // 
            this.ID_Llamada.DataPropertyName = "ID_Llamada";
            this.ID_Llamada.HeaderText = "ID";
            this.ID_Llamada.Name = "ID_Llamada";
            this.ID_Llamada.ReadOnly = true;
            this.ID_Llamada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Llamada.Width = 50;
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
            this.Fecha.Width = 140;
            // 
            // ID_Dia
            // 
            this.ID_Dia.DataPropertyName = "ID_Dia";
            this.ID_Dia.HeaderText = "Consecutivo";
            this.ID_Dia.Name = "ID_Dia";
            this.ID_Dia.ReadOnly = true;
            this.ID_Dia.Width = 85;
            // 
            // tcPaginas
            // 
            this.tcPaginas.Controls.Add(this.tpAgregar);
            this.tcPaginas.Controls.Add(this.tpBuscar);
            this.tcPaginas.Controls.Add(this.tpReportes);
            this.tcPaginas.Location = new System.Drawing.Point(12, 12);
            this.tcPaginas.Name = "tcPaginas";
            this.tcPaginas.SelectedIndex = 0;
            this.tcPaginas.Size = new System.Drawing.Size(572, 507);
            this.tcPaginas.TabIndex = 18;
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.btLimpiarCampos);
            this.tpAgregar.Controls.Add(this.lblError);
            this.tpAgregar.Controls.Add(this.txtNombreUsuario);
            this.tpAgregar.Controls.Add(this.txtDescripcion);
            this.tpAgregar.Controls.Add(this.lblObservaciones);
            this.tpAgregar.Controls.Add(this.lblNombreUsuario);
            this.tpAgregar.Controls.Add(this.panel1);
            this.tpAgregar.Controls.Add(this.txtObservaciones);
            this.tpAgregar.Controls.Add(this.lblDescripcion);
            this.tpAgregar.Location = new System.Drawing.Point(4, 22);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(564, 481);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Registro de Llamadas";
            this.tpAgregar.UseVisualStyleBackColor = true;
            this.tpAgregar.Click += new System.EventHandler(this.tpAgregar_Click);
            // 
            // btLimpiarCampos
            // 
            this.btLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btLimpiarCampos.Location = new System.Drawing.Point(427, 444);
            this.btLimpiarCampos.Name = "btLimpiarCampos";
            this.btLimpiarCampos.Size = new System.Drawing.Size(131, 31);
            this.btLimpiarCampos.TabIndex = 25;
            this.btLimpiarCampos.Text = "Limpiar Campos";
            this.btLimpiarCampos.UseVisualStyleBackColor = true;
            this.btLimpiarCampos.Click += new System.EventHandler(this.btLimpiarCampos_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(48, 247);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.lblTiempoTotal);
            this.panel1.Controls.Add(this.lblFechas);
            this.panel1.Controls.Add(this.lblTiempoFin);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblTiempoInicio);
            this.panel1.Controls.Add(this.lblFin);
            this.panel1.Controls.Add(this.btFinalizar);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.btIniciar);
            this.panel1.Controls.Add(this.btInsertar);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 155);
            this.panel1.TabIndex = 23;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblfecha.Location = new System.Drawing.Point(196, 10);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 20);
            this.lblfecha.TabIndex = 22;
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTiempoTotal.Location = new System.Drawing.Point(174, 118);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTiempoTotal.TabIndex = 21;
            this.lblTiempoTotal.Text = "0:0:0";
            this.lblTiempoTotal.Click += new System.EventHandler(this.lblTiempoTotal_Click);
            // 
            // lblTiempoFin
            // 
            this.lblTiempoFin.AutoSize = true;
            this.lblTiempoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTiempoFin.Location = new System.Drawing.Point(174, 86);
            this.lblTiempoFin.Name = "lblTiempoFin";
            this.lblTiempoFin.Size = new System.Drawing.Size(71, 20);
            this.lblTiempoFin.TabIndex = 20;
            this.lblTiempoFin.Text = "00:00:00";
            // 
            // lblTiempoInicio
            // 
            this.lblTiempoInicio.AutoSize = true;
            this.lblTiempoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTiempoInicio.Location = new System.Drawing.Point(174, 51);
            this.lblTiempoInicio.Name = "lblTiempoInicio";
            this.lblTiempoInicio.Size = new System.Drawing.Size(71, 20);
            this.lblTiempoInicio.TabIndex = 19;
            this.lblTiempoInicio.Text = "00:00:00";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btFinalizar.Location = new System.Drawing.Point(307, 82);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(174, 28);
            this.btFinalizar.TabIndex = 18;
            this.btFinalizar.Text = "Finalizar ";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btIniciar.Location = new System.Drawing.Point(307, 47);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(174, 29);
            this.btIniciar.TabIndex = 17;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // tpBuscar
            // 
            this.tpBuscar.Controls.Add(this.panel2);
            this.tpBuscar.Controls.Add(this.txtIDllamada);
            this.tpBuscar.Controls.Add(this.btEliminar);
            this.tpBuscar.Controls.Add(this.lblIDllamada);
            this.tpBuscar.Controls.Add(this.dgvDatos);
            this.tpBuscar.Controls.Add(this.btBuscar);
            this.tpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tpBuscar.Name = "tpBuscar";
            this.tpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuscar.Size = new System.Drawing.Size(564, 481);
            this.tpBuscar.TabIndex = 1;
            this.tpBuscar.Text = "Buscar";
            this.tpBuscar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btLimpiarCampos2);
            this.panel2.Controls.Add(this.lblLlamada);
            this.panel2.Controls.Add(this.lblLlamadaID);
            this.panel2.Controls.Add(this.txtDescripcion2);
            this.panel2.Controls.Add(this.txtObservaciones2);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.txtNombreUsuario2);
            this.panel2.Controls.Add(this.lblConsecutivo);
            this.panel2.Controls.Add(this.lblTotal2);
            this.panel2.Controls.Add(this.lblFin2);
            this.panel2.Controls.Add(this.lblInicio2);
            this.panel2.Controls.Add(this.btModificar);
            this.panel2.Controls.Add(this.lblFecha2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTiempoTotal);
            this.panel2.Controls.Add(this.dtpFecha2);
            this.panel2.Controls.Add(this.txtTiempoFin);
            this.panel2.Controls.Add(this.lblDescripcion2);
            this.panel2.Controls.Add(this.txtTiempoInicio);
            this.panel2.Controls.Add(this.lblNombreUsuario2);
            this.panel2.Location = new System.Drawing.Point(10, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 276);
            this.panel2.TabIndex = 42;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btLimpiarCampos2
            // 
            this.btLimpiarCampos2.Location = new System.Drawing.Point(468, 6);
            this.btLimpiarCampos2.Name = "btLimpiarCampos2";
            this.btLimpiarCampos2.Size = new System.Drawing.Size(75, 25);
            this.btLimpiarCampos2.TabIndex = 42;
            this.btLimpiarCampos2.Text = "Limpiar";
            this.btLimpiarCampos2.UseVisualStyleBackColor = true;
            this.btLimpiarCampos2.Click += new System.EventHandler(this.btLimpiarCampos2_Click);
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Location = new System.Drawing.Point(9, 12);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(81, 13);
            this.lblLlamada.TabIndex = 40;
            this.lblLlamada.Text = "- ID de llamada:";
            this.lblLlamada.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblLlamadaID
            // 
            this.lblLlamadaID.AutoSize = true;
            this.lblLlamadaID.Location = new System.Drawing.Point(119, 12);
            this.lblLlamadaID.Name = "lblLlamadaID";
            this.lblLlamadaID.Size = new System.Drawing.Size(119, 13);
            this.lblLlamadaID.TabIndex = 41;
            this.lblLlamadaID.Text = "Identificador de llamada";
            this.lblLlamadaID.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(122, 69);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(415, 20);
            this.txtDescripcion2.TabIndex = 30;
            this.txtDescripcion2.TextChanged += new System.EventHandler(this.txtDescripcion2_TextChanged);
            // 
            // txtObservaciones2
            // 
            this.txtObservaciones2.Location = new System.Drawing.Point(12, 157);
            this.txtObservaciones2.Multiline = true;
            this.txtObservaciones2.Name = "txtObservaciones2";
            this.txtObservaciones2.Size = new System.Drawing.Size(299, 107);
            this.txtObservaciones2.TabIndex = 31;
            this.txtObservaciones2.TextChanged += new System.EventHandler(this.txtObservaciones2_TextChanged);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(430, 234);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(107, 20);
            this.txtConsecutivo.TabIndex = 39;
            this.txtConsecutivo.TextChanged += new System.EventHandler(this.txtConsecutivo_TextChanged);
            // 
            // txtNombreUsuario2
            // 
            this.txtNombreUsuario2.Location = new System.Drawing.Point(122, 42);
            this.txtNombreUsuario2.Name = "txtNombreUsuario2";
            this.txtNombreUsuario2.Size = new System.Drawing.Size(415, 20);
            this.txtNombreUsuario2.TabIndex = 29;
            this.txtNombreUsuario2.TextChanged += new System.EventHandler(this.txtNombreUsuario2_TextChanged);
            // 
            // lblConsecutivo
            // 
            this.lblConsecutivo.AutoSize = true;
            this.lblConsecutivo.Location = new System.Drawing.Point(319, 237);
            this.lblConsecutivo.Name = "lblConsecutivo";
            this.lblConsecutivo.Size = new System.Drawing.Size(75, 13);
            this.lblConsecutivo.TabIndex = 38;
            this.lblConsecutivo.Text = "- Consecutivo:";
            this.lblConsecutivo.Click += new System.EventHandler(this.lblConsecutivo_Click);
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(317, 211);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(78, 13);
            this.lblTotal2.TabIndex = 28;
            this.lblTotal2.Text = "- Tiempo Total:";
            this.lblTotal2.Click += new System.EventHandler(this.lblTotal2_Click);
            // 
            // lblFin2
            // 
            this.lblFin2.AutoSize = true;
            this.lblFin2.Location = new System.Drawing.Point(317, 185);
            this.lblFin2.Name = "lblFin2";
            this.lblFin2.Size = new System.Drawing.Size(71, 13);
            this.lblFin2.TabIndex = 27;
            this.lblFin2.Text = "- Hora de Fin:";
            this.lblFin2.Click += new System.EventHandler(this.lblFin2_Click);
            // 
            // lblInicio2
            // 
            this.lblInicio2.AutoSize = true;
            this.lblInicio2.Location = new System.Drawing.Point(317, 160);
            this.lblInicio2.Name = "lblInicio2";
            this.lblInicio2.Size = new System.Drawing.Size(82, 13);
            this.lblInicio2.TabIndex = 26;
            this.lblInicio2.Text = "- Hora de Inicio:";
            this.lblInicio2.Click += new System.EventHandler(this.lblInicio2_Click);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(9, 110);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(46, 13);
            this.lblFecha2.TabIndex = 25;
            this.lblFecha2.Text = "- Fecha:";
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "- Observaciones:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTiempoTotal
            // 
            this.txtTiempoTotal.Location = new System.Drawing.Point(430, 208);
            this.txtTiempoTotal.Name = "txtTiempoTotal";
            this.txtTiempoTotal.Size = new System.Drawing.Size(107, 20);
            this.txtTiempoTotal.TabIndex = 35;
            this.txtTiempoTotal.TextChanged += new System.EventHandler(this.txtTotalMints_TextChanged);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(122, 103);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(219, 20);
            this.dtpFecha2.TabIndex = 32;
            this.dtpFecha2.Value = new System.DateTime(2016, 5, 14, 17, 49, 46, 0);
            this.dtpFecha2.ValueChanged += new System.EventHandler(this.dtpFecha2_ValueChanged);
            // 
            // txtTiempoFin
            // 
            this.txtTiempoFin.Location = new System.Drawing.Point(430, 182);
            this.txtTiempoFin.Name = "txtTiempoFin";
            this.txtTiempoFin.Size = new System.Drawing.Size(107, 20);
            this.txtTiempoFin.TabIndex = 34;
            this.txtTiempoFin.TextChanged += new System.EventHandler(this.txtTiempoFin_TextChanged);
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Location = new System.Drawing.Point(9, 69);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(72, 13);
            this.lblDescripcion2.TabIndex = 23;
            this.lblDescripcion2.Text = "- Descripción:";
            this.lblDescripcion2.Click += new System.EventHandler(this.lblDescripcion2_Click);
            // 
            // txtTiempoInicio
            // 
            this.txtTiempoInicio.Location = new System.Drawing.Point(430, 156);
            this.txtTiempoInicio.Name = "txtTiempoInicio";
            this.txtTiempoInicio.Size = new System.Drawing.Size(107, 20);
            this.txtTiempoInicio.TabIndex = 33;
            this.txtTiempoInicio.TextChanged += new System.EventHandler(this.txtTiempoInicio_TextChanged);
            // 
            // lblNombreUsuario2
            // 
            this.lblNombreUsuario2.AutoSize = true;
            this.lblNombreUsuario2.Location = new System.Drawing.Point(9, 42);
            this.lblNombreUsuario2.Name = "lblNombreUsuario2";
            this.lblNombreUsuario2.Size = new System.Drawing.Size(107, 13);
            this.lblNombreUsuario2.TabIndex = 22;
            this.lblNombreUsuario2.Text = "- Nombre de Usuario:";
            this.lblNombreUsuario2.Click += new System.EventHandler(this.lblNombreUsuario2_Click);
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
            // tpReportes
            // 
            this.tpReportes.Location = new System.Drawing.Point(4, 22);
            this.tpReportes.Name = "tpReportes";
            this.tpReportes.Size = new System.Drawing.Size(564, 481);
            this.tpReportes.TabIndex = 2;
            this.tpReportes.Text = "Reportes";
            this.tpReportes.UseVisualStyleBackColor = true;
            // 
            // timerHoras
            // 
            this.timerHoras.Interval = 1000;
            this.timerHoras.Tick += new System.EventHandler(this.timerMints_Tick);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 531);
            this.Controls.Add(this.tcPaginas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(607, 570);
            this.MinimumSize = new System.Drawing.Size(607, 570);
            this.Name = "FormControl";
            this.Text = "Sistema de Control de Llamadas";
            this.Load += new System.EventHandler(this.FormControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tcPaginas.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpBuscar.ResumeLayout(false);
            this.tpBuscar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TabControl tcPaginas;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.TabPage tpBuscar;
        private System.Windows.Forms.TabPage tpReportes;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.TextBox txtTiempoTotal;
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
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblTiempoFin;
        private System.Windows.Forms.Label lblTiempoInicio;
        private System.Windows.Forms.Timer timerHoras;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btLimpiarCampos;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Label lblConsecutivo;
        private System.Windows.Forms.Label lblLlamadaID;
        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Llamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dia;
        private System.Windows.Forms.Button btLimpiarCampos2;
    }
}

