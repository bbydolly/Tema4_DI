namespace Ej6_Tema4_DI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(12, 28);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(142, 13);
            this.lblPin.TabIndex = 0;
            this.lblPin.Text = "Introduce el pin de 4 dígitos:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(160, 25);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 1;
            // 
            // btnContraseña
            // 
            this.btnContraseña.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContraseña.Location = new System.Drawing.Point(99, 76);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(75, 23);
            this.btnContraseña.TabIndex = 2;
            this.btnContraseña.Text = "Entrar";
            this.btnContraseña.UseVisualStyleBackColor = true;
           
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 129);
            this.Controls.Add(this.btnContraseña);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Introducción de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnContraseña;
        public System.Windows.Forms.TextBox txtPin;
    }
}