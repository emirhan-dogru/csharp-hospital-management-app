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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.OrtalamaYatısSonuc = new System.Windows.Forms.TextBox();
            this.TaburcuHastaSonuc = new System.Windows.Forms.TextBox();
            this.YatanHastaSonuc = new System.Windows.Forms.TextBox();
            this.ToplamHastaSonuc = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HastaTür = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.HastaEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Hasta Takip Sistemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 352);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.OrtalamaYatısSonuc);
            this.groupBox1.Controls.Add(this.TaburcuHastaSonuc);
            this.groupBox1.Controls.Add(this.YatanHastaSonuc);
            this.groupBox1.Controls.Add(this.ToplamHastaSonuc);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistikler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(6, 140);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 18);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Ortalama Yatış süresi: ";
            // 
            // OrtalamaYatısSonuc
            // 
            this.OrtalamaYatısSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrtalamaYatısSonuc.Location = new System.Drawing.Point(221, 137);
            this.OrtalamaYatısSonuc.Name = "OrtalamaYatısSonuc";
            this.OrtalamaYatısSonuc.Size = new System.Drawing.Size(100, 22);
            this.OrtalamaYatısSonuc.TabIndex = 8;
            // 
            // TaburcuHastaSonuc
            // 
            this.TaburcuHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaburcuHastaSonuc.Location = new System.Drawing.Point(221, 93);
            this.TaburcuHastaSonuc.Name = "TaburcuHastaSonuc";
            this.TaburcuHastaSonuc.Size = new System.Drawing.Size(100, 22);
            this.TaburcuHastaSonuc.TabIndex = 7;
            // 
            // YatanHastaSonuc
            // 
            this.YatanHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YatanHastaSonuc.Location = new System.Drawing.Point(221, 62);
            this.YatanHastaSonuc.Name = "YatanHastaSonuc";
            this.YatanHastaSonuc.Size = new System.Drawing.Size(100, 22);
            this.YatanHastaSonuc.TabIndex = 6;
            // 
            // ToplamHastaSonuc
            // 
            this.ToplamHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToplamHastaSonuc.Location = new System.Drawing.Point(221, 34);
            this.ToplamHastaSonuc.Name = "ToplamHastaSonuc";
            this.ToplamHastaSonuc.Size = new System.Drawing.Size(100, 22);
            this.ToplamHastaSonuc.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(6, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(6, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(145, 18);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Taburcu Olan Hastalar: ";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 18);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Yatan Hasta: ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 18);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Toplam Hasta: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HastaTür);
            this.groupBox2.Controls.Add(this.Güncelle);
            this.groupBox2.Controls.Add(this.Sil);
            this.groupBox2.Controls.Add(this.HastaEkle);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Güncelle.Text = "Güncelle";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button HastaTür;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button HastaEkle;
        private System.Windows.Forms.TextBox TaburcuHastaSonuc;
        private System.Windows.Forms.TextBox YatanHastaSonuc;
        private System.Windows.Forms.TextBox ToplamHastaSonuc;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox OrtalamaYatısSonuc;
    }
}