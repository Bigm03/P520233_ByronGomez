using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ProductoCategoria
    {
        public int ProductoCategoriaID { get; set; }

        public string ProductoCategoriaDescripcion { get; set; }


        public DataTable Listar()
        {
            DataTable R = new DataTable();


            return R;
        }

    }
}
