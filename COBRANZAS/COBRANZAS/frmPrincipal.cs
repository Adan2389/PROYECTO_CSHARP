﻿using MaterialSkin;
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
        public frmPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            objLogin.ShowDialog();
                       
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            frmClientes objClientes = new frmClientes();
            objClientes.FormBorderStyle = FormBorderStyle.None;
            tabOpcionClientes.SelectTab(1);
            objClientes.Show();
        }
    }
}