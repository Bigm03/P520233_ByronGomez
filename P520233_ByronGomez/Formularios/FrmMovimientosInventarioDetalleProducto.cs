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
    public partial class FrmMovimientosInventarioDetalleProducto : Form
    {
        DataTable ListaProductos {  get; set; }

        DataTable ListaProductosConFiltro { get; set; }

        Logica.Models.Producto MiProducto { get; set; }

        public FrmMovimientosInventarioDetalleProducto()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            ListaProductosConFiltro = new DataTable();

            MiProducto = new Logica.Models.Producto();
        }

        private void FrmMovimientosInventarioDetalleProducto_Load(object sender, EventArgs e)
        {

            LlenarLista();

        }

        private void LlenarLista()
        {
            ListaProductos = MiProducto.ListarEnMovimientoDetalleProducto();

            DgvLista.DataSource = ListaProductos;

            DgvLista.ClearSelection();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool Validar()
        {
            bool R = false;

            if (DgvLista.SelectedRows.Count == 1 && NtxtCantidad.Value > 0)
            {
                R = true;
            }
            else
            {
                //si no se selecciono algo en la lista
                if (DgvLista.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe de seleccionar un producto de la lista", "Error de validacion", MessageBoxButtons.OK);
                    return false;

                }

                if (NtxtCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero o negativa", "Error de validacion", MessageBoxButtons.OK);
                    return false;

                }
            }

            return R;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                //el dgv (la parte grafica) tiene de fondo un DataTable que lo alimenta
                //como se ocultaron 3 columnas en el dgv, no se podra obtener el dato que
                //contienen. En este caso se usara el DataTable para obtener dichos datos
                //(costo, subtotal, %iva)

                DataGridViewRow MiDgvFila = DgvLista.SelectedRows[0];
                int IDProducto = Convert.ToInt32(MiDgvFila.Cells["CProductoID"].Value);

                // una vez que tenemos el ID del Producto, recorremos el datatable
                //buscando dicho ID

                foreach (DataRow item in ListaProductos.Rows)
                {
                    if (IDProducto == Convert.ToInt32(item["ProductoID"]))
                    {
                        //cuando la comparacion es correcta, tenemos todo lo necesario para
                        //crear la nueva fila en el formulacio de movimiento de Inventario

                        //1. Creamos un nuevo objeto fila del formulario de nov de inv

                        DataRow NuevaFila = Globales.ObjetosGlobales.MiFormularioMovimientos.DtListaDetalleProductos.NewRow();

                        NuevaFila["ProductoID"] = IDProducto;

                        NuevaFila["NombreProducto"] = item["NombreProducto"].ToString();

                        NuevaFila["CantidadMovimiento"] = Convert.ToDecimal(NtxtCantidad.Value);

                        NuevaFila["Costo"] = Convert.ToDecimal(item["Costo"]);

                        NuevaFila["SubTotal"] = Convert.ToDecimal(item["SubTotal"]);

                        //necesito hacer el calculo del total del impuesto, no basta con el % del iva
                        decimal TasaIva = Convert.ToDecimal(item["TasaImpuesto"]);
                        decimal SubTotal = Convert.ToDecimal(item["SubTotal"]);
                        decimal TotalIva = SubTotal * TasaIva / 100;
                        NuevaFila["TotalIVA"] = TotalIva;

                        NuevaFila["PrecioUnitario"] = Convert.ToDecimal(item["PrecioUnitario"]);

                        NuevaFila["CodigoBarras"] = item["CodigoBarras"].ToString();

                        //una vez que tenemos la nuevafila cargada con data, se procede a adjuntarla
                        //al datatable del detalle del movimiento y cerramos este form con respuesta OK

                        Globales.ObjetosGlobales.MiFormularioMovimientos.DtListaDetalleProductos.Rows.Add(NuevaFila);

                        DialogResult = DialogResult.OK;

                        break;
                    }
                }
            }
        }
    }
}
