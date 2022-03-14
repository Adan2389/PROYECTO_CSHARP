
namespace COBRANZAS.CLIENTES
{
    partial class frmClientes
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.lblModificadoPor = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaModif = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.lblCreadoPor = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreadoEl = new MaterialSkin.Controls.MaterialLabel();
            this.txtMunicipio = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdentidad = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.DSFSDFDS = new MaterialSkin.Controls.MaterialLabel();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton4);
            this.materialCard1.Controls.Add(this.lblModificadoPor);
            this.materialCard1.Controls.Add(this.lblFechaModif);
            this.materialCard1.Controls.Add(this.materialButton3);
            this.materialCard1.Controls.Add(this.lblCreadoPor);
            this.materialCard1.Controls.Add(this.lblCreadoEl);
            this.materialCard1.Controls.Add(this.txtMunicipio);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.txtDireccion);
            this.materialCard1.Controls.Add(this.txtTelefono);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.dtpFechaNac);
            this.materialCard1.Controls.Add(this.txtCorreo);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txtIdentidad);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtNombre);
            this.materialCard1.Controls.Add(this.DSFSDFDS);
            this.materialCard1.Controls.Add(this.txtId);
            this.materialCard1.Controls.Add(this.dgvClientes);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 95);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1363, 575);
            this.materialCard1.TabIndex = 0;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(448, 442);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(78, 36);
            this.materialButton4.TabIndex = 25;
            this.materialButton4.Text = "Anular";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // lblModificadoPor
            // 
            this.lblModificadoPor.AutoSize = true;
            this.lblModificadoPor.Depth = 0;
            this.lblModificadoPor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModificadoPor.ForeColor = System.Drawing.Color.DarkGray;
            this.lblModificadoPor.Location = new System.Drawing.Point(859, 538);
            this.lblModificadoPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModificadoPor.Name = "lblModificadoPor";
            this.lblModificadoPor.Size = new System.Drawing.Size(113, 19);
            this.lblModificadoPor.TabIndex = 24;
            this.lblModificadoPor.Text = "Modificado por:";
            // 
            // lblFechaModif
            // 
            this.lblFechaModif.AutoSize = true;
            this.lblFechaModif.Depth = 0;
            this.lblFechaModif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaModif.ForeColor = System.Drawing.Color.LightGray;
            this.lblFechaModif.Location = new System.Drawing.Point(560, 538);
            this.lblFechaModif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaModif.Name = "lblFechaModif";
            this.lblFechaModif.Size = new System.Drawing.Size(141, 19);
            this.lblFechaModif.TabIndex = 23;
            this.lblFechaModif.Text = "Fecha Modificacion";
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(355, 442);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(79, 36);
            this.materialButton3.TabIndex = 22;
            this.materialButton3.Text = "Limpiar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // lblCreadoPor
            // 
            this.lblCreadoPor.AutoSize = true;
            this.lblCreadoPor.Depth = 0;
            this.lblCreadoPor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreadoPor.ForeColor = System.Drawing.Color.LightGray;
            this.lblCreadoPor.Location = new System.Drawing.Point(278, 528);
            this.lblCreadoPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreadoPor.Name = "lblCreadoPor";
            this.lblCreadoPor.Size = new System.Drawing.Size(82, 19);
            this.lblCreadoPor.TabIndex = 21;
            this.lblCreadoPor.Text = "Creado por:";
            // 
            // lblCreadoEl
            // 
            this.lblCreadoEl.AutoSize = true;
            this.lblCreadoEl.Depth = 0;
            this.lblCreadoEl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreadoEl.ForeColor = System.Drawing.Color.LightGray;
            this.lblCreadoEl.Location = new System.Drawing.Point(27, 528);
            this.lblCreadoEl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreadoEl.Name = "lblCreadoEl";
            this.lblCreadoEl.Size = new System.Drawing.Size(71, 19);
            this.lblCreadoEl.TabIndex = 20;
            this.lblCreadoEl.Text = "Creado el:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMunicipio.Depth = 0;
            this.txtMunicipio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMunicipio.LeadingIcon = null;
            this.txtMunicipio.Location = new System.Drawing.Point(113, 379);
            this.txtMunicipio.MaxLength = 50;
            this.txtMunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMunicipio.Multiline = false;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(428, 50);
            this.txtMunicipio.TabIndex = 14;
            this.txtMunicipio.Text = "";
            this.txtMunicipio.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(27, 396);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Municipio";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(27, 214);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 19);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(113, 199);
            this.txtDireccion.MaxLength = 500;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(428, 50);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(113, 317);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(428, 50);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(27, 334);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Telefono";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(259, 442);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(88, 36);
            this.materialButton2.TabIndex = 17;
            this.materialButton2.Text = "Guardar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(27, 449);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(80, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Fecha Nac.";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpFechaNac.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(113, 449);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(131, 29);
            this.dtpFechaNac.TabIndex = 16;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(113, 255);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(428, 50);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(27, 270);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Correo";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidad.Depth = 0;
            this.txtIdentidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentidad.LeadingIcon = null;
            this.txtIdentidad.Location = new System.Drawing.Point(113, 82);
            this.txtIdentidad.MaxLength = 13;
            this.txtIdentidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentidad.Multiline = false;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(428, 50);
            this.txtIdentidad.TabIndex = 4;
            this.txtIdentidad.Text = "";
            this.txtIdentidad.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 93);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Identidad";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(113, 138);
            this.txtNombre.MaxLength = 350;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(428, 50);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // DSFSDFDS
            // 
            this.DSFSDFDS.AutoSize = true;
            this.DSFSDFDS.Depth = 0;
            this.DSFSDFDS.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DSFSDFDS.Location = new System.Drawing.Point(27, 150);
            this.DSFSDFDS.MouseState = MaterialSkin.MouseState.HOVER;
            this.DSFSDFDS.Name = "DSFSDFDS";
            this.DSFSDFDS.Size = new System.Drawing.Size(57, 19);
            this.DSFSDFDS.TabIndex = 5;
            this.DSFSDFDS.Text = "Nombre";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(113, 26);
            this.txtId.MaxLength = 50;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 50);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Identidad,
            this.Col_Nombre,
            this.Col_Correo,
            this.Col_Telefono,
            this.Col_Direccion,
            this.Col_Municipio,
            this.Col_Fecha_Nacimiento,
            this.Col_Usuario,
            this.Col_Activo});
            this.dgvClientes.Location = new System.Drawing.Point(581, 63);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(765, 439);
            this.dgvClientes.TabIndex = 19;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // Col_Id
            // 
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Width = 50;
            // 
            // Col_Identidad
            // 
            this.Col_Identidad.HeaderText = "Identidad";
            this.Col_Identidad.Name = "Col_Identidad";
            this.Col_Identidad.ReadOnly = true;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.HeaderText = "Nombre";
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            this.Col_Nombre.Width = 200;
            // 
            // Col_Correo
            // 
            this.Col_Correo.HeaderText = "Correo";
            this.Col_Correo.Name = "Col_Correo";
            this.Col_Correo.ReadOnly = true;
            this.Col_Correo.Width = 150;
            // 
            // Col_Telefono
            // 
            this.Col_Telefono.HeaderText = "Telefono";
            this.Col_Telefono.Name = "Col_Telefono";
            this.Col_Telefono.ReadOnly = true;
            this.Col_Telefono.Width = 80;
            // 
            // Col_Direccion
            // 
            this.Col_Direccion.HeaderText = "Direccion";
            this.Col_Direccion.Name = "Col_Direccion";
            this.Col_Direccion.ReadOnly = true;
            this.Col_Direccion.Width = 200;
            // 
            // Col_Municipio
            // 
            this.Col_Municipio.HeaderText = "Municipio";
            this.Col_Municipio.Name = "Col_Municipio";
            this.Col_Municipio.ReadOnly = true;
            // 
            // Col_Fecha_Nacimiento
            // 
            this.Col_Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.Col_Fecha_Nacimiento.Name = "Col_Fecha_Nacimiento";
            this.Col_Fecha_Nacimiento.ReadOnly = true;
            this.Col_Fecha_Nacimiento.Width = 80;
            // 
            // Col_Usuario
            // 
            this.Col_Usuario.HeaderText = "Usuario";
            this.Col_Usuario.Name = "Col_Usuario";
            this.Col_Usuario.ReadOnly = true;
            // 
            // Col_Activo
            // 
            this.Col_Activo.HeaderText = "Activo";
            this.Col_Activo.Name = "Col_Activo";
            this.Col_Activo.ReadOnly = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(27, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cliente ID";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(270, 30);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Buscar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 706);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel DSFSDFDS;
        private MaterialSkin.Controls.MaterialTextBox txtIdentidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox txtMunicipio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblCreadoPor;
        private MaterialSkin.Controls.MaterialLabel lblCreadoEl;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel lblModificadoPor;
        private MaterialSkin.Controls.MaterialLabel lblFechaModif;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Activo;
    }
}