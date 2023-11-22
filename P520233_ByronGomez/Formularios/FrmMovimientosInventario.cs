using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_ByronGomez.Formularios
{
    public partial class FrmMovimientosInventario : Form
    {

        public Logica.Models.Movimiento MiMovimientoLocal { get; set; }

        public DataTable DtListaDetalleProductos {  get; set; }

        public FrmMovimientosInventario()
        {
            InitializeComponent();

            MiMovimientoLocal = new Logica.Models.Movimiento();

            DtListaDetalleProductos = new DataTable();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboMovimientoInventario();

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {

            DtpFecha.Value = DateTime.Now.Date;
            CboxTipo.SelectedIndex = 0;
            TxtAnotaciones.Clear();

            //en este caso particular el datatable que alimenta el dgv
            //DEBE tener estructura, pero no datos inicialmente 
            //considerando eso, llenaremos el datatable con el ESQUEMA
            //de la consulta del SP SPMovimientoCargarDetalle
            //esto permite tener  el dt sin filas, pero con estructura,
            //que permite agregar filas posteriormente.

            DtListaDetalleProductos = MiMovimientoLocal.AsignarEsquemaDelDetalle();

            DgvListaDetalle.DataSource = DtListaDetalleProductos;

            //limpiamos los totales
            LblTotalCosto.Text = "0";
            LblTotalGranTotal.Text = "0";
            LblTotalImpuestos.Text = "0";
            LblTotalSubTotal.Text = "0";

        }

        private void CargarComboMovimientoInventario()
        {
            Logica.Models.MovimientoTipo MiTipo = new Logica.Models.MovimientoTipo();

            DataTable dt = new DataTable();

            dt = MiTipo.ListarTipo();

            if (dt != null && dt.Rows.Count > 0)
            {
                //una asegurado que el dt tiene valores, los "dibujo" en el combobox
                CboxTipo.ValueMember = "id";
                CboxTipo.DisplayMember = "Descripcion";

                CboxTipo.DataSource = dt;

                CboxTipo.SelectedIndex = -1;


            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //el formulario que muestra la lista de items, se debe mostrar en este
            //caso particular en formato de Dialogo, ya que queremos cortar
            //temporalmente el funcionamiento del form actual, hacer algo en
            //el otro form y esperar una respuesta

            Form FormDetalleProducto = new Formularios.FrmMovimientosInventarioDetalleProducto();

            DialogResult resp = FormDetalleProducto.ShowDialog();

            if (resp == DialogResult.OK) 
            { 
                //TODO agregar la nueva linera de detalle
                

            }

        }
    }
}
