namespace proiectVanzari
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
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btViewComanda = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.savetsm = new System.Windows.Forms.ToolStripMenuItem();
            this.printtsm = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiertsm = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Istoric Comenzi";
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(12, 400);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(140, 38);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Sterge Comanda";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btViewComanda
            // 
            this.btViewComanda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btViewComanda.BackColor = System.Drawing.Color.MistyRose;
            this.btViewComanda.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btViewComanda.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewComanda.Location = new System.Drawing.Point(636, 400);
            this.btViewComanda.Name = "btViewComanda";
            this.btViewComanda.Size = new System.Drawing.Size(152, 38);
            this.btViewComanda.TabIndex = 3;
            this.btViewComanda.Text = "Iesire";
            this.btViewComanda.UseVisualStyleBackColor = false;
            // 
            // lv1
            // 
            this.lv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv1.BackColor = System.Drawing.Color.Thistle;
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4,
            this.ch5,
            this.ch6,
            this.ch7});
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(12, 44);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(776, 269);
            this.lv1.TabIndex = 5;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "Nume";
            // 
            // ch2
            // 
            this.ch2.Text = "Prenume ";
            this.ch2.Width = 73;
            // 
            // ch3
            // 
            this.ch3.Text = "Telefon";
            this.ch3.Width = 85;
            // 
            // ch4
            // 
            this.ch4.Text = "E-mail";
            this.ch4.Width = 120;
            // 
            // ch5
            // 
            this.ch5.Text = "Produse";
            this.ch5.Width = 136;
            // 
            // ch6
            // 
            this.ch6.Text = "Data Comanda";
            this.ch6.Width = 134;
            // 
            // ch7
            // 
            this.ch7.Text = "Pret Total";
            this.ch7.Width = 96;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetsm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // savetsm
            // 
            this.savetsm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.savetsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printtsm,
            this.fisiertsm});
            this.savetsm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetsm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savetsm.Name = "savetsm";
            this.savetsm.Size = new System.Drawing.Size(70, 21);
            this.savetsm.Text = "Salvare";
            this.savetsm.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // printtsm
            // 
            this.printtsm.Name = "printtsm";
            this.printtsm.Size = new System.Drawing.Size(128, 26);
            this.printtsm.Text = "Print";
            this.printtsm.Click += new System.EventHandler(this.printtsm_Click);
            // 
            // fisiertsm
            // 
            this.fisiertsm.Name = "fisiertsm";
            this.fisiertsm.Size = new System.Drawing.Size(128, 26);
            this.fisiertsm.Text = "Fisier";
            this.fisiertsm.Click += new System.EventHandler(this.fisiertsm_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btViewComanda);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Istoric";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btViewComanda;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.ColumnHeader ch5;
        private System.Windows.Forms.ColumnHeader ch6;
        private System.Windows.Forms.ColumnHeader ch7;
        public System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ToolStripMenuItem savetsm;
        private System.Windows.Forms.ToolStripMenuItem printtsm;
        private System.Windows.Forms.ToolStripMenuItem fisiertsm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}