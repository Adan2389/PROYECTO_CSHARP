using COBRANZAS.Model;
using COBRANZAS.Reportes;
using COBRANZAS.Funciones;
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
        // Para el manejo de la capa de negocio (Clientes)
        TClientes_BL clientes_BL = new TClientes_BL();
        // Para crear vistas datos en el datagrid y los filtros de busqueda
        DataView datosView = new DataView();

        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        // Carga el listado de clientes en Grid.
        private void cargarGrid() {
            dgvConsulta.Rows.Clear();
            List<TModelClientes> clientes = this.clientes_BL.getClientes();

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

            datosView = dt.DefaultView;
            dgvConsulta.DataSource = datosView;
        }




        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            datosView.RowFilter = $"Correo like '%{txtFiltro.Text}%' or  Direccion like '%{txtFiltro.Text}%' or  Nombre like '%{txtFiltro.Text}%' or  Identidad like '%{txtFiltro.Text}%' ";
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

        private void materialButton2_Click(object sender, EventArgs e)
        {
            TDataGridViewExportExcel objExportar = new TDataGridViewExportExcel(dgvConsulta, this.Font);
            objExportar.exporToExcel();
        }
    }
}
