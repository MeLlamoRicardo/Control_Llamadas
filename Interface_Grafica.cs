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

namespace Control_Llamadas
{
    public partial class FormControl : Form
    {
        Conexion  C = new Conexion();
        public FormControl()
        {
            InitializeComponent();
            dgvDatos.AutoGenerateColumns = false;
            this.RefrescarDatos();
            this.btFinalizar.Enabled = false;
            this.btInsertar.Enabled = false; 
        }



        //Métodos no Utilizados.
        private void FormControl_Load(object sender, EventArgs e)
        {

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
            this.txtNombreUsuario2.Text = string.Empty;
            this.txtDescripcion2.Text = string.Empty;
            this.dtpFecha2.Value = DateTime.Today;
            this.txtTiempoInicio.Text = string.Empty;
            this.txtTiempoFin.Text = string.Empty;
            this.txtTotalMints.Text = string.Empty;
            this.txtObservaciones2.Text = string.Empty;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                
                Llamada llamada = new Llamada();
                llamada.ID_Llamada = 0;
                llamada.Usuario = this.txtNombreUsuario1.Text;
                llamada.Descripcion = this.txtDescripcion.Text;
                llamada.Observaciones = this.txtObservaciones.Text;
                llamada.Fecha = this.dtpFecha.Value.ToString("g", CultureInfo.CreateSpecificCulture("es-MX"));
                llamada.Hora_Inicio = this.lblTiempoInicio.Text;
                llamada.Hora_Fin = this.lblTiempoFin.Text;
                llamada.Total_Minutos = this.lblTotalMints.Text;
                llamada.ID_Dia = 1;
                
                using (ModeloContainer conexion = new ModeloContainer())
                {
                    //conexion.Llamadas.Add(llamada);
                    //conexion.SaveChanges();                    

                    MessageBox.Show(C.insertar(llamada.Usuario, llamada.Descripcion, llamada.Observaciones, llamada.Fecha, llamada.Hora_Inicio, llamada.Hora_Fin, llamada.Total_Minutos, llamada.ID_Dia));
                    //MessageBox.Show("Llamada Registrada");
                    RefrescarDatos();
                }
            }

        }

        /*
        private int ConsecutivoID()
        {
            int consecutivo = 0;
            using (ModeloContainer conexion = new ModeloContainer())
            {
                //Array miLista = conexion.Llamadas.ToArray();
                //int p = miLista.GetLength();
                ArrayList miArray = new <Llamada>ArrayList();
                miArray = conexion.Llamadas.ToArray();
                List llamada = conexion.Llamadas.ToList(); //SqlQuery("SELECT MAX(ID_Llamada)");

                if (llamada == null)
                {
                    consecutivo = 1;
                }
                else
                {
                    consecutivo = llamada.ID_Llamada + 1; 
                }
            }
            return consecutivo;
        }
        */ 

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

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            using (ModeloContainer conexion = new ModeloContainer())
            {
                if (string.IsNullOrEmpty(this.txtIDllamada.Text))
                {
                    MessageBox.Show("Ingrese el ID de la la llamada a eliminar.");
                    LimpiarCampos();
                }
                else
                {
                    int id = Convert.ToInt32(this.txtIDllamada.Text);
                    var llamada = conexion.Llamadas.Where(p => p.ID_Llamada == id).FirstOrDefault();
                    if (llamada == null)
                    {
                        MessageBox.Show("No existe llamada con el ID introducido.");
                        LimpiarCampos();
                    }
                    else
                    {
                        conexion.Llamadas.Remove(llamada);
                        conexion.SaveChanges();
                        MessageBox.Show("La llamada ha sido eliminada con éxito.");
                        LimpiarCampos();
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
                    LimpiarCampos();
                }
                else
                {
                    int id = Convert.ToInt32(this.txtIDllamada.Text);
                    var llamada = conexion.Llamadas.Where(p => p.ID_Llamada == id).FirstOrDefault();
                    if (llamada == null)
                    {
                        MessageBox.Show("No existe la llamada con el ID introducido.");
                        LimpiarCampos();
                    }
                    else
                    {
                        this.txtNombreUsuario2.Text = llamada.Usuario;
                        this.txtDescripcion2.Text = llamada.Descripcion;
                        this.dtpFecha2.Text = llamada.Fecha;
                        this.txtTiempoInicio.Text = llamada.Hora_Inicio;
                        this.txtTiempoFin.Text = llamada.Hora_Fin;
                        this.txtTotalMints.Text = llamada.Total_Minutos;
                        this.txtObservaciones2.Text = llamada.Observaciones;
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
            this.lblTiempoInicio.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("es-MX"));
            this.btFinalizar.Enabled = true;
            this.btIniciar.Enabled = false;
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            this.lblTiempoFin.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("es-MX"));
            this.btFinalizar.Enabled = false;
            this.btInsertar.Enabled = true;

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtNombreUsuario1.Text))
            {
                this.txtNombreUsuario1.Text = "Ingrese el nombre de la persona que llama.";
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                this.txtDescripcion.Text = "Ingrese una descripción a la llamada.";
                return false;
            }
            if (string.IsNullOrEmpty(this.txtObservaciones.Text))
            {
                this.txtObservaciones.Text = "Sin Observaciones";
            }
            return true; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempoFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpAgregar_Click(object sender, EventArgs e)
        {

        }


    }
}
