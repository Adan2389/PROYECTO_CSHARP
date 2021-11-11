
namespace COBRANZAS.Clases
{
    partial class frmRed
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstagregar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "crear Objetos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstagregar
            // 
            this.lstagregar.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstagregar.ForeColor = System.Drawing.Color.Lime;
            this.lstagregar.FormattingEnabled = true;
            this.lstagregar.ItemHeight = 24;
            this.lstagregar.Location = new System.Drawing.Point(381, 35);
            this.lstagregar.Name = "lstagregar";
            this.lstagregar.Size = new System.Drawing.Size(873, 580);
            this.lstagregar.TabIndex = 1;
            // 
            // frmRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 677);
            this.Controls.Add(this.lstagregar);
            this.Controls.Add(this.button1);
            this.Name = "frmRed";
            this.Text = "frmRed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstagregar;
    }
}