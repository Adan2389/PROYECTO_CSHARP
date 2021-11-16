using MaterialSkin.Controls;
using System;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    public partial class frmClientes : MaterialForm
    {
        TCN_Clientes CN_Clientes = new TCN_Clientes();
        readonly String USUARIO = "sistema";

        public frmClientes()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var cliente =  CN_Clientes.Consultar(txtId.Text);
            if (cliente != null){ 
                txtNombre.Text = cliente.Nombre;
                txtIdentidad.Text = cliente.Identidad;
                txtCorreo.Text = cliente.Correo;
                dtpFechaNac.Value = cliente.FechaCreacion;
                txtCorreo.Text = cliente.Correo;
                txtDireccion.Text = cliente.Direccion;
                txtMunicipio.Text = cliente.Municipio;
                //dtpFechaNac.Text = cliente.FechaNacimiento.Date.ToString("dd/MM/yyyy");
                lblCreadoEl.Text = $"Creado el: { cliente.FechaCreacion } ";
                lblCreadoPor.Text = $"Creado por: { cliente.UsuarioCreacion } ";
            }
            dgvClientes.DataSource = cliente;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            TModelClientes cliente = new TModelClientes();

            cliente.Identidad = txtIdentidad.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Municipio = txtMunicipio.Text;
            cliente.FechaNacimiento = dtpFechaNac.Value;

            var res =  this.CN_Clientes.Guardar(cliente, this.USUARIO);
            if (res)
                MessageBox.Show("El cliente se ha guardado con exito");
            else
                MessageBox.Show("El cliente no se ha podido guardar");

        }
    }
}
