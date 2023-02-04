namespace Knjiznica
{
    partial class FormPosudbe
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbZaposlenikID = new System.Windows.Forms.ComboBox();
            this.cbClanID = new System.Windows.Forms.ComboBox();
            this.cbKnjigaID = new System.Windows.Forms.ComboBox();
            this.bsKnjige = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.datumVracanja = new System.Windows.Forms.DateTimePicker();
            this.datumPreuzimanja = new System.Windows.Forms.DateTimePicker();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // cbZaposlenikID
            // 
            this.cbZaposlenikID.FormattingEnabled = true;
            this.cbZaposlenikID.Location = new System.Drawing.Point(114, 138);
            this.cbZaposlenikID.Name = "cbZaposlenikID";
            this.cbZaposlenikID.Size = new System.Drawing.Size(121, 21);
            this.cbZaposlenikID.TabIndex = 4;
            // 
            // cbClanID
            // 
            this.cbClanID.FormattingEnabled = true;
            this.cbClanID.Location = new System.Drawing.Point(114, 98);
            this.cbClanID.Name = "cbClanID";
            this.cbClanID.Size = new System.Drawing.Size(121, 21);
            this.cbClanID.TabIndex = 3;
            // 
            // cbKnjigaID
            // 
            this.cbKnjigaID.DataSource = this.bsKnjige;
            this.cbKnjigaID.DisplayMember = "ID";
            this.cbKnjigaID.FormattingEnabled = true;
            this.cbKnjigaID.Location = new System.Drawing.Point(114, 57);
            this.cbKnjigaID.Name = "cbKnjigaID";
            this.cbKnjigaID.Size = new System.Drawing.Size(121, 21);
            this.cbKnjigaID.TabIndex = 2;
            // 
            // bsKnjige
            // 
            this.bsKnjige.DataMember = "Knjiga";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Location = new System.Drawing.Point(114, 16);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datum Vraćanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum Preuzimanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zaposlenik ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Član ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Knjiga ID";
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Location = new System.Drawing.Point(652, 78);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Location = new System.Drawing.Point(652, 136);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Očisti";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Location = new System.Drawing.Point(652, 165);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Obriši";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(616, 16);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(111, 20);
            this.txtPretrazivanje.TabIndex = 11;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Traži po nazivu knjige, imenu ili prezimenu člana knjižnice ";
            // 
            // datumVracanja
            // 
            this.datumVracanja.Location = new System.Drawing.Point(114, 228);
            this.datumVracanja.Name = "datumVracanja";
            this.datumVracanja.Size = new System.Drawing.Size(200, 20);
            this.datumVracanja.TabIndex = 6;
            // 
            // datumPreuzimanja
            // 
            this.datumPreuzimanja.Location = new System.Drawing.Point(114, 185);
            this.datumPreuzimanja.Name = "datumPreuzimanja";
            this.datumPreuzimanja.Size = new System.Drawing.Size(200, 20);
            this.datumPreuzimanja.TabIndex = 5;
            // 
            // Update
            // 
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.Location = new System.Drawing.Point(652, 107);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 8;
            this.Update.Text = "Ažuriraj";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // FormPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.datumPreuzimanja);
            this.Controls.Add(this.datumVracanja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbKnjigaID);
            this.Controls.Add(this.cbClanID);
            this.Controls.Add(this.cbZaposlenikID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPosudbe";
            this.Text = "Posudba";
            this.Load += new System.EventHandler(this.FormPosudbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbZaposlenikID;
        private System.Windows.Forms.ComboBox cbClanID;
        private System.Windows.Forms.ComboBox cbKnjigaID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear;
        
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bsKnjige;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.DateTimePicker datumVracanja;
        private System.Windows.Forms.DateTimePicker datumPreuzimanja;
        private System.Windows.Forms.Button Update;
    }
}