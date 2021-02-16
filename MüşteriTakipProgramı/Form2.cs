using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace MüşteriTakipProgramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            OleDbDataAdapter Bul = new OleDbDataAdapter("select * from Musteriler ", baglanti);
            DataSet tasima = new DataSet();
            baglanti.Open();
            Bul.Fill(tasima, "Musteri");
            DataGridV_TumMusteriler.DataSource = tasima.Tables["Musteri"];
            baglanti.Close();

        }

        private void yeniMusteriTablo()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            baglanti.Open();
            string tabloOlustur1 = "CREATE TABLE Musteriler2(TC_Kimlik varchar(255),AdSoyad varchar(255),DoğumTarihi DATE,Adres varchar(255),Telefon varchar(255),CONSTRAINT PK_isimtelefon primary key(AdSoyad,Telefon))";
            OleDbCommand komut = new OleDbCommand(tabloOlustur1, baglanti);
            komut.ExecuteNonQuery();
            string tabloTasi1 = "insert into Musteriler2(TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon) select TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon FROM Musteriler";
            OleDbCommand komut2 = new OleDbCommand(tabloTasi1, baglanti);
            komut2.ExecuteNonQuery();
            string tabloSil = "DROP TABLE Musteriler";
            OleDbCommand komut3 = new OleDbCommand(tabloSil, baglanti);
            komut3.ExecuteNonQuery();
            string tabloOlustur2 = "CREATE TABLE Musteriler(TC_Kimlik varchar(255),AdSoyad varchar(255),DoğumTarihi DATE,Adres varchar(255),Telefon varchar(255),CONSTRAINT PK_isimtelefon primary key(AdSoyad,Telefon))";
            OleDbCommand komut4 = new OleDbCommand(tabloOlustur2, baglanti);
            komut4.ExecuteNonQuery();
            string tabloTasi2 = "insert into Musteriler(TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon) select TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon FROM Musteriler2";
            OleDbCommand komut5 = new OleDbCommand(tabloTasi2, baglanti);
            komut5.ExecuteNonQuery();
            string tabloSil2 = "DROP TABLE Musteriler2";
            OleDbCommand komut6 = new OleDbCommand(tabloSil2, baglanti);
            komut6.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            string sil = "DELETE FROM Musteriler WHERE AdSoyad=@AdSoyad AND Telefon=@Telefon";
            OleDbCommand komut = new OleDbCommand(sil, baglanti);
            try
            {
                komut.Parameters.AddWithValue("@AdSoyad", DataGridV_TumMusteriler.CurrentRow.Cells[1].Value.ToString());
                komut.Parameters.AddWithValue("@Telefon", DataGridV_TumMusteriler.CurrentRow.Cells[4].Value.ToString());
                baglanti.Open();
                int durum = komut.ExecuteNonQuery();
                baglanti.Close();
                if (durum != 0)
                {
                    MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Önce tablodan seçim yapınız, ardından sil butonuna tıklayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            yeniMusteriTablo();
            Listele();
        }
    }
}
