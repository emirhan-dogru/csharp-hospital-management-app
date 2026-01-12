using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Server=63.178.197.220,1433;Database=hastane;User Id=dbuser;Password=1234;TrustServerCertificate=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BilgileriGoster();
            IstatistikGoster();
        }

        void BilgileriGoster()
        {
            da = new SqlDataAdapter("SELECT h.Id, h.AdSoyad, t.HastalikAdi, h.TeshisDetayi, h.YatisTarihi, CASE WHEN h.Cinsiyet = 0 THEN 'Erkek' ELSE 'Kadın' END AS Cinsiyet, h.Yas, ISNULL(h.UygulananTedaviler, 'Tedavi Devam Ediyor') AS UygulananTedaviler, h.TaburcuTarihi FROM Hasta h INNER JOIN HastalikTuru t ON h.HastalikTuruId = t.Id", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Hasta");
            dataGridView1.DataSource = ds.Tables["Hasta"];
            baglan.Close();

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dataGridView1.Columns["HastalikAdi"].HeaderText = "Hastalık";
            dataGridView1.Columns["TeshisDetayi"].HeaderText = "Teşhis";
            dataGridView1.Columns["YatisTarihi"].HeaderText = "Yatış Tarihi";
            dataGridView1.Columns["Cinsiyet"].HeaderText = "Cinsiyet";
            dataGridView1.Columns["Yas"].HeaderText = "Yaş";
            dataGridView1.Columns["TaburcuTarihi"].HeaderText = "Taburcu";
            dataGridView1.Columns["UygulananTedaviler"].HeaderText = "Uygulanan Tedaviler";
        }


        void IstatistikGoster()
        {
            baglan.Open();

            SqlCommand ToplamHasta = new SqlCommand("SELECT COUNT(*) FROM Hasta", baglan);
            int toplam = (int)ToplamHasta.ExecuteScalar();
            ToplamHastaSonuc.Text = toplam.ToString();

            SqlCommand YatanHasta = new SqlCommand("SELECT COUNT(*) FROM Hasta WHERE TaburcuTarihi IS NULL", baglan);
            int yatan = (int)YatanHasta.ExecuteScalar();
            YatanHastaSonuc.Text = yatan.ToString();

            SqlCommand TaburcuHasta = new SqlCommand("SELECT COUNT(*) FROM Hasta WHERE TaburcuTarihi IS NOT NULL", baglan);
            int taburcu = (int)TaburcuHasta.ExecuteScalar();
            TaburcuHastaSonuc.Text = taburcu.ToString();

            SqlCommand OrtalamaYatis = new SqlCommand("SELECT AVG(DATEDIFF(DAY, YatisTarihi, TaburcuTarihi)) FROM Hasta WHERE TaburcuTarihi IS NOT NULL",baglan);
            object ortalama = OrtalamaYatis.ExecuteScalar();
            if (ortalama != DBNull.Value)
            {
                OrtalamaYatısSonuc.Text = ortalama.ToString() + " gün";
            }
            else
            {
                OrtalamaYatısSonuc.Text = "0 gün";
            }

            SqlCommand EnCokHastalik = new SqlCommand("SELECT TOP 1 t.HastalikAdi FROM Hasta h INNER JOIN HastalikTuru t ON h.HastalikTuruId = t.Id GROUP BY t.HastalikAdi ORDER BY COUNT(*) DESC", baglan);
            object encok = EnCokHastalik.ExecuteScalar();
            if (encok != null)
            {
                EnCokGorulen.Text = encok.ToString();
            }
            else
            {
                EnCokGorulen.Text = "-";
            }

            baglan.Close();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HastaEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            BilgileriGoster();
            IstatistikGoster();

        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            BilgileriGoster();
            IstatistikGoster();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hasta seçiniz!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                baglan.Open();
                SqlCommand VeriSil = new SqlCommand("DELETE FROM Hasta WHERE Id=@id", baglan);
                VeriSil.Parameters.AddWithValue("@id", id);
                VeriSil.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Silindi.");
                BilgileriGoster();
                IstatistikGoster();
            }
        }

        private void HastaTür_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToplamHastaSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrtalamaYatısSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
