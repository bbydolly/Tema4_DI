namespace Ej3_Tema4_DI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNuevaImagen = new System.Windows.Forms.Button();
            this.cbModal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnNuevaImagen
            // 
            this.btnNuevaImagen.Location = new System.Drawing.Point(49, 39);
            this.btnNuevaImagen.Name = "btnNuevaImagen";
            this.btnNuevaImagen.Size = new System.Drawing.Size(103, 23);
            this.btnNuevaImagen.TabIndex = 0;
            this.btnNuevaImagen.Text = "Nueva Imagen";
            this.btnNuevaImagen.UseVisualStyleBackColor = true;
            this.btnNuevaImagen.Click += new System.EventHandler(this.btnNuevaImagen_Click);
            // 
            // cbModal
            // 
            this.cbModal.AutoSize = true;
            this.cbModal.Location = new System.Drawing.Point(198, 43);
            this.cbModal.Name = "cbModal";
            this.cbModal.Size = new System.Drawing.Size(55, 17);
            this.cbModal.TabIndex = 1;
            this.cbModal.Text = "Modal";
            this.cbModal.UseVisualStyleBackColor = true;
            this.cbModal.CheckedChanged += new System.EventHandler(this.cbModal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbModal);
            this.Controls.Add(this.btnNuevaImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaImagen;
        private System.Windows.Forms.CheckBox cbModal;
    }
}

