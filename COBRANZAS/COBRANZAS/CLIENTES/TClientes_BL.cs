using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Data;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    class TClientes_BL
    {
        // Para utilizar la capa DAL Clientes
        TClientes_DAL Clientes_DAL = new TClientes_DAL();
        // Cantidad de minima de años para registrar la fecha nacimiento 
        private readonly int  MIN_EDAD = 18;                

        // Consulta un clientes por ID
        public TModelClientes Consultar(String Id) {
            var result = int.TryParse(Id, out int valId);
            if (result)
                return Clientes_DAL.Consultar(valId);
            else
                return default;
        }

        // Valida los datos del cliente
        public String Validar(TModelClientes prmCliente) {
            String msj_valid = "";

            if (String.IsNullOrWhiteSpace(prmCliente.Identidad))
                msj_valid += $"-En necesario que ingrese un numero de identidad \n";

            if (prmCliente.Identidad.Length != 15)
                msj_valid += $"-El numero de identidad no es correcto \n";

            if (String.IsNullOrWhiteSpace(prmCliente.Nombre))
                msj_valid += $"-En necesario que ingrese el nombre\n";

            if (String.IsNullOrWhiteSpace(prmCliente.Direccion))
                msj_valid += $"-En necesario que ingrese una direccion valida \n";

            if (String.IsNullOrWhiteSpace(prmCliente.Telefono))
                msj_valid += $"-En necesario que ingrese el telefono \n";

            if (String.IsNullOrWhiteSpace(prmCliente.Municipio))
                msj_valid += $"-En necesario que ingrese el municipio \n";

            DateTime FechaActual = DateTime.Now;
            DateTime FechaNacimento = prmCliente.FechaNacimiento;
            if(!((FechaActual.Year - FechaNacimento.Year) >= this.MIN_EDAD))
                 msj_valid += $"-El año de nacimiento tiene que ser menor a : {FechaActual.Year}\n";



            return msj_valid;
        }

        // Guarda los datos de un cliente
        public bool Guardar(TModelClientes prmcliente, String prmUsuario)
        {
            return this.Clientes_DAL.Guardar(prmcliente, prmUsuario);
        }

        // Modifica los datos de un cliente
        public bool Modificar(TModelClientes prmcliente, String prmUsuario)
        {
            return this.Clientes_DAL.Modificar(prmcliente, prmUsuario);
        }

        // Anula un cliente
        public bool Anular(String prmIdCliente) {
            bool res = false;
            if (int.TryParse(prmIdCliente, out int valId))
            {
                res = this.Clientes_DAL.Anular(valId);
            }
            else {
                MessageBox.Show("El varlor del Id es invalido!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            return res;
        }

        // Devuelve la lista de clientes
        public List<TModelClientes> GetClientes() {
            return this.Clientes_DAL.GetClientes();
        }


    }
}
