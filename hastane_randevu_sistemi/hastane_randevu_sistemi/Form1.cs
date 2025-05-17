using hastane_randevu_sistemi.Entities;
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
using static System.Net.Mime.MediaTypeNames;

namespace hastane_randevu_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BranslariYukle();
            dateTimePickerRandevu.MinDate = DateTime.Now.AddDays(1); // en erken yarına randevu alınabilir.
            comboBoxSaat.Items.Insert(0, "Seçiniz");
            comboBoxSaat.Items.AddRange(new string[]
            {
                "09:00", "10:00", "11:00", "12:00",
                "13:00", "14:00", "15:00", "16:00"
            });
            comboBoxSaat.SelectedIndex = 0;
        }

        private void BranslariYukle()
        {
            List<Brans> branslar = new List<Brans>();

            string connectionString = "Server=DESKTOP-KROK7IU\\SQLEXPRESS01;Database=hastane_randevu_sistemi;Trusted_Connection=True;";

            Brans secinizBrans = new Brans { Id = -1, BransAdi = "Seçiniz" };

            branslar.Insert(0, secinizBrans);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Branslar", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    branslar.Add(new Brans
                    {
                        Id = (int)reader["Id"],
                        BransAdi = reader["BransAdi"].ToString()
                    });
                }
            }

            comboBoxBranslar.DataSource = branslar;
            comboBoxBranslar.DisplayMember = "BransAdi";
            comboBoxBranslar.ValueMember = "Id";
        }

        private void comboBoxBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBranslar.SelectedItem is Brans secilenBrans)
            {
                List<Doktor> doktorlar = new List<Doktor>();

                string connectionString = "Server=DESKTOP-KROK7IU\\SQLEXPRESS01;Database=hastane_randevu_sistemi;Trusted_Connection=True;";

                Doktor secinizDoktor = new Doktor { Id = -1, DoktorAdi = "Seçiniz", DoktorSoyadi = "" };
                doktorlar.Insert(0, secinizDoktor);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Doktorlar WHERE BransID = @BransID", conn);
                    cmd.Parameters.AddWithValue("@BransID", secilenBrans.Id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        doktorlar.Add(new Doktor
                        {
                            Id = (int)reader["Id"],
                            DoktorAdi = reader["DoktorAdi"].ToString(),
                            DoktorSoyadi = reader["DoktorSoyadi"].ToString(),
                            BransId = secilenBrans.Id
                        });
                    }
                }

                comboBoxDoktorlar.DataSource = doktorlar;
                comboBoxDoktorlar.DisplayMember = "TamAd";
                comboBoxDoktorlar.ValueMember = "Id";
            }
        }

        private bool CheckAllFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad alanı boş bırakılamaz. Lütfen adınızı giriniz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSoyad.Text))
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz. Lütfen soyadınızı giriniz.");
                return false;
            }
            if (string.Equals(comboBoxBranslar.SelectedItem.ToString(), "Seçiniz"))
            {
                MessageBox.Show("Lütfen geçerli bir branş seçiniz.");
                return false;
            }
            if (string.Equals(comboBoxDoktorlar.SelectedItem.ToString(), "Seçiniz"))
            {
                MessageBox.Show("Lütfen geçerli doktor seçiniz.");
                return false;
            }
            if (string.Equals(comboBoxSaat.SelectedItem.ToString(), "Seçiniz"))
            {
                MessageBox.Show("Geçerli bir saat seçiniz.");
                return false;
            }

            return true;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                int bransId = (int)comboBoxBranslar.SelectedValue;
                int doktorId = (int)comboBoxDoktorlar.SelectedValue;
                string hastaAdi = textBoxAd.Text.Trim();
                string hastaSoyadi = textBoxSoyad.Text.Trim();
                string saatStr = comboBoxSaat.SelectedItem.ToString();
                DateTime tarih = dateTimePickerRandevu.Value.Date.Add(TimeSpan.Parse(saatStr));


                string connectionString = "Server=DESKTOP-KROK7IU\\SQLEXPRESS01;Database=hastane_randevu_sistemi;Trusted_Connection=True;";

                string kontrolQuery = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @DoktorID AND Tarih = @Tarih";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand kontrolCmd = new SqlCommand(kontrolQuery, conn);
                    kontrolCmd.Parameters.AddWithValue("@DoktorID", doktorId);
                    kontrolCmd.Parameters.AddWithValue("@Tarih", tarih);

                    int sayi = (int)kontrolCmd.ExecuteScalar();

                    if (sayi > 0)
                    {
                        MessageBox.Show("Bu doktorun seçilen tarih ve saatte zaten bir randevusu var.");
                        return;
                    }

                    string ekleQuery = @"INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih)
                             VALUES (@HastaAdi, @HastaSoyadi, @BransID, @DoktorID, @Tarih)";

                    SqlCommand ekleCmd = new SqlCommand(ekleQuery, conn);
                    ekleCmd.Parameters.AddWithValue("@HastaAdi", hastaAdi);
                    ekleCmd.Parameters.AddWithValue("@HastaSoyadi", hastaSoyadi);
                    ekleCmd.Parameters.AddWithValue("@BransID", bransId);
                    ekleCmd.Parameters.AddWithValue("@DoktorID", doktorId);
                    ekleCmd.Parameters.AddWithValue("@Tarih", tarih);

                    int sonuc = ekleCmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Randevu başarıyla oluşturuldu.");
                    }
                    else
                    {
                        MessageBox.Show("Randevu oluşturulamadı.");
                    }
                }
            }
        }
    }
}
