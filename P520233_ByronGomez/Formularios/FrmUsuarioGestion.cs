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

            CargarListaUsuarios(CbVerActivos.Checked);

            ActivarBotonAgregar();
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
        private void CargarListaUsuarios(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();


            if (VerActivos)
            {
                //Si se qiere ver los usuarios activos
                lista = miusuario.ListarActivos(FiltroBusqueda);
                DgvListausuarios.DataSource = lista;
            }
            else
            {
                //Usuarios inactivos
                lista = miusuario.ListarInactivos(FiltroBusqueda);
                DgvListausuarios.DataSource = lista;
            }
        }

        private bool ValidarDatosRequeridos(bool OmitirContrasennia = false)
        {
            bool R = false;

            //validar que se haya digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) && 
                CboxUsuarioTipoRol.SelectedIndex > -1
                )
            {
                if (OmitirContrasennia)
                {
                    //Si se omite la contraseña entonces se pasa a true
                    R = true;
                }
                else
                {
                    //Si no se omite la contraseña debemos validar tambien ese campo
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    { 
                        //CONTRASEÑA
                        if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar la contraseña", "Error de validacion", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
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
                            CargarListaUsuarios(CbVerActivos.Checked);
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListausuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListausuarios.SelectedRows.Count == 1)
            {
                LimpiarForm();

                //ColUsuarioID

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListausuarios.SelectedRows[0];
                int IDUsuario = Convert.ToInt32(MiDgvFila.Cells["ColUsuarioID"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IDUsuario);

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos
                    //datos en los controles correspondientes del formulario

                    TxtUsuarioCodigo.Text = MiUsuarioLocal.UsuarioID.ToString();
                    TxtUsuarioCedula.Text = MiUsuarioLocal.Cedula.ToString();
                    TxtUsuarioNombre.Text = MiUsuarioLocal.Nombre.ToString();
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.Correo.ToString();
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.Telefono.ToString();
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.Direccion.ToString();

                    //en este caso no quiero que se muestre la contraseña ya que está encriptada y no se
                    //requiere actualizarla y se deja en blanco el campo de texto

                    CboxUsuarioTipoRol.SelectedValue = MiUsuarioLocal.MiUsuarioRol.UsuarioRolID;
                    CbUsuarioActivo.Checked = MiUsuarioLocal.Activo;

                    ActivarBotonesModificarYEliminar();
                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarBotonesModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgvListausuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //esto limpiar la seleccion de fila automatica que es el comportamiento estandar del control
            DgvListausuarios.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            //al igual que con el agregar, se deben validar los datos requeridos pero,
            //el campo de la contraseña debe ser opcional en este caso

            if (ValidarDatosRequeridos(true))
            {
                //transferimos al objeto local los posibles cambios que se hayan hecho en los datos del usuario
                
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                //depende de si se digito o no una contraseña, habrian dos distintos UPDATE en los SPs
                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();

                //en el diagrama expandido de casos de uso para el tema Usuario, se indica
                //que para modificar o leiminar primero se debe consultar por el ID
                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("¿Desea modificar el usuario?", "???",
                                                             MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes) 
                    {
                        //procedemos a modificar el registro del usuario
                        if (MiUsuarioLocal.Actualizar())
                        {
                            MessageBox.Show("Usuario modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios(CbVerActivos.Checked);
                            ActivarBotonAgregar();

                        }
                    
                    
                    
                    }




                }



            }



        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                if (MiUsuarioLocal.UsuarioID > 0)
                {
                    string msg = string.Format("¿Está seguro de eliminar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes && MiUsuarioLocal.Eliminar())
                    {
                        MessageBox.Show("El Usuario ha sido eliminado", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);
                        ActivarBotonAgregar();

                    }
                }
            }
            else
            {
                //se procede a activar
                if (MiUsuarioLocal.UsuarioID > 0)
                {
                    string msg = string.Format("¿Está seguro de activar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes && MiUsuarioLocal.Activar())
                    {
                        MessageBox.Show("El Usuario ha sido activado", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);
                        ActivarBotonAgregar();

                    }
                }
            }







            
        }

        private void TxtUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e,false,true);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                CargarListaUsuarios(CbVerActivos.Checked, TxtBuscar.Text.Trim());
            }
            else
            {
                CargarListaUsuarios(CbVerActivos.Checked);
            }
        }
    }
}
