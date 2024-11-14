namespace EJ7_Tema4_DI
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
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.cbAsignaturas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(28, 26);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cbAlumnos.TabIndex = 0;
            // 
            // cbAsignaturas
            // 
            this.cbAsignaturas.FormattingEnabled = true;
            this.cbAsignaturas.Location = new System.Drawing.Point(178, 26);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(121, 21);
            this.cbAsignaturas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbAsignaturas);
            this.Controls.Add(this.cbAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.ComboBox cbAsignaturas;
    }
}

