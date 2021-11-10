using System;
using COBRANZAS.Red;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS.Herramientas
{
    public partial class frmLogin : Form
    {

        private String Usuario;
        private int Rol;
        private TImpresora objImpresoraMultfuncional = new TImpresora("EPSON", "L3100");
        private TImpresora objImpreosaNormal = new TImpresora("CANON", "MP250");


        public frmLogin()
        {
            InitializeComponent();
        }

        public void Cargar(String Us, int Rol) {
            this.Usuario = Us;
            this.Rol = Rol;
        }

        private Boolean IniciarSesion() {

            return true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Cargar("Sistema", 1);
            this.asigarDatos();
           
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiciste Click");
            this.Usuario = "Cambiado";
            this.Rol = -1;
            this.asigarDatos();

        }

        private void asigarDatos() {
            txtUsuario.Text = this.Usuario;
            txtRol.Text = this.Rol.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objImpresoraMultfuncional.Encender();
            objImpresoraMultfuncional.ConectarRed("192.168.5.23");
            txtInfo.Text = this.objImpresoraMultfuncional.Get_info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objImpreosaNormal.Encender();
            objImpreosaNormal.ConectarRed("192.168.5.24");
            txtInfo2.Text = this.objImpreosaNormal.Get_info();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objImpresoraMultfuncional.Imprimir(50);
            txtInfo.Text =  objImpresoraMultfuncional.Get_info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objImpreosaNormal.Imprimir(100);
            txtInfo2.Text = objImpreosaNormal.Get_info();
        }
    }
}
