using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital_management
{
    public partial class Form2 : Form
    {

        SqlConnection baglan = new SqlConnection("Server=63.178.197.220,1433;Database=hastane;User Id=dbuser;Password=1234;TrustServerCertificate=True;");


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HastalikTuruGetir();
        }

        void HastalikTuruGetir()
        {
            baglan.Open();
            SqlCommand HastalikGetir = new SqlCommand("SELECT Id, HastalikAdi FROM HastalikTuru", baglan);
            SqlDataReader dr = HastalikGetir.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "HastalikAdi";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;

            baglan.Close();
        }

        //kaydet butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm alanları doldurunuz!");
                return;
            }

            baglan.Open();
            SqlCommand VeriEkle = new SqlCommand("INSERT INTO Hasta (AdSoyad, HastalikTuruId, TeshisDetayi, YatisTarihi, Cinsiyet, Yas) VALUES (@adsoyad, @hastalikturuId, @teshis, @yatisTarihi, @cinsiyet, @yas)", baglan);
            VeriEkle.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            VeriEkle.Parameters.AddWithValue("@hastalikturuId", comboBox1.SelectedValue);
            VeriEkle.Parameters.AddWithValue("@teshis", textBox2.Text);
            VeriEkle.Parameters.AddWithValue("@yatisTarihi", dateTimePicker1.Value);
            VeriEkle.Parameters.AddWithValue("@cinsiyet", radioButton1.Checked ? 0 : 1);
            VeriEkle.Parameters.AddWithValue("@yas", numericUpDown1.Value);
            VeriEkle.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Hasta Eklendi.");
            Temizle();
        }

        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = true;
            numericUpDown1.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
