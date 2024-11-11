namespace Ej5_Tema4_DI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAbhadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasarDerecha = new System.Windows.Forms.Button();
            this.btnTraspasarIzquierda = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lbElementos = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lbIndex = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(206, 381);
            this.listBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBox1, "Representa una lista de elementos que se han añadido a la colección.");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(255, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(226, 381);
            this.listBox2.TabIndex = 1;
            // 
            // btnAbhadir
            // 
            this.btnAbhadir.Location = new System.Drawing.Point(516, 152);
            this.btnAbhadir.Name = "btnAbhadir";
            this.btnAbhadir.Size = new System.Drawing.Size(110, 23);
            this.btnAbhadir.TabIndex = 2;
            this.btnAbhadir.Text = "Añadir";
            this.toolTip4.SetToolTip(this.btnAbhadir, "Botón que añade el texto que haya en el textBoz a la lista uno.");
            this.btnAbhadir.UseVisualStyleBackColor = true;
            this.btnAbhadir.Click += new System.EventHandler(this.btnAbhadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(516, 199);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(110, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.toolTip5.SetToolTip(this.btnQuitar, "Botón que elimina un item seleccionado de la lista uno(la de la izquierda).Si no " +
        "hay ningún elemento seleccionado no elimina nada.");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTraspasarDerecha
            // 
            this.btnTraspasarDerecha.Location = new System.Drawing.Point(516, 248);
            this.btnTraspasarDerecha.Name = "btnTraspasarDerecha";
            this.btnTraspasarDerecha.Size = new System.Drawing.Size(110, 23);
            this.btnTraspasarDerecha.TabIndex = 4;
            this.btnTraspasarDerecha.Text = "Traspasar  (-->)";
            this.toolTip6.SetToolTip(this.btnTraspasarDerecha, "Si hay un elemento seleccionado en la primera listBox(la de la izquierda) y tras " +
        "pulsarlo, se elimina ese elemento de la lista uno y lo traspasa a la lista 2.");
            this.btnTraspasarDerecha.UseVisualStyleBackColor = true;
            this.btnTraspasarDerecha.Click += new System.EventHandler(this.btnTraspasarDerecha_Click);
            // 
            // btnTraspasarIzquierda
            // 
            this.btnTraspasarIzquierda.Location = new System.Drawing.Point(516, 300);
            this.btnTraspasarIzquierda.Name = "btnTraspasarIzquierda";
            this.btnTraspasarIzquierda.Size = new System.Drawing.Size(110, 23);
            this.btnTraspasarIzquierda.TabIndex = 5;
            this.btnTraspasarIzquierda.Text = "Traspasar    (<--)";
            this.toolTip7.SetToolTip(this.btnTraspasarIzquierda, "Si hay un elemento seleccionado en la lista 2 lo borra de la lista 2 y lo escribe" +
        " en la lista 1. Hace un traspaso.");
            this.btnTraspasarIzquierda.UseVisualStyleBackColor = true;
            this.btnTraspasarIzquierda.Click += new System.EventHandler(this.btnTraspasarIzquierda_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(516, 40);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(40, 13);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Texto: ";
            // 
            // lbElementos
            // 
            this.lbElementos.AutoSize = true;
            this.lbElementos.Location = new System.Drawing.Point(516, 71);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(148, 13);
            this.lbElementos.TabIndex = 7;
            this.lbElementos.Text = "Elementos en la lista principal:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(557, 37);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(231, 20);
            this.txtDato.TabIndex = 8;
            this.toolTip3.SetToolTip(this.txtDato, "TextBox para escribir lo que se añadirá a la colección de la izquierda. Funciona " +
        "dándole a enter tras escribir o dándole a añadir. ");
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(516, 108);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(115, 13);
            this.lbIndex.TabIndex = 9;
            this.lbIndex.Text = "Índices seleccionados:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip2
            // 
          
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAbhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lbElementos);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnTraspasarIzquierda);
            this.Controls.Add(this.btnTraspasarDerecha);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAbhadir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAbhadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasarDerecha;
        private System.Windows.Forms.Button btnTraspasarIzquierda;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lbElementos;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
    }
}

