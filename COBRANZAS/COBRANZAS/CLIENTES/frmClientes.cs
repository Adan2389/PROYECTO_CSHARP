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
        TCN_Clientes CN_Clientes = new TCN_Clientes();  // Objeto de la capa de negocio (Clientes) 
        readonly String USUARIO = "sistema";            
                                                          
        private int ACCION;                             // 1-Nuevo,  2-Modificar 3-Anular

        public frmClientes()
        {
            InitializeComponent();
            this.ACCION = 1;
        }

        private void Limpiar()
        {
            txtId.Text = "";
            dtpFechaNac.Value = DateTime.Now;
            txtNombre.Text = "";
            txtIdentidad.Text = "";
            txtCorreo.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtMunicipio.Text = "";
            dtpFechaNac.Text = "";
            lblCreadoEl.Text = "";
            lblCreadoPor.Text = "";
            lblFechaModif.Text = "";
            lblModificadoPor.Text = "";
            txtTelefono.Text = "";
            this.ACCION = 1;
            txtId.Enabled = true;
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
                dtpFechaNac.Text = cliente.FechaNacimiento.Date.ToString("dd/MM/yyyy");
                lblCreadoEl.Text = $"Creado el: { cliente.FechaCreacion } ";
                lblCreadoPor.Text = $"Creado por: { cliente.UsuarioCreacion } ";
                lblFechaModif.Text = $" Fecha Modificacion:  {cliente.FechaModificacion } ";
                lblModificadoPor.Text = $" Modificado por: {cliente.UsuarioMofica} ";
                txtTelefono.Text = cliente.Telefono;
                this.ACCION = 2;
                txtId.Enabled = false;
            }
            dgvClientes.DataSource = cliente;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            TModelClientes cliente = new TModelClientes();
            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Identidad = txtIdentidad.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Municipio = txtMunicipio.Text;
            cliente.FechaNacimiento = dtpFechaNac.Value;

            bool  res = false;
            if(this.ACCION == 1)
                res =  this.CN_Clientes.Guardar(cliente, this.USUARIO);

            if(this.ACCION == 2)
                res = this.CN_Clientes.Modificar(cliente, this.USUARIO);

            if (res){ 
                MessageBox.Show("El cliente se ha guardado con exito", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("El cliente no se ha podido guardar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
