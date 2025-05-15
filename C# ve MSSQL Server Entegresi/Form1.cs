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


namespace ProjeOdevi
{


    public partial class Form1 : Form

    {
        string connectionString = "Server=.;Database=Kitap;User Id=sa;Password=123;";

        public Form1()
        {
            InitializeComponent();
        }

        //ComboBox ögelerini kod yazarak doldurmak
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hikaye");
            comboBox1.Items.Add("Roman");
            comboBox1.Items.Add("Şiir");
            comboBox1.Items.Add("Tiyatro");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TblKitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Listele()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TblKitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        //Bilgileri  sol tarafta görüntüleme işlemi
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        //Yeni Kayıt Oluştur Ve Kaydet
        private void button2_Click(object sender, EventArgs e)
        {
            // Kitap türünü ID'ye çevir
            int turID = 0;
            SqlConnection baglanti = new SqlConnection(connectionString);
            switch (comboBox1.Text)
            {
                case "Hikaye":
                    turID = 9;
                    break;
                case "Roman":
                    turID = 10;
                    break;
                case "Şiir":
                    turID = 11;
                    break;
                case "Tiyatro":
                    turID = 12;
                    break;
            }
            SqlCommand komut = new SqlCommand("INSERT INTO TblKitaplar (KitapAd, Yazar, Sayfa, Fiyat, Yayınevi, Tur) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p5", textBox6.Text);
            komut.Parameters.AddWithValue("@p6", turID);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kitap başarıyla kaydedildi!");
        }

        //Güncelleme işlemi 
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            // Kitap türünü ID'ye çeviriyoruz
            int turID = 0;
            switch (comboBox1.Text)
            {
                case "9": turID = 9; break;
                case "10": turID = 10; break;
                case "11": turID = 11; break;
                case "12": turID = 12; break;
            }

            SqlCommand komut = new SqlCommand("UPDATE TblKitaplar SET KitapAd=@p1, Yazar=@p2, Sayfa=@p3, Fiyat=@p4, Yayınevi=@p5, Tur=@p6 WHERE KitapID=@p7", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p5", textBox6.Text);
            komut.Parameters.AddWithValue("@p6", turID);
            komut.Parameters.AddWithValue("@p7", textBox1.Text); // ID’ye göre güncelliyoruz

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }
        //Sil işlemini Yapıyoruz
        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from TblKitaplar where KitapID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Veri Tabanından Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();

        }
    }
}
    

   


