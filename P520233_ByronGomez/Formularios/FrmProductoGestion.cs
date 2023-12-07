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
    public partial class FrmProductoGestion : Form
    {
        public Logica.Models.Producto MiProductoLocal { get; set; }

        public FrmProductoGestion()
        {
            InitializeComponent();

            MiProductoLocal = new Logica.Models.Producto();
        }

        private void FrmProductoGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboCategoriasDeProducto();

            CargarListaProductos(CbVerActivos.Checked);
        }

        private void CargarComboCategoriasDeProducto()
        {
            Logica.Models.ProductoCategoria MiCategoria = new Logica.Models.ProductoCategoria();

            DataTable dt = new DataTable();

            dt = MiCategoria.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CboxProductoTipoCategoria.ValueMember = "id";
                CboxProductoTipoCategoria.DisplayMember = "Descripcion";

                CboxProductoTipoCategoria.DataSource = dt;

                CboxProductoTipoCategoria.SelectedIndex = -1;


            }

        }

        private void CargarListaProductos(bool VerActivos)
        {
            Logica.Models.Producto miproducto = new Logica.Models.Producto();

            DataTable lista = new DataTable();


            if (VerActivos)
            {

                lista = miproducto.ListarActivos();
                DgvListaProductos.DataSource = lista;
            }
            else
            {

                lista = miproducto.ListarInactivos();
                DgvListaProductos.DataSource = lista;
            }
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoCosto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoUtilidad.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoSubTotal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoTasaImpuesto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoPrecioUnitario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoCantidadStock.Text.Trim()) &&
                CboxProductoTipoCategoria.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Codigo", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoCosto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el costo", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoUtilidad.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la utilidad", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoSubTotal.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el subtotal", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoTasaImpuesto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la la tasa de impuesto", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el precio unitario", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProductoCantidadStock.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cantidad", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (CboxProductoTipoCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una categoria de producto", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            TxtProductoCodigo.Clear();
            TxtProductoCodigoBarras.Clear();
            TxtProductoNombre.Clear();
            TxtProductoCosto.Clear();
            TxtProductoUtilidad.Clear();
            TxtProductoSubTotal.Clear();
            TxtProductoTasaImpuesto.Clear();
            TxtProductoPrecioUnitario.Clear();
            TxtProductoCantidadStock.Clear();

            CboxProductoTipoCategoria.SelectedIndex = -1;

            CbUsuarioActivo.Checked = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                MiProductoLocal = new Logica.Models.Producto();

                MiProductoLocal.CodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.NombreProducto = TxtProductoNombre.Text.Trim();
                MiProductoLocal.Costo = Convert.ToDecimal(TxtProductoCosto.Text.Trim());
                MiProductoLocal.Utilidad = Convert.ToDecimal(TxtProductoUtilidad.Text.Trim());
                MiProductoLocal.SubTotal = Convert.ToDecimal(TxtProductoSubTotal.Text.Trim());
                MiProductoLocal.TasaImpuesto = Convert.ToDecimal(TxtProductoTasaImpuesto.Text.Trim());
                MiProductoLocal.PrecioUnitario = Convert.ToDecimal(TxtProductoPrecioUnitario.Text.Trim());
                MiProductoLocal.CantidadStock = Convert.ToDecimal(TxtProductoCantidadStock.Text.Trim());
                MiProductoLocal.MiCategoria.ProductoCategoriaID = Convert.ToInt32(CboxProductoTipoCategoria.SelectedValue);

                bool CodigoBarraOk = MiProductoLocal.ConsultarPorCodigoBarras(MiProductoLocal.CodigoBarras);

                if (CodigoBarraOk == false)
                {



                    string Pregunta = string.Format("¿Esta seguro de agregar al producto {0}?", MiProductoLocal.NombreProducto);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {


                        bool ok = MiProductoLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Producto ingresado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaProductos(CbVerActivos.Checked);
                        }
                        else
                        {
                            MessageBox.Show("El Productos no se pudo agregar", ":(", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
    }
}
