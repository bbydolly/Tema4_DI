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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.cbAsignaturas = new System.Windows.Forms.ComboBox();
            this.lbAlumno = new System.Windows.Forms.Label();
            this.lbMediaNotas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(28, 26);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cbAlumnos.TabIndex = 0;
            this.cbAlumnos.SelectedIndexChanged += new System.EventHandler(this.cbAlumnos_SelectedIndexChanged);
            // 
            // cbAsignaturas
            // 
            this.cbAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignaturas.FormattingEnabled = true;
            this.cbAsignaturas.Location = new System.Drawing.Point(178, 26);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(121, 21);
            this.cbAsignaturas.TabIndex = 1;
            this.cbAsignaturas.SelectedIndexChanged += new System.EventHandler(this.cbAsignaturas_SelectedIndexChanged);
            // 
            // lbAlumno
            // 
            this.lbAlumno.AutoSize = true;
            this.lbAlumno.Location = new System.Drawing.Point(578, 34);
            this.lbAlumno.Name = "lbAlumno";
            this.lbAlumno.Size = new System.Drawing.Size(0, 13);
            this.lbAlumno.TabIndex = 2;
            // 
            // lbMediaNotas
            // 
            this.lbMediaNotas.AutoSize = true;
            this.lbMediaNotas.Location = new System.Drawing.Point(578, 66);
            this.lbMediaNotas.Name = "lbMediaNotas";
            this.lbMediaNotas.Size = new System.Drawing.Size(0, 13);
            this.lbMediaNotas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMediaNotas);
            this.Controls.Add(this.lbAlumno);
            this.Controls.Add(this.cbAsignaturas);
            this.Controls.Add(this.cbAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestor de notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.ComboBox cbAsignaturas;
        private System.Windows.Forms.Label lbAlumno;
        private System.Windows.Forms.Label lbMediaNotas;
    }
}

