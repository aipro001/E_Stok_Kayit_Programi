namespace Talas_Makine_İkmal_Depo
{
    partial class FrmRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 63);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "RAPORLAMA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(1215, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 36);
            this.button5.TabIndex = 56;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(3, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(228, 24);
            this.lblCount.TabIndex = 58;
            this.lblCount.Text = "TOPLAM KAYIT SAYISI: 0";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(50, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 29);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "NO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 26);
            this.panel2.TabIndex = 21;
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRaporOlustur.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRaporOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporOlustur.ForeColor = System.Drawing.Color.White;
            this.btnRaporOlustur.Location = new System.Drawing.Point(214, 54);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(181, 41);
            this.btnRaporOlustur.TabIndex = 53;
            this.btnRaporOlustur.Text = "RAPOR OLUŞTUR";
            this.btnRaporOlustur.UseVisualStyleBackColor = false;
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 26);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(436, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker2.TabIndex = 62;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(303, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "GİRİŞ TARİHİ:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1252, 41);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(305, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 63;
            this.label4.Text = "ÇIKIŞ TARİHİ:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1252, 41);
            this.panel6.TabIndex = 64;
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(42, 54);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(171, 41);
            this.btnYenile.TabIndex = 65;
            this.btnYenile.Text = "SAYFAYI YENİLE";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel11.Controls.Add(this.txtID);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.txtAra);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1252, 41);
            this.panel11.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(383, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "ARA:";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(436, 6);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(415, 29);
            this.txtAra.TabIndex = 45;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel7.Controls.Add(this.lblCount);
            this.panel7.Location = new System.Drawing.Point(42, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(353, 41);
            this.panel7.TabIndex = 72;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1252, 248);
            this.panel8.TabIndex = 74;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.btnRaporOlustur);
            this.panel10.Controls.Add(this.btnYenile);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(845, 123);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(407, 125);
            this.panel10.TabIndex = 76;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(839, 125);
            this.panel5.TabIndex = 75;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel9.Controls.Add(this.txtResim);
            this.panel9.Location = new System.Drawing.Point(12, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(418, 41);
            this.panel9.TabIndex = 73;
            // 
            // txtResim
            // 
            this.txtResim.Enabled = false;
            this.txtResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResim.Location = new System.Drawing.Point(3, 6);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(412, 29);
            this.txtResim.TabIndex = 74;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(436, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRaporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.FrmRaporlama_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRaporlama_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRaporOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
    }
}