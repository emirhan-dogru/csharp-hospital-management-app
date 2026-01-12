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

namespace hospital_management
{
    public partial class Form4 : Form
    {
        SqlConnection baglan = new SqlConnection("Server = 63.178.197.220, 1433; Database=hastane;User Id = dbuser; Password=1234;TrustServerCertificate=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            BilgileriGoster();
        }

        void BilgileriGoster()
        {
            da = new SqlDataAdapter("SELECT * FROM HastalikTuru", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "HastalikTuru");
            dataGridView1.DataSource = ds.Tables["HastalikTuru"];
            baglan.Close();

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["HastalikAdi"].HeaderText = "Hastalık Adı";
        }

        // kaydet butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Hastalık adı boş olamaz!");
                return;
            }

            baglan.Open();
            SqlCommand VeriEkle = new SqlCommand("INSERT INTO HastalikTuru (HastalikAdi) VALUES (@hastalikAdi)", baglan);
            VeriEkle.Parameters.AddWithValue("@hastalikAdi", textBox2.Text);
            VeriEkle.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Hastalık Türü Eklendi.");
            Temizle();
            BilgileriGoster();
        }

        // guncelle butonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kayıt seçiniz!");
                return;
            }

            baglan.Open();
            SqlCommand VeriGuncelle = new SqlCommand("UPDATE HastalikTuru SET HastalikAdi=@hastalikAdi WHERE Id=@id", baglan);
            VeriGuncelle.Parameters.AddWithValue("@id", textBox1.Text);
            VeriGuncelle.Parameters.AddWithValue("@hastalikAdi", textBox2.Text);
            VeriGuncelle.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Veri Güncellendi.");
            Temizle();
            BilgileriGoster();
        }

        // sil butonu
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kayıt seçiniz!");
                return;
            }

            DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                baglan.Open();
                SqlCommand VeriSil = new SqlCommand("DELETE FROM HastalikTuru WHERE Id=@id", baglan);
                VeriSil.Parameters.AddWithValue("@id", textBox1.Text);
                VeriSil.ExecuteNonQuery();
                baglan.Close();

                MessageBox.Show("Kayıt Silindi.");
                Temizle();
                BilgileriGoster();
            }
        }

        // datagridview secildiginde
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["HastalikAdi"].Value.ToString();
            }
        }

        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // kapat butonu
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
