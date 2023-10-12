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
    public partial class FrmUsuarioGestion : Form
    {
        public FrmUsuarioGestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DgvListausuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuarioGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarListaUsuarios();
        }

        //todas las funcionalidades especificas y que se puedan reutilizar DEBEN
        //ser encapsuladadas
        private void CargarListaUsuarios()
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();

            lista = miusuario.ListarActivos();

            DgvListausuarios.DataSource = lista;
        }
    }
}
