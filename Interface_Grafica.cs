using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Control_Llamadas
{
    public partial class FormControl : Form
    {
        Conexion C = new Conexion();
        int segundos, minutos, horas;


        public FormControl()
        {
            InitializeComponent();
            dgvDatos.AutoGenerateColumns = false;
            this.RefrescarDatos();
            this.btFinalizar.Enabled = false;
            this.btInsertar.Enabled = false;
            this.btModificar.Enabled = false;
            //dgvDatos.EditMode = false;
        }



        //Métodos no Utilizados.
        private void FormControl_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Today.ToString("D");
        }

        private void RefrescarDatos()
        {
            using (ModeloContainer conexion = new ModeloContainer())
            {
                this.dgvDatos.DataSource = conexion.Llamadas.ToList();
            }
        }

        private void LimpiarCampos()
        {
            this.txtNombreUsuario.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.lblfecha.Text = DateTime.Today.ToString("D");
            this.lblTiempoInicio.Text = "00:00:00";
            this.lblTiempoFin.Text = "00:00:00";
            this.lblTiempoTotal.Text = "0:0:0";
            this.txtObservaciones.Text = string.Empty;
            this.lblError.Text = string.Empty;
            this.btIniciar.Enabled = true;
            this.btFinalizar.Enabled = false;
            this.btInsertar.Enabled = false;
            this.segundos = 0;
            this.minutos = 0;
            this.horas = 0;
            this.timerHoras.Stop();
        }

        private void LimpiarCampos2()
        {
            this.lblLlamadaID.Text = "Identificador de Llamada";
            this.txtIDllamada.Text = string.Empty;
            this.txtNombreUsuario2.Text = string.Empty;
            this.txtDescripcion2.Text = string.Empty;
            this.dtpFecha2.Value = DateTime.Today;
            this.txtTiempoInicio.Text = string.Empty;
            this.txtTiempoFin.Text = string.Empty;
            this.txtTiempoTotal.Text = string.Empty;
            this.txtObservaciones2.Text = string.Empty;
            this.txtConsecutivo.Text = string.Empty;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Llamada llamada = new Llamada();
                llamada.ID_Llamada = 0;
                llamada.Usuario = this.txtNombreUsuario.Text;
                llamada.Descripcion = this.txtDescripcion.Text;
                llamada.Observaciones = this.txtObservaciones.Text;
                llamada.Fecha = this.lblfecha.Text;
                //Value.ToString("g", CultureInfo.CreateSpecificCulture("es-MX"));
                llamada.Hora_Inicio = this.lblTiempoInicio.Text;
                llamada.Hora_Fin = this.lblTiempoFin.Text;
                llamada.Tiempo_Total = this.lblTiempoTotal.Text;
                llamada.ID_Dia = 1;

                using (ModeloContainer conexion = new ModeloContainer())
                {
                    //conexion.Llamadas.Add(llamada);
                    //conexion.SaveChanges();                    
                    MessageBox.Show(C.insertar(llamada.Usuario, llamada.Descripcion, llamada.Observaciones, llamada.Fecha, llamada.Hora_Inicio, llamada.Hora_Fin, llamada.Tiempo_Total, llamada.ID_Dia));
                    //MessageBox.Show("Llamada Registrada");
                    RefrescarDatos();
                    LimpiarCampos();
                }
            }

        }

        private int ConsecutivoDia()
        {
            int consecutivo = 1;
            using (ModeloContainer conexion = new ModeloContainer())
            {
                //if (conexion.Llamadas.ToList() == null) { }
            }
            return consecutivo;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                using (ModeloContainer conexion = new ModeloContainer())
                {

                    int id = Convert.ToInt32(this.lblLlamadaID.Text);
                    var llamada = conexion.Llamadas.Where(p => p.ID_Llamada == id).FirstOrDefault();
                    if (llamada == null)
                    {
                        MessageBox.Show("No es posible modificar, la llamada no existe.");
                        LimpiarCampos2();
                    }
                    else
                    {
                        //Llamada llamada = new Llamada();
                        llamada.ID_Llamada = Convert.ToInt32(this.lblLlamadaID.Text);
                        llamada.Usuario = this.txtNombreUsuario2.Text;
                        llamada.Descripcion = this.txtDescripcion2.Text;
                        llamada.Observaciones = this.txtObservaciones2.Text;
                        llamada.Fecha = this.dtpFecha2.Text;
                        llamada.Hora_Inicio = this.txtTiempoInicio.Text;
                        llamada.Hora_Fin = this.txtTiempoFin.Text;
                        llamada.Tiempo_Total = this.txtTiempoTotal.Text;
                        llamada.ID_Dia = Convert.ToInt32(this.txtConsecutivo.Text);

                        //conexion.Llamadas.Add(llamada);
                        //conexion.SaveChanges();                    
                        MessageBox.Show(C.insertar(llamada.Usuario, llamada.Descripcion, llamada.Observaciones, llamada.Fecha, llamada.Hora_Inicio, llamada.Hora_Fin, llamada.Tiempo_Total, llamada.ID_Dia));
                        //MessageBox.Show("Llamada Registrada");
                        RefrescarDatos();
                        LimpiarCampos();
                    }
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            using (ModeloContainer conexion = new ModeloContainer())
            {
                if (string.IsNullOrEmpty(this.txtIDllamada.Text))
                {
                    MessageBox.Show("Ingrese el ID de la la llamada a eliminar.");
                    LimpiarCampos2();
                }
                else
                {
                    int id = Convert.ToInt32(this.txtIDllamada.Text);
                    var llamada = conexion.Llamadas.Where(p => p.ID_Llamada == id).FirstOrDefault();
                    if (llamada == null)
                    {
                        MessageBox.Show("No existe llamada con el ID introducido.");
                        LimpiarCampos2();
                    }
                    else
                    {
                        conexion.Llamadas.Remove(llamada);
                        conexion.SaveChanges();
                        MessageBox.Show("La llamada ha sido eliminada con éxito.");
                        LimpiarCampos2();
                        RefrescarDatos();
                    }
                }
            }
        }



        private void btBuscar_Click(object sender, EventArgs e)
        {
            using (ModeloContainer conexion = new ModeloContainer())
            {
                if (string.IsNullOrEmpty(this.txtIDllamada.Text))
                {
                    MessageBox.Show("Ingrese el ID de la la llamada a consultar");
                    LimpiarCampos2();
                }
                else
                {
                    int id = Convert.ToInt32(this.txtIDllamada.Text);
                    var llamada = conexion.Llamadas.Where(p => p.ID_Llamada == id).FirstOrDefault();
                    if (llamada == null)
                    {
                        MessageBox.Show("No existe la llamada con el ID introducido.");
                        LimpiarCampos2();
                    }
                    else
                    {
                        LimpiarCampos2();
                        this.lblLlamadaID.Text = Convert.ToString(llamada.ID_Llamada);
                        this.txtNombreUsuario2.Text = llamada.Usuario;
                        this.txtDescripcion2.Text = llamada.Descripcion;
                        this.dtpFecha2.Text = llamada.Fecha;
                        this.txtTiempoInicio.Text = llamada.Hora_Inicio;
                        this.txtTiempoFin.Text = llamada.Hora_Fin;
                        this.txtTiempoTotal.Text = llamada.Tiempo_Total;
                        this.txtObservaciones2.Text = llamada.Observaciones;
                        this.txtConsecutivo.Text = Convert.ToString(llamada.ID_Dia);
                        this.btModificar.Enabled = true;
                    }
                }
            }
        }


        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            timerHoras.Start();
            this.lblTiempoInicio.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("es-MX"));
            this.btFinalizar.Enabled = true;
            this.btIniciar.Enabled = false;
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            timerHoras.Stop();
            this.lblTiempoFin.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("es-MX"));
            this.btFinalizar.Enabled = false;
            this.btInsertar.Enabled = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtNombreUsuario.Text) && string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                this.lblError.Text = "Ingrese el nombre de la persona que llama y una descripción.";
                return false;
            }
            else
                if (string.IsNullOrEmpty(this.txtNombreUsuario.Text))
            {
                this.lblError.Text = "Ingrese el nombre de la persona que llama ";
                return false;
            }
            else
                if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                this.lblError.Text = "Ingrese una descripción a la llamada.";
                return false;
            }
            /*
            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                this.txtDescripcion.Text = "Ingrese una descripción a la llamada.";
                return false;
            }
            if (string.IsNullOrEmpty(this.txtObservaciones.Text))
            {
                this.txtObservaciones.Text = "Sin Observaciones";
            }*/
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempoFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTiempoTotal_Click(object sender, EventArgs e)
        {

        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void txtTotalMints_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConsecutivo_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempoInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario2_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion2_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {

        }

        private void lblInicio2_Click(object sender, EventArgs e)
        {

        }

        private void lblFin2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtObservaciones2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLimpiarCampos2_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos2();
        }

        private void tpAgregar_Click(object sender, EventArgs e)
        {

        }

        private void timerMints_Tick(object sender, EventArgs e)
        {
            if (minutos == 60)
            {
                horas += 1;
                minutos = 0;
            }
            if (segundos == 60)
            {
                minutos += 1;
                segundos = 0;

            }
            segundos += 1;
            lblTiempoTotal.Text = horas.ToString() + ":" + minutos.ToString() + ":" + segundos.ToString();
        }
    }
}
