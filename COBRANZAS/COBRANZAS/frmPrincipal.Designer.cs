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
            this.tabSelectoCliente = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionClientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabSelectorServicios = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionServicios = new MaterialSkin.Controls.MaterialTabControl();
            this.tabServicioRegistro = new System.Windows.Forms.TabPage();
            this.tabMorisidad = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionMorosidad = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabConfiguraciones = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionConfiguraciones = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuPrincipal.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabOpcionClientes.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.tabOpcionServicios.SuspendLayout();
            this.tabMorisidad.SuspendLayout();
            this.tabOpcionMorosidad.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.tabOpcionConfiguraciones.SuspendLayout();
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
            this.tabMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenuPrincipal.ImageList = this.listaImagenes;
            this.tabMenuPrincipal.Location = new System.Drawing.Point(3, 88);
            this.tabMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenuPrincipal.Multiline = true;
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.SelectedIndex = 0;
            this.tabMenuPrincipal.Size = new System.Drawing.Size(1190, 579);
            this.tabMenuPrincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabSelectoCliente);
            this.tabClientes.Controls.Add(this.tabOpcionClientes);
            this.tabClientes.ImageKey = "User.png";
            this.tabClientes.Location = new System.Drawing.Point(4, 23);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1182, 552);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabSelectoCliente
            // 
            this.tabSelectoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectoCliente.BaseTabControl = this.tabOpcionClientes;
            this.tabSelectoCliente.Depth = 0;
            this.tabSelectoCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectoCliente.Location = new System.Drawing.Point(30, 10);
            this.tabSelectoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectoCliente.Name = "tabSelectoCliente";
            this.tabSelectoCliente.Size = new System.Drawing.Size(1098, 35);
            this.tabSelectoCliente.TabIndex = 1;
            this.tabSelectoCliente.Text = "materialTabSelector3";
            // 
            // tabOpcionClientes
            // 
            this.tabOpcionClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionClientes.Controls.Add(this.tabPage1);
            this.tabOpcionClientes.Depth = 0;
            this.tabOpcionClientes.Location = new System.Drawing.Point(30, 49);
            this.tabOpcionClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionClientes.Multiline = true;
            this.tabOpcionClientes.Name = "tabOpcionClientes";
            this.tabOpcionClientes.SelectedIndex = 0;
            this.tabOpcionClientes.Size = new System.Drawing.Size(1102, 451);
            this.tabOpcionClientes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1094, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            // 
            // tabServicios
            // 
            this.tabServicios.Controls.Add(this.tabSelectorServicios);
            this.tabServicios.Controls.Add(this.tabOpcionServicios);
            this.tabServicios.ImageKey = "services.png";
            this.tabServicios.Location = new System.Drawing.Point(4, 23);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(1182, 552);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabSelectorServicios
            // 
            this.tabSelectorServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorServicios.BaseTabControl = this.tabOpcionServicios;
            this.tabSelectorServicios.Depth = 0;
            this.tabSelectorServicios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorServicios.Location = new System.Drawing.Point(1, 4);
            this.tabSelectorServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorServicios.Name = "tabSelectorServicios";
            this.tabSelectorServicios.Size = new System.Drawing.Size(1181, 48);
            this.tabSelectorServicios.TabIndex = 3;
            this.tabSelectorServicios.Text = "materialTabSelector1";
            // 
            // tabOpcionServicios
            // 
            this.tabOpcionServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionServicios.Controls.Add(this.tabServicioRegistro);
            this.tabOpcionServicios.Depth = 0;
            this.tabOpcionServicios.Location = new System.Drawing.Point(113, 134);
            this.tabOpcionServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionServicios.Multiline = true;
            this.tabOpcionServicios.Name = "tabOpcionServicios";
            this.tabOpcionServicios.SelectedIndex = 0;
            this.tabOpcionServicios.Size = new System.Drawing.Size(785, 317);
            this.tabOpcionServicios.TabIndex = 2;
            // 
            // tabServicioRegistro
            // 
            this.tabServicioRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabServicioRegistro.Name = "tabServicioRegistro";
            this.tabServicioRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicioRegistro.Size = new System.Drawing.Size(777, 291);
            this.tabServicioRegistro.TabIndex = 0;
            this.tabServicioRegistro.Text = "Inicio";
            this.tabServicioRegistro.UseVisualStyleBackColor = true;
            // 
            // tabMorisidad
            // 
            this.tabMorisidad.Controls.Add(this.materialTabSelector1);
            this.tabMorisidad.Controls.Add(this.tabOpcionMorosidad);
            this.tabMorisidad.ImageKey = "Monitor.png";
            this.tabMorisidad.Location = new System.Drawing.Point(4, 23);
            this.tabMorisidad.Name = "tabMorisidad";
            this.tabMorisidad.Size = new System.Drawing.Size(1182, 552);
            this.tabMorisidad.TabIndex = 2;
            this.tabMorisidad.Text = "Morosidad";
            this.tabMorisidad.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabOpcionMorosidad;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(1, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1181, 48);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabOpcionMorosidad
            // 
            this.tabOpcionMorosidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionMorosidad.Controls.Add(this.tabPage2);
            this.tabOpcionMorosidad.Depth = 0;
            this.tabOpcionMorosidad.Location = new System.Drawing.Point(132, 141);
            this.tabOpcionMorosidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionMorosidad.Multiline = true;
            this.tabOpcionMorosidad.Name = "tabOpcionMorosidad";
            this.tabOpcionMorosidad.SelectedIndex = 0;
            this.tabOpcionMorosidad.Size = new System.Drawing.Size(847, 341);
            this.tabOpcionMorosidad.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(839, 315);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Inicio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.materialTabSelector2);
            this.tabConfiguraciones.Controls.Add(this.tabOpcionConfiguraciones);
            this.tabConfiguraciones.ImageKey = "config.png";
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 23);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.Size = new System.Drawing.Size(1182, 552);
            this.tabConfiguraciones.TabIndex = 3;
            this.tabConfiguraciones.Text = "Configuraciones";
            this.tabConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.tabOpcionConfiguraciones;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(1, 4);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1181, 48);
            this.materialTabSelector2.TabIndex = 7;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // tabOpcionConfiguraciones
            // 
            this.tabOpcionConfiguraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionConfiguraciones.Controls.Add(this.tabPage3);
            this.tabOpcionConfiguraciones.Depth = 0;
            this.tabOpcionConfiguraciones.ImageList = this.listaImagenes;
            this.tabOpcionConfiguraciones.Location = new System.Drawing.Point(101, 125);
            this.tabOpcionConfiguraciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionConfiguraciones.Multiline = true;
            this.tabOpcionConfiguraciones.Name = "tabOpcionConfiguraciones";
            this.tabOpcionConfiguraciones.SelectedIndex = 0;
            this.tabOpcionConfiguraciones.Size = new System.Drawing.Size(917, 342);
            this.tabOpcionConfiguraciones.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(909, 315);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Inicio";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.menuConfiguracion,
            this.temaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1190, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.registrarV2ToolStripMenuItem});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(61, 20);
            this.menuClientes.Text = "Clientes";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // registrarV2ToolStripMenuItem
            // 
            this.registrarV2ToolStripMenuItem.Name = "registrarV2ToolStripMenuItem";
            this.registrarV2ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.registrarV2ToolStripMenuItem.Text = "Registrar v2";
            this.registrarV2ToolStripMenuItem.Click += new System.EventHandler(this.registrarV2ToolStripMenuItem_Click);
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
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.oscuroToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Claro";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // oscuroToolStripMenuItem
            // 
            this.oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            this.oscuroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oscuroToolStripMenuItem.Text = "Oscuro";
            this.oscuroToolStripMenuItem.Click += new System.EventHandler(this.oscuroToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 670);
            this.Controls.Add(this.tabMenuPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabMenuPrincipal;
            this.DrawerUseColors = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cobranzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabMenuPrincipal.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabOpcionClientes.ResumeLayout(false);
            this.tabServicios.ResumeLayout(false);
            this.tabOpcionServicios.ResumeLayout(false);
            this.tabMorisidad.ResumeLayout(false);
            this.tabOpcionMorosidad.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabOpcionConfiguraciones.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialTabControl tabOpcionClientes;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorServicios;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionServicios;
        private System.Windows.Forms.TabPage tabServicioRegistro;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionMorosidad;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionConfiguraciones;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectoCliente;
        private System.Windows.Forms.ToolStripMenuItem registrarV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscuroToolStripMenuItem;
    }
}