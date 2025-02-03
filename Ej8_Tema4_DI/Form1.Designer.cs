namespace Ej8_Tema4_DI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAvance = new System.Windows.Forms.Button();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblInformativa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDatosImage = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 86);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anteriorToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Enabled = false;
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Enabled = false;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // btnAvance
            // 
            this.btnAvance.Location = new System.Drawing.Point(93, 12);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(75, 23);
            this.btnAvance.TabIndex = 2;
            this.btnAvance.Text = "Avance";
            this.toolTip1.SetToolTip(this.btnAvance, "Flecha de la derecha (-->)");
            this.btnAvance.UseVisualStyleBackColor = true;
            this.btnAvance.Click += new System.EventHandler(this.btnAvance_Click);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Location = new System.Drawing.Point(174, 12);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(75, 23);
            this.btnRetroceso.TabIndex = 3;
            this.btnRetroceso.Text = "Retroceso";
            this.toolTip1.SetToolTip(this.btnRetroceso, "Tecla flecha izquierda (<--)");
            this.btnRetroceso.UseVisualStyleBackColor = true;
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // lblInformativa
            // 
            this.lblInformativa.AutoSize = true;
            this.lblInformativa.Location = new System.Drawing.Point(197, 51);
            this.lblInformativa.Name = "lblInformativa";
            this.lblInformativa.Size = new System.Drawing.Size(0, 13);
            this.lblInformativa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 51);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(70, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "InfoDirectorio";
            // 
            // lblDatosImage
            // 
            this.lblDatosImage.AutoSize = true;
            this.lblDatosImage.Location = new System.Drawing.Point(12, 73);
            this.lblDatosImage.Name = "lblDatosImage";
            this.lblDatosImage.Size = new System.Drawing.Size(61, 13);
            this.lblDatosImage.TabIndex = 7;
            this.lblDatosImage.Text = "InfoArchivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 280);
            this.Controls.Add(this.lblDatosImage);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInformativa);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.btnAvance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAvance;
        private System.Windows.Forms.Button btnRetroceso;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInformativa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblDatosImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblInfo;
    }
}

