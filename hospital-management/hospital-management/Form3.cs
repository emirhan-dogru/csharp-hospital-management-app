using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management
{
    public partial class Form3 : Form
    {
        SqlConnection baglan = new SqlConnection("Server=63.178.197.220,1433;Database=hastane;User Id=dbuser;Password=1234;TrustServerCertificate=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HastalikTuruGetir();
            HastalariGetir();
        }

        void HastalariGetir()
        {
            da = new SqlDataAdapter("SELECT Id, AdSoyad FROM Hasta", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Hasta");
            dataGridView1.DataSource = ds.Tables["Hasta"];
            baglan.Close();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void HastalikTuruGetir()
        {
            baglan.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT Id, HastalikAdi FROM HastalikTuru", baglan);
            DataTable dt = new DataTable();
            da2.Fill(dt);
            baglan.Close();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "HastalikAdi";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }

        // datagridviewdan hasta secildiginde
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int secilenId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            baglan.Open();
            SqlCommand HastaBilgi = new SqlCommand("SELECT * FROM Hasta WHERE Id=@id", baglan);
            HastaBilgi.Parameters.AddWithValue("@id", secilenId);
            SqlDataReader dr = HastaBilgi.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["AdSoyad"].ToString();
                comboBox1.SelectedValue = dr["HastalikTuruId"];
                textBox2.Text = dr["TeshisDetayi"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["YatisTarihi"]);

                int cinsiyet = Convert.ToInt32(dr["Cinsiyet"]);
                if (cinsiyet == 0)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                numericUpDown1.Value = Convert.ToInt32(dr["Yas"]);

                if (dr["TaburcuTarihi"] != DBNull.Value)
                {
                    checkBox1.Checked = true;
                    dateTimePicker2.Value = Convert.ToDateTime(dr["TaburcuTarihi"]);
                    dateTimePicker2.Enabled = true;
                }
                else
                {
                    checkBox1.Checked = false;
                    dateTimePicker2.Enabled = false;
                    dateTimePicker2.Text = null;
                }
            }
            textBox3.Text = dr["UygulananTedaviler"].ToString();

            dr.Close();
            baglan.Close();
        }

        // guncelle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hasta seçiniz!");
                return;
            }

            int secilenId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            baglan.Open();

            string guncelle;
            if (checkBox1.Checked)
            {
                guncelle = "UPDATE Hasta SET AdSoyad=@adsoyad, HastalikTuruId=@hastalikturuId, TeshisDetayi=@teshis, YatisTarihi=@yatisTarihi, Cinsiyet=@cinsiyet, Yas=@yas, TaburcuTarihi=@taburcuTarihi, UygulananTedaviler=@uygulananTedaviler WHERE Id=@id";
            }
            else
            {
                guncelle = "UPDATE Hasta SET AdSoyad=@adsoyad, HastalikTuruId=@hastalikturuId, TeshisDetayi=@teshis, YatisTarihi=@yatisTarihi, Cinsiyet=@cinsiyet, Yas=@yas, TaburcuTarihi=NULL, UygulananTedaviler=@uygulananTedaviler WHERE Id=@id";
            }

            SqlCommand VeriGuncelle = new SqlCommand(guncelle, baglan);
            VeriGuncelle.Parameters.AddWithValue("@id", secilenId);
            VeriGuncelle.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            VeriGuncelle.Parameters.AddWithValue("@hastalikturuId", comboBox1.SelectedValue);
            VeriGuncelle.Parameters.AddWithValue("@teshis", textBox2.Text);
            VeriGuncelle.Parameters.AddWithValue("@yatisTarihi", dateTimePicker1.Value);
            VeriGuncelle.Parameters.AddWithValue("@cinsiyet", radioButton1.Checked ? 0 : 1);
            VeriGuncelle.Parameters.AddWithValue("@yas", numericUpDown1.Value);
            VeriGuncelle.Parameters.AddWithValue("@uygulananTedaviler", textBox3.Text);

            if (checkBox1.Checked)
            {
                VeriGuncelle.Parameters.AddWithValue("@taburcuTarihi", dateTimePicker2.Value);
            }

            VeriGuncelle.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Veri Güncellendi.");
            HastalariGetir();
            Temizle();
        }

        // taburcu checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = true;
            numericUpDown1.Value = 1;
            checkBox1.Checked = false;
            dateTimePicker2.Enabled = false;
        }

        // kapat butonu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
