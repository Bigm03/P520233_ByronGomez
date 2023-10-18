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
        //objeto local de tipo usuario.
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuarioGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
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

            CargarComboRolesDeUsuario();

            CargarListaUsuarios();
        }

        private void CargarComboRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable dt = new DataTable();

            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //una asegurado que el dt tiene valores, los "dibujo" en el combobox
                CboxUsuarioTipoRol.ValueMember = "id";
                CboxUsuarioTipoRol.DisplayMember = "Descripcion";

                CboxUsuarioTipoRol.DataSource = dt;

                CboxUsuarioTipoRol.SelectedIndex = -1;


            }

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

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            //validar que se haya digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()) &&
                CboxUsuarioTipoRol.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                //indicar al usuario que validacion esta faltando

                //CEDULA
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cedula", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                //NOMBRE
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                //CORREO
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el correo", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                //CONTRASEÑA
                if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                //ROL DE USUARIO
                if (CboxUsuarioTipoRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol de usuario", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }



            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //lo primero que debemos hacer es validar los datos minimos requeridos,
            //esto se hace para evitar que queden registros sin datos a nivel de db
            //pero tambien porque es un campo de base de datos no acepta valores NULL
            //y se llama al INSERT, dara error

            //Luego de esto y tomando en consideracion el diagrama de casos de uso expandido
            //de usuario, hay que hacer validar que NO exista un usuario con la cedula y/o
            //correo que se digitaron(No se pueden repetir estos datos en distintas
            //filas en la tabla Usuario)

            //Si  ambas validaciones son Negativas entonces se procede a Agregar() el usuario.

            //-----------------------------------//

            //usaremos un objeto local de tipo Usuario, que sera al que daremos forma para luego
            //usar las funciones como agregar. actualizar, eliminar, etc.
            if (ValidarDatosRequeridos())
            {
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();

                //con el combo de rol hay que extraer el valuemember seleccionado.
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);

                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                bool CedulaOk = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);

                bool CorreoOk = MiUsuarioLocal.ConsultarPorCorreo(MiUsuarioLocal.Correo);

                if (CedulaOk == false && CorreoOk == false)
                {

                    //se solicita confimacion por parte del usuario

                    string Pregunta = string.Format("¿Esta seguro de agregar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        //procedemos a Agregar el usuario

                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario ingresado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo agregar", ":(", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }


        private void LimpiarForm()
        {
            TxtUsuarioCodigo.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioContrasennia.Clear();
            TxtUsuarioDireccion.Clear();

            CboxUsuarioTipoRol.SelectedIndex = -1;

            CbUsuarioActivo.Checked = false;
        }






    }
}
