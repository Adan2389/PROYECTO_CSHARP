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
using MaterialSkin;

namespace COBRANZAS.CLIENTES
{
    public partial class frmClientes : MaterialForm
    {
        // Objeto de la capa de negocio (Clientes) 
        TClientes_BL clientes_BL = new TClientes_BL();  
        
        // Usuario que opera el modulo
        readonly String USUARIO = "sistema";
        // 1-Nuevo,  2-Modificar 3-Anular
        private int ACCION;                             

        public frmClientes()
        {
            InitializeComponent();
            this.ACCION = 1;
        }

        // Limpia los controles del formulario
        private void limpiar()
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
            this.cargarGrid();
        }

        // Carga la lista de clientes en DataGridView
        private void cargarGrid() {
            dgvClientes.Rows.Clear();
            List<TModelClientes> clientes = this.clientes_BL.getClientes();
            foreach (var x in clientes)
            {
                dgvClientes.Rows.Add(x.Id,
                                     x.Identidad,
                                     x.Nombre,
                                     x.Correo,
                                     x.Telefono,
                                     x.Direccion,
                                     x.Municipio,
                                     x.FechaNacimiento,
                                     x.UsuarioCreacion,
                                     x.Activo);
            }
            this.marcarClientesDesha();
        }

        // Marca en color rojo los clientes deshabilitados
        private void marcarClientesDesha() {
            int NumFilas = 0;
            NumFilas = dgvClientes.Rows.Count;
            if (NumFilas > 0)
            {
                for (int i = 0; i < NumFilas; i++)
                {
                    String ValActivo = "";
                    ValActivo = dgvClientes.Rows[i].Cells["Col_Activo"].Value.ToString();
                    if (ValActivo == "False")
                    {
                        dgvClientes.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(235,107,107);   
                    }
                }
            }
        }




        private void materialButton1_Click(object sender, EventArgs e)
        {
            var cliente =  clientes_BL.consultar(txtId.Text);
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

            bool  res = false;
            String msj_valid = this.clientes_BL.validar(cliente);
            if (msj_valid == "")
            {
                if(this.ACCION == 1)
                    res =  this.clientes_BL.guardar(cliente, this.USUARIO);

                if (this.ACCION == 2) { 
                    cliente.Id = Convert.ToInt32(txtId.Text);
                    res = this.clientes_BL.modificar(cliente, this.USUARIO);
                }
                if (res){ 
                    MessageBox.Show("El cliente se ha guardado con exito", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    this.cargarGrid();
                }
                else
                    MessageBox.Show("El cliente no se ha podido guardar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(msj_valid, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.cargarGrid();   
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int NumFila = e.RowIndex;
            txtId.Text = dgvClientes.Rows[NumFila].Cells["Col_Id"].Value.ToString();
            txtIdentidad.Text = dgvClientes.Rows[NumFila].Cells["Col_Identidad"].Value.ToString();
            txtNombre.Text = dgvClientes.Rows[NumFila].Cells["Col_Nombre"].Value.ToString();
            txtDireccion.Text = dgvClientes.Rows[NumFila].Cells["Col_Direccion"].Value.ToString();
            txtCorreo.Text = dgvClientes.Rows[NumFila].Cells["Col_Correo"].Value.ToString();
            txtTelefono.Text = dgvClientes.Rows[NumFila].Cells["Col_Telefono"].Value.ToString();
            txtMunicipio.Text = dgvClientes.Rows[NumFila].Cells["Col_Municipio"].Value.ToString();
            dtpFechaNac.Text = dgvClientes.Rows[NumFila].Cells["Col_Fecha_Nacimiento"].Value.ToString();
            this.ACCION = 2;
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtId.Text)))
            {
                if (this.clientes_BL.anular(txtId.Text))
                {
                    MessageBox.Show("El clientes se ha anulado con exito!", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiar();
                }
                else
                    MessageBox.Show("El cliente no se pudo anular!", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("Es necesario seleccionar un cliente para anularlo!", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
