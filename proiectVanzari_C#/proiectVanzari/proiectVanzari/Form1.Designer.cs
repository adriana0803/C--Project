namespace proiectVanzari
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCantitate = new System.Windows.Forms.ComboBox();
            this.cbOptiuni = new System.Windows.Forms.ComboBox();
            this.btAdauga = new System.Windows.Forms.Button();
            this.btFinal = new System.Windows.Forms.Button();
            this.btViewHistory = new System.Windows.Forms.Button();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btStergere = new System.Windows.Forms.Button();
            this.btIesire = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comanda";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalii Client";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenume:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail: ";
            // 
            // tbNume
            // 
            this.tbNume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNume.BackColor = System.Drawing.Color.White;
            this.tbNume.Location = new System.Drawing.Point(106, 106);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(186, 22);
            this.tbNume.TabIndex = 6;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTelefon.Location = new System.Drawing.Point(106, 168);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(186, 22);
            this.tbTelefon.TabIndex = 8;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPrenume.BackColor = System.Drawing.Color.White;
            this.tbPrenume.Location = new System.Drawing.Point(106, 136);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(186, 22);
            this.tbPrenume.TabIndex = 7;
            this.tbPrenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbEmail.Location = new System.Drawing.Point(106, 200);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(221, 22);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Optiuni:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cantitate:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbCantitate);
            this.groupBox1.Controls.Add(this.cbOptiuni);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produse";
            // 
            // cbCantitate
            // 
            this.cbCantitate.BackColor = System.Drawing.Color.MistyRose;
            this.cbCantitate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCantitate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCantitate.FormattingEnabled = true;
            this.cbCantitate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbCantitate.Location = new System.Drawing.Point(90, 91);
            this.cbCantitate.Name = "cbCantitate";
            this.cbCantitate.Size = new System.Drawing.Size(186, 27);
            this.cbCantitate.TabIndex = 14;
            // 
            // cbOptiuni
            // 
            this.cbOptiuni.BackColor = System.Drawing.Color.MistyRose;
            this.cbOptiuni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptiuni.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOptiuni.FormattingEnabled = true;
            this.cbOptiuni.Items.AddRange(new object[] {
            "Strawberry Cake",
            "Tiramisu",
            "Ecler",
            "Black Forest Cake",
            "Savarina",
            "Cupcake"});
            this.cbOptiuni.Location = new System.Drawing.Point(90, 36);
            this.cbOptiuni.Name = "cbOptiuni";
            this.cbOptiuni.Size = new System.Drawing.Size(186, 27);
            this.cbOptiuni.TabIndex = 13;
            this.cbOptiuni.SelectedIndexChanged += new System.EventHandler(this.cbOptiuni_SelectedIndexChanged);
            // 
            // btAdauga
            // 
            this.btAdauga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAdauga.BackColor = System.Drawing.Color.MistyRose;
            this.btAdauga.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdauga.Location = new System.Drawing.Point(14, 391);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(164, 33);
            this.btAdauga.TabIndex = 15;
            this.btAdauga.Text = "Adauga Produs";
            this.btAdauga.UseVisualStyleBackColor = false;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // btFinal
            // 
            this.btFinal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btFinal.BackColor = System.Drawing.Color.MistyRose;
            this.btFinal.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinal.Location = new System.Drawing.Point(16, 502);
            this.btFinal.Name = "btFinal";
            this.btFinal.Size = new System.Drawing.Size(162, 36);
            this.btFinal.TabIndex = 16;
            this.btFinal.Text = "Finalizeaza Comanda";
            this.btFinal.UseVisualStyleBackColor = false;
            this.btFinal.Click += new System.EventHandler(this.btFinal_Click);
            // 
            // btViewHistory
            // 
            this.btViewHistory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btViewHistory.BackColor = System.Drawing.Color.MistyRose;
            this.btViewHistory.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewHistory.Location = new System.Drawing.Point(766, 320);
            this.btViewHistory.Name = "btViewHistory";
            this.btViewHistory.Size = new System.Drawing.Size(258, 69);
            this.btViewHistory.TabIndex = 17;
            this.btViewHistory.Text = "Vizualizeaza istoricul comenzilor";
            this.btViewHistory.UseVisualStyleBackColor = false;
            this.btViewHistory.Click += new System.EventHandler(this.btViewHistory_Click);
            // 
            // dgvComanda
            // 
            this.dgvComanda.AllowUserToAddRows = false;
            this.dgvComanda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvComanda.AutoGenerateColumns = false;
            this.dgvComanda.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dgvComanda.DataSource = this.produseBindingSource;
            this.dgvComanda.Location = new System.Drawing.Point(467, 72);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.ReadOnly = true;
            this.dgvComanda.RowHeadersWidth = 51;
            this.dgvComanda.RowTemplate.Height = 24;
            this.dgvComanda.Size = new System.Drawing.Size(557, 242);
            this.dgvComanda.TabIndex = 18;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataSource = typeof(proiectVanzari.Produse);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btStergere
            // 
            this.btStergere.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btStergere.BackColor = System.Drawing.Color.MistyRose;
            this.btStergere.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStergere.Location = new System.Drawing.Point(16, 447);
            this.btStergere.Name = "btStergere";
            this.btStergere.Size = new System.Drawing.Size(162, 36);
            this.btStergere.TabIndex = 20;
            this.btStergere.Text = "Sterge Produs";
            this.btStergere.UseVisualStyleBackColor = false;
            this.btStergere.Click += new System.EventHandler(this.btStergere_Click);
            // 
            // btIesire
            // 
            this.btIesire.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btIesire.BackColor = System.Drawing.Color.MistyRose;
            this.btIesire.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIesire.Location = new System.Drawing.Point(948, 395);
            this.btIesire.Name = "btIesire";
            this.btIesire.Size = new System.Drawing.Size(76, 29);
            this.btIesire.TabIndex = 21;
            this.btIesire.Text = "Iesire";
            this.btIesire.UseVisualStyleBackColor = false;
            this.btIesire.Click += new System.EventHandler(this.btIesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 563);
            this.Controls.Add(this.btIesire);
            this.Controls.Add(this.btStergere);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.btViewHistory);
            this.Controls.Add(this.btFinal);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestiune Cofetarie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Button btFinal;
        private System.Windows.Forms.Button btViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btStergere;
        private System.Windows.Forms.Button btIesire;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbTelefon;
        public System.Windows.Forms.TextBox tbPrenume;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.ComboBox cbCantitate;
        public System.Windows.Forms.ComboBox cbOptiuni;
        public System.Windows.Forms.DataGridView dgvComanda;
    }
}

