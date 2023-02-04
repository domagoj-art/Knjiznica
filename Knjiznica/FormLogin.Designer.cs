namespace Knjiznica
{
    partial class FormLogin
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
            this.Prijava = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Prijava
            // 
            this.Prijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prijava.Location = new System.Drawing.Point(127, 73);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(75, 23);
            this.Prijava.TabIndex = 3;
            this.Prijava.Text = "Prijava";
            this.Prijava.UseVisualStyleBackColor = true;
            this.Prijava.Click += new System.EventHandler(this.Prijava_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(34, 24);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(108, 47);
            this.txtSifra.Mask = "9999999999";
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(140, 20);
            this.txtSifra.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 123);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Prijava);
            this.Name = "FormLogin";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prijava;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtSifra;
    }
}