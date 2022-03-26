using COBRANZAS.AdminDB;
using System;
using System.Windows.Forms;

namespace COBRANZAS.Reportes
{
    public partial class frmVisorReportes : Form
    {
        // Obtiene los parametros de la conexion DB
        TParamSql objParamSql = new TParamSql();
        // Codigo utilizado para paso de paratro a los reportes
        public String CODIGO = "";
        // El nombre del reporte a mostrar/imprimir
        public string REPORTE = "";

        public frmVisorReportes()
        {
            InitializeComponent();
        }

        // Muestra el reporte de crstal en formulario
        private void mostarReporte() {

            if (this.REPORTE == "rptListadoClientes") {
                rptListadoClientes reporte = new rptListadoClientes();
                reporte.SetDatabaseLogon(objParamSql.getUser(), objParamSql.getPassword());
                reporte.SetParameterValue("@TextoBuscar", this.CODIGO);
                crVisor.ReportSource = reporte;
                crVisor.Show();
            }
        }


        private void frmVisorReportes_Load(object sender, EventArgs e)
        {
            this.mostarReporte();
        }
    }
}
