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

            cmbox_hstalikTuru.DataSource = dt;
            cmbox_hstalikTuru.DisplayMember = "HastalikAdi";
            cmbox_hstalikTuru.ValueMember = "Id";
            cmbox_hstalikTuru.SelectedIndex = -1;
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
                txt_adSoyad.Text = dr["AdSoyad"].ToString();
                cmbox_hstalikTuru.SelectedValue = dr["HastalikTuruId"];
                txt_teshis.Text = dr["TeshisDetayi"].ToString();
                dateT_yatisTarihi.Value = Convert.ToDateTime(dr["YatisTarihi"]);

                int cinsiyet = Convert.ToInt32(dr["Cinsiyet"]);
                if (cinsiyet == 0)
                {
                    radioBtn_erkek.Checked = true;
                }
                else
                {
                    radioBtn_kadin.Checked = true;
                }

                numbertxt_Yas.Value = Convert.ToInt32(dr["Yas"]);

                if (dr["TaburcuTarihi"] != DBNull.Value)
                {
                    taburcu_checkbox.Checked = true;
                    dateT_taburcuTarihi.Value = Convert.ToDateTime(dr["TaburcuTarihi"]);
                    dateT_taburcuTarihi.Enabled = true;
                }
                else
                {
                    taburcu_checkbox.Checked = false;
                    dateT_taburcuTarihi.Enabled = false;
                    dateT_taburcuTarihi.Text = null;
                }
            }
            txt_uygulnanTedaviler.Text = dr["UygulananTedaviler"].ToString();

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
            if (taburcu_checkbox.Checked)
            {
                guncelle = "UPDATE Hasta SET AdSoyad=@adsoyad, HastalikTuruId=@hastalikturuId, TeshisDetayi=@teshis, YatisTarihi=@yatisTarihi, Cinsiyet=@cinsiyet, Yas=@yas, TaburcuTarihi=@taburcuTarihi, UygulananTedaviler=@uygulananTedaviler WHERE Id=@id";
            }
            else
            {
                guncelle = "UPDATE Hasta SET AdSoyad=@adsoyad, HastalikTuruId=@hastalikturuId, TeshisDetayi=@teshis, YatisTarihi=@yatisTarihi, Cinsiyet=@cinsiyet, Yas=@yas, TaburcuTarihi=NULL, UygulananTedaviler=@uygulananTedaviler WHERE Id=@id";
            }

            SqlCommand VeriGuncelle = new SqlCommand(guncelle, baglan);
            VeriGuncelle.Parameters.AddWithValue("@id", secilenId);
            VeriGuncelle.Parameters.AddWithValue("@adsoyad", txt_adSoyad.Text);
            VeriGuncelle.Parameters.AddWithValue("@hastalikturuId", cmbox_hstalikTuru.SelectedValue);
            VeriGuncelle.Parameters.AddWithValue("@teshis", txt_teshis.Text);
            VeriGuncelle.Parameters.AddWithValue("@yatisTarihi", dateT_yatisTarihi.Value);
            VeriGuncelle.Parameters.AddWithValue("@cinsiyet", radioBtn_erkek.Checked ? 0 : 1);
            VeriGuncelle.Parameters.AddWithValue("@yas", numbertxt_Yas.Value);
            VeriGuncelle.Parameters.AddWithValue("@uygulananTedaviler", txt_uygulnanTedaviler.Text);

            if (taburcu_checkbox.Checked)
            {
                VeriGuncelle.Parameters.AddWithValue("@taburcuTarihi", dateT_taburcuTarihi.Value);
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
            dateT_taburcuTarihi.Enabled = taburcu_checkbox.Checked;
            if (taburcu_checkbox.Checked)
            {
                dateT_taburcuTarihi.Value = DateTime.Now;
            }
        }

        void Temizle()
        {
            txt_adSoyad.Text = "";
            txt_teshis.Text = "";
            cmbox_hstalikTuru.SelectedIndex = -1;
            dateT_yatisTarihi.Value = DateTime.Now;
            radioBtn_erkek.Checked = true;
            numbertxt_Yas.Value = 1;
            taburcu_checkbox.Checked = false;
            dateT_taburcuTarihi.Enabled = false;
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
