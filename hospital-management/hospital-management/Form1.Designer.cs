namespace hospital_management
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnCokGorulen = new System.Windows.Forms.TextBox();
            this.OrtalamaYatısSonuc = new System.Windows.Forms.TextBox();
            this.TaburcuHastaSonuc = new System.Windows.Forms.TextBox();
            this.YatanHastaSonuc = new System.Windows.Forms.TextBox();
            this.ToplamHastaSonuc = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HastaTür = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.HastaEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(12, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 28);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Hasta Takip Sistemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(674, 352);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EnCokGorulen);
            this.groupBox1.Controls.Add(this.OrtalamaYatısSonuc);
            this.groupBox1.Controls.Add(this.TaburcuHastaSonuc);
            this.groupBox1.Controls.Add(this.YatanHastaSonuc);
            this.groupBox1.Controls.Add(this.ToplamHastaSonuc);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistikler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EnCokGorulen
            // 
            this.EnCokGorulen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnCokGorulen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnCokGorulen.Location = new System.Drawing.Point(221, 146);
            this.EnCokGorulen.Name = "EnCokGorulen";
            this.EnCokGorulen.Size = new System.Drawing.Size(100, 19);
            this.EnCokGorulen.TabIndex = 11;
            // 
            // OrtalamaYatısSonuc
            // 
            this.OrtalamaYatısSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrtalamaYatısSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrtalamaYatısSonuc.Location = new System.Drawing.Point(221, 117);
            this.OrtalamaYatısSonuc.Name = "OrtalamaYatısSonuc";
            this.OrtalamaYatısSonuc.Size = new System.Drawing.Size(100, 19);
            this.OrtalamaYatısSonuc.TabIndex = 8;
            this.OrtalamaYatısSonuc.TextChanged += new System.EventHandler(this.OrtalamaYatısSonuc_TextChanged);
            // 
            // TaburcuHastaSonuc
            // 
            this.TaburcuHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaburcuHastaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaburcuHastaSonuc.Location = new System.Drawing.Point(221, 92);
            this.TaburcuHastaSonuc.Name = "TaburcuHastaSonuc";
            this.TaburcuHastaSonuc.Size = new System.Drawing.Size(100, 19);
            this.TaburcuHastaSonuc.TabIndex = 7;
            // 
            // YatanHastaSonuc
            // 
            this.YatanHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YatanHastaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YatanHastaSonuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.YatanHastaSonuc.Location = new System.Drawing.Point(221, 67);
            this.YatanHastaSonuc.Name = "YatanHastaSonuc";
            this.YatanHastaSonuc.Size = new System.Drawing.Size(100, 19);
            this.YatanHastaSonuc.TabIndex = 6;
            // 
            // ToplamHastaSonuc
            // 
            this.ToplamHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToplamHastaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToplamHastaSonuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ToplamHastaSonuc.Location = new System.Drawing.Point(221, 36);
            this.ToplamHastaSonuc.Name = "ToplamHastaSonuc";
            this.ToplamHastaSonuc.Size = new System.Drawing.Size(100, 19);
            this.ToplamHastaSonuc.TabIndex = 5;
            this.ToplamHastaSonuc.TextChanged += new System.EventHandler(this.ToplamHastaSonuc_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(6, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 19);
            this.textBox6.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HastaTür);
            this.groupBox2.Controls.Add(this.Güncelle);
            this.groupBox2.Controls.Add(this.Sil);
            this.groupBox2.Controls.Add(this.HastaEkle);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(413, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 189);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // HastaTür
            // 
            this.HastaTür.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HastaTür.Location = new System.Drawing.Point(143, 116);
            this.HastaTür.Name = "HastaTür";
            this.HastaTür.Size = new System.Drawing.Size(108, 49);
            this.HastaTür.TabIndex = 3;
            this.HastaTür.Text = "Hastalık Türleri";
            this.HastaTür.UseVisualStyleBackColor = false;
            this.HastaTür.Click += new System.EventHandler(this.HastaTür_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Güncelle.Location = new System.Drawing.Point(143, 37);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(108, 49);
            this.Güncelle.TabIndex = 2;
            this.Güncelle.Text = "Hasta güncelle";
            this.Güncelle.UseVisualStyleBackColor = false;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Red;
            this.Sil.Location = new System.Drawing.Point(16, 116);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(107, 49);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // HastaEkle
            // 
            this.HastaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HastaEkle.Location = new System.Drawing.Point(16, 37);
            this.HastaEkle.Name = "HastaEkle";
            this.HastaEkle.Size = new System.Drawing.Size(107, 49);
            this.HastaEkle.TabIndex = 0;
            this.HastaEkle.Text = "Hasta Ekle";
            this.HastaEkle.UseVisualStyleBackColor = false;
            this.HastaEkle.Click += new System.EventHandler(this.HastaEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Toplam Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yatan Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Taburcu Olan Hastalar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ortalama Yatış Süresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "En Çok Görülen Hastalık:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hasta Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button HastaTür;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button HastaEkle;
        private System.Windows.Forms.TextBox TaburcuHastaSonuc;
        private System.Windows.Forms.TextBox YatanHastaSonuc;
        private System.Windows.Forms.TextBox ToplamHastaSonuc;
        private System.Windows.Forms.TextBox OrtalamaYatısSonuc;
        private System.Windows.Forms.TextBox EnCokGorulen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}