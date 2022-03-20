using COBRANZAS.AdminDB;
using System;
using System.Windows.Forms;

namespace COBRANZAS.Reportes
{
    public partial class frmVisorReportes : Form
    {
        TParamSql objParamSql = new TParamSql();
        public String CODIGO = "";
        public string REPORTE = "";

        public frmVisorReportes()
        {
            InitializeComponent();
        }

        private void MostarReporte() {

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
            this.MostarReporte();
        }
    }
}
