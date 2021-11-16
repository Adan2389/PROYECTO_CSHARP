using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBRANZAS.Model
{
    public class TModelClientes
    {
        public int Id { set; get; }
        public String Identidad { set; get; }
        public String Nombre { set; get; }
        public String Direccion { set; get; }
        public String Telefono { set; get; }
        public String Correo { set; get; }
        public String Municipio { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public DateTime FechaCreacion { set; get; }
        public DateTime FechaModificacion { set; get; }
        public String UsuarioCreacion { set; get; }
        public String UsuarioMofica { set; get; }
    }




}
