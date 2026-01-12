namespace hospital_management
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_uygulnanTedaviler = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateT_taburcuTarihi = new System.Windows.Forms.DateTimePicker();
            this.taburcu_checkbox = new System.Windows.Forms.CheckBox();
            this.numbertxt_Yas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.radioBtn_kadin = new System.Windows.Forms.RadioButton();
            this.radioBtn_erkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateT_yatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_teshis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbox_hstalikTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbertxt_Yas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Güncelle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(33, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(226, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_uygulnanTedaviler);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateT_taburcuTarihi);
            this.groupBox2.Controls.Add(this.taburcu_checkbox);
            this.groupBox2.Controls.Add(this.numbertxt_Yas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.radioBtn_kadin);
            this.groupBox2.Controls.Add(this.radioBtn_erkek);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateT_yatisTarihi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_teshis);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbox_hstalikTuru);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_adSoyad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(279, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 540);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Bilgileri";
            // 
            // txt_uygulnanTedaviler
            // 
            this.txt_uygulnanTedaviler.Location = new System.Drawing.Point(180, 403);
            this.txt_uygulnanTedaviler.Multiline = true;
            this.txt_uygulnanTedaviler.Name = "txt_uygulnanTedaviler";
            this.txt_uygulnanTedaviler.Size = new System.Drawing.Size(224, 66);
            this.txt_uygulnanTedaviler.TabIndex = 17;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_guncelle.Location = new System.Drawing.Point(216, 493);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(147, 37);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "Uygulanan Tedaviler:";
            // 
            // dateT_taburcuTarihi
            // 
            this.dateT_taburcuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_taburcuTarihi.Location = new System.Drawing.Point(180, 337);
            this.dateT_taburcuTarihi.Name = "dateT_taburcuTarihi";
            this.dateT_taburcuTarihi.Size = new System.Drawing.Size(224, 44);
            this.dateT_taburcuTarihi.TabIndex = 14;
            // 
            // taburcu_checkbox
            // 
            this.taburcu_checkbox.AutoSize = true;
            this.taburcu_checkbox.Location = new System.Drawing.Point(72, 342);
            this.taburcu_checkbox.Name = "taburcu_checkbox";
            this.taburcu_checkbox.Size = new System.Drawing.Size(168, 40);
            this.taburcu_checkbox.TabIndex = 13;
            this.taburcu_checkbox.Text = "Taburcu:";
            this.taburcu_checkbox.UseVisualStyleBackColor = true;
            this.taburcu_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numbertxt_Yas
            // 
            this.numbertxt_Yas.Location = new System.Drawing.Point(180, 293);
            this.numbertxt_Yas.Name = "numbertxt_Yas";
            this.numbertxt_Yas.Size = new System.Drawing.Size(224, 44);
            this.numbertxt_Yas.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Yaş:";
            // 
            // radioBtn_kadin
            // 
            this.radioBtn_kadin.AutoSize = true;
            this.radioBtn_kadin.Location = new System.Drawing.Point(308, 256);
            this.radioBtn_kadin.Name = "radioBtn_kadin";
            this.radioBtn_kadin.Size = new System.Drawing.Size(128, 40);
            this.radioBtn_kadin.TabIndex = 10;
            this.radioBtn_kadin.TabStop = true;
            this.radioBtn_kadin.Text = "Kadın";
            this.radioBtn_kadin.UseVisualStyleBackColor = true;
            // 
            // radioBtn_erkek
            // 
            this.radioBtn_erkek.AutoSize = true;
            this.radioBtn_erkek.Location = new System.Drawing.Point(180, 256);
            this.radioBtn_erkek.Name = "radioBtn_erkek";
            this.radioBtn_erkek.Size = new System.Drawing.Size(127, 40);
            this.radioBtn_erkek.TabIndex = 9;
            this.radioBtn_erkek.TabStop = true;
            this.radioBtn_erkek.Text = "Erkek";
            this.radioBtn_erkek.UseVisualStyleBackColor = true;
            this.radioBtn_erkek.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cinsiyet:";
            // 
            // dateT_yatisTarihi
            // 
            this.dateT_yatisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_yatisTarihi.Location = new System.Drawing.Point(180, 208);
            this.dateT_yatisTarihi.Name = "dateT_yatisTarihi";
            this.dateT_yatisTarihi.Size = new System.Drawing.Size(224, 44);
            this.dateT_yatisTarihi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yatış Tarihi:";
            // 
            // txt_teshis
            // 
            this.txt_teshis.Location = new System.Drawing.Point(180, 127);
            this.txt_teshis.Multiline = true;
            this.txt_teshis.Name = "txt_teshis";
            this.txt_teshis.Size = new System.Drawing.Size(224, 66);
            this.txt_teshis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teşhis:";
            // 
            // cmbox_hstalikTuru
            // 
            this.cmbox_hstalikTuru.FormattingEnabled = true;
            this.cmbox_hstalikTuru.Location = new System.Drawing.Point(180, 91);
            this.cmbox_hstalikTuru.Name = "cmbox_hstalikTuru";
            this.cmbox_hstalikTuru.Size = new System.Drawing.Size(224, 44);
            this.cmbox_hstalikTuru.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastalık Türü:";
            // 
            // txt_adSoyad
            // 
            this.txt_adSoyad.Location = new System.Drawing.Point(180, 42);
            this.txt_adSoyad.Name = "txt_adSoyad";
            this.txt_adSoyad.Size = new System.Drawing.Size(224, 44);
            this.txt_adSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(566, 619);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(140, 42);
            this.btn_kapat.TabIndex = 16;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 670);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form3";
            this.Text = "Hasta Güncelle";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbertxt_Yas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateT_yatisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_teshis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbox_hstalikTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioBtn_kadin;
        private System.Windows.Forms.RadioButton radioBtn_erkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox taburcu_checkbox;
        private System.Windows.Forms.NumericUpDown numbertxt_Yas;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.DateTimePicker dateT_taburcuTarihi;
        private System.Windows.Forms.TextBox txt_uygulnanTedaviler;
        private System.Windows.Forms.Label label8;
    }
}