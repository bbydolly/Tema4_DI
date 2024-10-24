using System.Drawing;

namespace Ej2_Tema4_DI
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInformativa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(671, 61);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.MouseEnterBotones);
            this.btnSalir.MouseLeave += new System.EventHandler(this.MouseLeaveBotones);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(52, 58);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 1;
            this.txtR.MouseEnter += new System.EventHandler(this.CambioDeFoco);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(196, 58);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 2;
            this.txtG.MouseEnter += new System.EventHandler(this.CambioDeFoco);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(345, 58);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            this.txtB.MouseEnter += new System.EventHandler(this.CambioDeFoco);
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Location = new System.Drawing.Point(479, 58);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(142, 23);
            this.btnCambiarColor.TabIndex = 4;
            this.btnCambiarColor.Text = "Cambiar color del fondo";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            this.btnCambiarColor.MouseEnter += new System.EventHandler(this.MouseEnterBotones);
            this.btnCambiarColor.MouseLeave += new System.EventHandler(this.MouseLeaveBotones);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B:";
            // 
            // lblInformativa
            // 
            this.lblInformativa.AutoSize = true;
            this.lblInformativa.Location = new System.Drawing.Point(49, 9);
            this.lblInformativa.Name = "lblInformativa";
            this.lblInformativa.Size = new System.Drawing.Size(351, 13);
            this.lblInformativa.TabIndex = 0;
            this.lblInformativa.Text = "Introduce en cada textbox números entre 0-255 ,corresponden a colroes.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ruta imagen:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(117, 146);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(504, 20);
            this.txtPath.TabIndex = 9;
            this.txtPath.MouseEnter += new System.EventHandler(this.CambioDeFoco);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(644, 144);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(144, 23);
            this.btnImagen.TabIndex = 10;
            this.btnImagen.Text = "Poner imagen de fondo";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            this.btnImagen.MouseEnter += new System.EventHandler(this.MouseEnterBotones);
            this.btnImagen.MouseLeave += new System.EventHandler(this.MouseLeaveBotones);
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(28, 220);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(46, 13);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "lblImage";
            this.lblImage.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(370, 321);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.MouseEnterBotones);
            this.btnReset.MouseLeave += new System.EventHandler(this.MouseLeaveBotones);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCambiarColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInformativa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambio de color de fondo del formulario.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInformativa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnReset;
    }
}

