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


namespace KayipHayvanTakipSistemi
{
    

    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=LAPTOP-34O7JF87\\SQLEXPRESS;Initial Catalog=HayvanTakipDB;Integrated Security=True;";
        SqlConnection conn = new SqlConnection(connectionString);
        
        List<Ilan> ilanlar = new List<Ilan>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
            

            private void btnIlanEkle_Click(object sender, EventArgs e)
            {
            var hayvan = new Hayvan(txtHayvanAd.Text, txtTur.Text, txtCins.Text, int.Parse(txtYas.Text));
            var sahip = new Sahip(txtSahipAd.Text, txtTelefon.Text);
            var ilan = new Ilan(hayvan, sahip, dtpTarih.Text, txtAciklama.Text);

            ilanlar.Add(ilan);
            lstIlanlar.Items.Add(ilan.ToString());

            string connectionString = @"Data Source=LAPTOP-34O7JF87\SQLEXPRESS;Initial Catalog=HayvanTakipDB;Integrated Security=True;";

                
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    try
                    {
                        
                        string sorgu = @"INSERT INTO Ilanlar 
                            (HayvanAd, Tur, Cins, Yas, SahipAd, Telefon, KayipTarihi, Aciklama) 
                             VALUES 
                            (@HayvanAd, @Tur, @Cins, @Yas, @SahipAd, @Telefon, @KayipTarihi, @Aciklama)";

                        
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);

                       
                        komut.Parameters.AddWithValue("@HayvanAd", txtHayvanAd.Text);
                        komut.Parameters.AddWithValue("@Tur", txtTur.Text);
                        komut.Parameters.AddWithValue("@Cins", txtCins.Text);
                        komut.Parameters.AddWithValue("@Yas", int.Parse(txtYas.Text));
                        komut.Parameters.AddWithValue("@SahipAd", txtSahipAd.Text);
                        komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@KayipTarihi", dtpTarih.Value.Date);
                        komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);

                     


                    baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        
                        MessageBox.Show("İlan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        txtHayvanAd.Clear();
                        txtTur.Clear();
                        txtCins.Clear();
                        txtYas.Clear();
                        txtSahipAd.Clear();
                        txtTelefon.Clear();
                        txtAciklama.Clear();
                        dtpTarih.Value = DateTime.Now;
                    lstIlanlar.Items.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }

