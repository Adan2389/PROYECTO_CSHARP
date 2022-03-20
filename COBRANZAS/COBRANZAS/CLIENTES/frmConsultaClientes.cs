using COBRANZAS.Model;
using COBRANZAS.Reportes;
using MaterialSkin.Controls;
using System;
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
    public partial class frmConsultaClientes : MaterialForm
    {
        TClientes_BL Clientes_BL = new TClientes_BL();
        DataView DatosView = new DataView();


        public frmConsultaClientes()
        {
            InitializeComponent();
        }


        // Carga el listado de clientes en Grid.
        private void CargarGrid() {
            dgvConsulta.Rows.Clear();
            List<TModelClientes> clientes = this.Clientes_BL.GetClientes();

            DataTable dt = new DataTable();
            dt.Columns.Add("Identidad");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Correo");
            dt.Columns.Add("Fecha Nacimiento");
            dt.Columns.Add("Activo");

            foreach (var c in clientes)
                dt.Rows.Add(c.Identidad, c.Nombre, c.Direccion, c.Telefono, c.Correo, c.FechaNacimiento, c.Activo);

            DatosView = dt.DefaultView;
            dgvConsulta.DataSource = DatosView;
        }




        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            this.CargarGrid();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            DatosView.RowFilter = $"Correo like '%{txtFiltro.Text}%' or  Direccion like '%{txtFiltro.Text}%' or  Nombre like '%{txtFiltro.Text}%' or  Identidad like '%{txtFiltro.Text}%' ";
        }

        private void TxtIdentidad_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frmVisorReportes objVisorReportes = new frmVisorReportes();
            objVisorReportes.CODIGO = txtFiltro.Text;
            objVisorReportes.REPORTE = "rptListadoClientes";
            objVisorReportes.ShowDialog();
        }
    }
}
