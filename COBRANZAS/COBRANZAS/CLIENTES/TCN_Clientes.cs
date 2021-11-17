using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Data;

namespace COBRANZAS.CLIENTES
{
    class TCN_Clientes
    {
        TAD_Clientes AD_Clientes = new TAD_Clientes();

        public TModelClientes Consultar(String Id) {
            var result = int.TryParse(Id, out int valId);
            if (result)
                return AD_Clientes.Consultar(valId);
            else
                return default;
        }


        public bool Guardar(TModelClientes prmcliente, String prmUsuario)
        {
            return this.AD_Clientes.Guardar(prmcliente, prmUsuario);
        }

        public bool Modificar(TModelClientes prmcliente, String prmUsuario)
        {
            return this.AD_Clientes.Modificar(prmcliente, prmUsuario);
        }



    }
}
