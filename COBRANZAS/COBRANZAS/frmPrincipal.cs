using MaterialSkin;
using MaterialSkin.Controls;
using System;
using COBRANZAS.Herramientas;
using COBRANZAS.CLIENTES;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COBRANZAS
{
    public partial class frmPrincipal : MaterialForm
    {
        // Para Configurar el skin de la parte visual 
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        // Confurando el skin
        public frmPrincipal()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            tabMenuPrincipal.Dock = DockStyle.Fill;
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            objLogin.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage miTab = new TabPage();
            miTab.Text = "Registro Clientes";
            frmClientes objClientes = new frmClientes();
            objClientes.TopLevel = false;
            objClientes.Show();
            miTab.Controls.Add(objClientes);
            tabOpcionClientes.TabPages.Add(miTab);
            tabOpcionClientes.SelectedTab = miTab;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //tabOpcionClientes.Dock = DockStyle.Fill;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage miTab2 = new TabPage();
            miTab2.Text = "Consulta Clientes";
            frmConsultaClientes objConsultaClientes = new frmConsultaClientes();
            objConsultaClientes.TopLevel = false;
            objConsultaClientes.Location = new Point(0, tabSelectoCliente.Location.Y + 5);
            objConsultaClientes.Show();
            objConsultaClientes.BringToFront();
            miTab2.Controls.Add(objConsultaClientes);
            tabOpcionClientes.TabPages.Add(miTab2);
            tabOpcionClientes.SelectedTab = miTab2;
        }

        private void registrarV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage miTab = new TabPage();
            miTab.Text = "Registro Clientes 2";
            frmClientes2 objClientes = new frmClientes2();
            objClientes.TopLevel = false;
            objClientes.Location = new Point(0, tabSelectoCliente.Location.Y + 5);
            objClientes.Show();
            miTab.Controls.Add(objClientes);
            tabOpcionClientes.TabPages.Add(miTab);
            tabOpcionClientes.SelectedTab = miTab;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}