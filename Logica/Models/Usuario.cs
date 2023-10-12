using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {
        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();
        }

        public int UsuarioID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasennia { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public UsuarioRol MiUsuarioRol { get; set; }

        //comportamientos, operaciones, funciones, métodos

        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula(string Cedula)
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCorreo(string Correo)
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            //hay que hacer instancia de la clase conexion

            Conexion MiCnn = new Conexion();
            //como el SP para listar requiere un párametro, hay que agregarlo a la lista
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSelect("SPUsuariosListar");
            
            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
