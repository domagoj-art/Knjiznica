﻿namespace Knjiznica
{
    partial class FormKnjiznica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAdresaKnjiznice = new System.Windows.Forms.TextBox();
            this.txtNazivKnjiznice = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(118, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtAdresaKnjiznice
            // 
            this.txtAdresaKnjiznice.Location = new System.Drawing.Point(112, 151);
            this.txtAdresaKnjiznice.Name = "txtAdresaKnjiznice";
            this.txtAdresaKnjiznice.Size = new System.Drawing.Size(118, 20);
            this.txtAdresaKnjiznice.TabIndex = 3;
            // 
            // txtNazivKnjiznice
            // 
            this.txtNazivKnjiznice.Location = new System.Drawing.Point(112, 94);
            this.txtNazivKnjiznice.Name = "txtNazivKnjiznice";
            this.txtNazivKnjiznice.Size = new System.Drawing.Size(118, 20);
            this.txtNazivKnjiznice.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(354, 92);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(635, 92);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(493, 92);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 38);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(12, 97);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(79, 13);
            this.Naziv.TabIndex = 8;
            this.Naziv.Text = "Naziv Knjižnice";
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Location = new System.Drawing.Point(12, 154);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(40, 13);
            this.Adresa.TabIndex = 9;
            this.Adresa.Text = "Adresa";
            // 
            // FormKnjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtNazivKnjiznice);
            this.Controls.Add(this.txtAdresaKnjiznice);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKnjiznica";
            this.Text = "Knjižnica";
            this.Load += new System.EventHandler(this.FormKnjiznica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAdresaKnjiznice;
        private System.Windows.Forms.TextBox txtNazivKnjiznice;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Label Adresa;
    }
}