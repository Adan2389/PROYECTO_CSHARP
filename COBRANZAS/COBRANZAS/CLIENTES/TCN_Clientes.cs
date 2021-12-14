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
    class TCN_Clientes
    {
        TAD_Clientes AD_Clientes = new TAD_Clientes();
        private readonly int  MIN_EDAD = 18;                // Cantidad de minima de años para registrar la fecha nacimiento 


        public TModelClientes Consultar(String Id) {
            var result = int.TryParse(Id, out int valId);
            if (result)
                return AD_Clientes.Consultar(valId);
            else
                return default;
        }

        public String Validar(TModelClientes prmCliente) {
            String msj_valid = "";

            if (String.IsNullOrWhiteSpace(prmCliente.Identidad))
                msj_valid += $"-En necesario que ingrese un numero de identidad \n";

            if (prmCliente.Identidad.Length != 13)
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

        public bool Guardar(TModelClientes prmcliente, String prmUsuario)
        {
            return this.AD_Clientes.Guardar(prmcliente, prmUsuario);
        }

        public bool Modificar(TModelClientes prmcliente, String prmUsuario)
        {
            return this.AD_Clientes.Modificar(prmcliente, prmUsuario);
        }

        public bool Anular(String prmIdCliente) {
            bool res = false;
            if (int.TryParse(prmIdCliente, out int valId))
            {
                res = this.AD_Clientes.Anular(valId);
            }
            else {
                MessageBox.Show("El varlor del Id es invalido!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            return res;
        }

        public List<TModelClientes> GetClientes() {
            return this.AD_Clientes.GetClientes();
        }


    }
}
