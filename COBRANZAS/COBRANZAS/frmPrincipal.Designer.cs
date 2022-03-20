
namespace COBRANZAS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabMorisidad = new System.Windows.Forms.TabPage();
            this.tabConfiguraciones = new System.Windows.Forms.TabPage();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMorosidad = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDeMoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.Controls.Add(this.tabClientes);
            this.tabMenuPrincipal.Controls.Add(this.tabServicios);
            this.tabMenuPrincipal.Controls.Add(this.tabMorisidad);
            this.tabMenuPrincipal.Controls.Add(this.tabConfiguraciones);
            this.tabMenuPrincipal.Depth = 0;
            this.tabMenuPrincipal.ImageList = this.listaImagenes;
            this.tabMenuPrincipal.Location = new System.Drawing.Point(57, 122);
            this.tabMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenuPrincipal.Multiline = true;
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.SelectedIndex = 0;
            this.tabMenuPrincipal.Size = new System.Drawing.Size(1080, 466);
            this.tabMenuPrincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.ImageKey = "User.png";
            this.tabClientes.Location = new System.Drawing.Point(4, 23);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1072, 439);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabServicios
            // 
            this.tabServicios.ImageKey = "services.png";
            this.tabServicios.Location = new System.Drawing.Point(4, 23);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(1072, 439);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabMorisidad
            // 
            this.tabMorisidad.ImageKey = "Monitor.png";
            this.tabMorisidad.Location = new System.Drawing.Point(4, 23);
            this.tabMorisidad.Name = "tabMorisidad";
            this.tabMorisidad.Size = new System.Drawing.Size(1072, 439);
            this.tabMorisidad.TabIndex = 2;
            this.tabMorisidad.Text = "Morosidad";
            this.tabMorisidad.UseVisualStyleBackColor = true;
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.ImageKey = "config.png";
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 23);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.Size = new System.Drawing.Size(1072, 439);
            this.tabConfiguraciones.TabIndex = 3;
            this.tabConfiguraciones.Text = "Configuraciones";
            this.tabConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "config.png");
            this.listaImagenes.Images.SetKeyName(1, "mora.png");
            this.listaImagenes.Images.SetKeyName(2, "services.png");
            this.listaImagenes.Images.SetKeyName(3, "User.png");
            this.listaImagenes.Images.SetKeyName(4, "Monitor.png");
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuServicios,
            this.menuMorosidad,
            this.menuConfiguracion});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 64);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1193, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(61, 20);
            this.menuClientes.Text = "Clientes";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // menuServicios
            // 
            this.menuServicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1,
            this.consultaToolStripMenuItem1,
            this.preciosToolStripMenuItem});
            this.menuServicios.Name = "menuServicios";
            this.menuServicios.Size = new System.Drawing.Size(65, 20);
            this.menuServicios.Text = "Servicios";
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.registroToolStripMenuItem1.Text = "Registro";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.preciosToolStripMenuItem.Text = "Precios";
            // 
            // menuMorosidad
            // 
            this.menuMorosidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasDeMoraToolStripMenuItem,
            this.planesDePagoToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.menuMorosidad.Name = "menuMorosidad";
            this.menuMorosidad.Size = new System.Drawing.Size(76, 20);
            this.menuMorosidad.Text = "Morosidad";
            // 
            // listasDeMoraToolStripMenuItem
            // 
            this.listasDeMoraToolStripMenuItem.Name = "listasDeMoraToolStripMenuItem";
            this.listasDeMoraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listasDeMoraToolStripMenuItem.Text = "Listas de Mora";
            // 
            // planesDePagoToolStripMenuItem
            // 
            this.planesDePagoToolStripMenuItem.Name = "planesDePagoToolStripMenuItem";
            this.planesDePagoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.planesDePagoToolStripMenuItem.Text = "Planes de Pago";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.accesosToolStripMenuItem,
            this.moduloToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(106, 20);
            this.menuConfiguracion.Text = "Configuraciones";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // accesosToolStripMenuItem
            // 
            this.accesosToolStripMenuItem.Name = "accesosToolStripMenuItem";
            this.accesosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.accesosToolStripMenuItem.Text = "Accesos";
            // 
            // moduloToolStripMenuItem
            // 
            this.moduloToolStripMenuItem.Name = "moduloToolStripMenuItem";
            this.moduloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.moduloToolStripMenuItem.Text = "Modulo";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1196, 670);
            this.Controls.Add(this.tabMenuPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.DrawerIndicatorWidth = 5;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabMenuPrincipal;
            this.DrawerUseColors = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cobranzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMenuPrincipal.ResumeLayout(false);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabMenuPrincipal;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.TabPage tabMorisidad;
        private System.Windows.Forms.TabPage tabConfiguraciones;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuServicios;
        private System.Windows.Forms.ToolStripMenuItem menuMorosidad;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasDeMoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
    }
}

