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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            DListele();
        }

        private void Listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            OleDbDataAdapter Bul = new OleDbDataAdapter("select * from MusteriListe order by Tarih desc", baglanti);
            DataSet tasima = new DataSet();
            baglanti.Open();
            Bul.Fill(tasima, "Musteri");
            dataGridView2.DataSource = tasima.Tables["Musteri"];
            baglanti.Close();

        }
        private void DListele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            OleDbDataAdapter Bul = new OleDbDataAdapter("SELECT AdSoyad, Telefon,DoğumTarihi FROM Musteriler WHERE DATEDIFF('d', NOW(),DATEADD('yyyy', YEAR(NOW()) - YEAR(DoğumTarihi),DoğumTarihi)) BETWEEN 0 AND 7", baglanti);
            DataSet tasima2 = new DataSet();
            baglanti.Open();
            Bul.Fill(tasima2, "DMusteri");
            dataGridView1.DataSource = tasima2.Tables["DMusteri"];
            baglanti.Close();

        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void yeniKayitTablo()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            baglanti.Open();
            //string adDegistir = "ALTER TABLE MusteriListe RENAME Temp";
            //OleDbCommand komut = new OleDbCommand(adDegistir, baglanti);
            //komut.ExecuteNonQuery();
            string tabloOlustur1 = "CREATE TABLE MusteriListe2(MNo AUTOINCREMENT primary key  NOT NULL ,TC_Kimlik varchar(255),AdSoyad varchar(255),DoğumTarihi DATE,Adres varchar(255),Telefon varchar(255),Yapılanİşlem varchar(255),Tarih DATE,ToplamTutar int,YapılanÖdeme int,Taksit varchar(255),KalanÖdeme int,SonrakiRandevu varchar(255))";
            OleDbCommand komut = new OleDbCommand(tabloOlustur1, baglanti);
            komut.ExecuteNonQuery();
            string tabloTasi1 = "insert into MusteriListe2(TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon,Yapılanİşlem,Tarih,ToplamTutar,YapılanÖdeme,Taksit,KalanÖdeme,SonrakiRandevu) select TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon,Yapılanİşlem,Tarih,ToplamTutar,YapılanÖdeme,Taksit,KalanÖdeme,SonrakiRandevu FROM MusteriListe";
            OleDbCommand komut2 = new OleDbCommand(tabloTasi1, baglanti);
            komut2.ExecuteNonQuery();
            string tabloSil = "DROP TABLE MusteriListe";
            OleDbCommand komut3 = new OleDbCommand(tabloSil, baglanti);
            komut3.ExecuteNonQuery();
            string tabloOlustur2 = "CREATE TABLE MusteriListe(MNo AUTOINCREMENT primary key  NOT NULL ,TC_Kimlik varchar(255),AdSoyad varchar(255),DoğumTarihi DATE,Adres varchar(255),Telefon varchar(255),Yapılanİşlem varchar(255),Tarih DATE,ToplamTutar int,YapılanÖdeme int,Taksit varchar(255),KalanÖdeme int,SonrakiRandevu varchar(255))";
            OleDbCommand komut4 = new OleDbCommand(tabloOlustur2, baglanti);
            komut4.ExecuteNonQuery();
            string tabloTasi2 = "insert into MusteriListe(TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon,Yapılanİşlem,Tarih,ToplamTutar,YapılanÖdeme,Taksit,KalanÖdeme,SonrakiRandevu) select TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon,Yapılanİşlem,Tarih,ToplamTutar,YapılanÖdeme,Taksit,KalanÖdeme,SonrakiRandevu FROM MusteriListe2";
            OleDbCommand komut5 = new OleDbCommand(tabloTasi2, baglanti);
            komut5.ExecuteNonQuery();
            string tabloSil2 = "DROP TABLE MusteriListe2";
            OleDbCommand komut6 = new OleDbCommand(tabloSil2, baglanti);
            komut6.ExecuteNonQuery();
            baglanti.Close();      
        }

        
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Txt_MusteriAdSoyad.Text == "" && Txt_MusteriAdres.Text == "" && Txt_MusteriTel.Text == "" && Txt_MusteriIslem.Text == "" && Txt_MusteriToplamTutar.Text == "" && Txt_MusteriOdeme.Text == "")
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else {
                string tutar, ödeme;
                int kalan;
                tutar = Txt_MusteriToplamTutar.Text;
                ödeme = Txt_MusteriOdeme.Text;
                kalan = Convert.ToInt32(tutar) - Convert.ToInt32(ödeme);
                Txt_MusteriKalanOdeme.Text = Convert.ToString(kalan);
                string ad = Txt_MusteriAdSoyad.Text;
                ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ad);

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
                baglanti.Open();
                string ekle = "insert into MusteriListe(TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon,Yapılanİşlem,Tarih,ToplamTutar,YapılanÖdeme,Taksit,KalanÖdeme,SonrakiRandevu)values(@TC_Kimlik,@AdSoyad,@DoğumTarihi,@Adres,@Telefon,@Yapılanİşlem,@Tarih,@ToplamTutar,@YapılanÖdeme,@Taksit,@KalanÖdeme,@SonrakiRandevu)";
                OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("@TC_Kimlik", Txt_MusteriTC.Text);
                komut.Parameters.AddWithValue("@AdSoyad", Txt_MusteriAdSoyad.Text.ToUpper());
                komut.Parameters.AddWithValue("@DoğumTarihi", DateT_DogumT.Value.ToOADate());
                komut.Parameters.AddWithValue("@Adres", Txt_MusteriAdres.Text.ToUpper());
                komut.Parameters.AddWithValue("@Telefon", Txt_MusteriTel.Text);
                komut.Parameters.AddWithValue("@Yapılanİşlem", Txt_MusteriIslem.Text.ToUpper());
                komut.Parameters.AddWithValue("@Tarih", DateT_Tarih.Value.ToOADate());
                komut.Parameters.AddWithValue("@ToplamTutar", Convert.ToInt32(Txt_MusteriToplamTutar.Text));
                komut.Parameters.AddWithValue("@YapılanÖdeme", Convert.ToInt32(Txt_MusteriOdeme.Text));
                komut.Parameters.AddWithValue("@Taksit", Txt_MusteriTaksit.Text);
                komut.Parameters.AddWithValue("@KalanÖdeme", Convert.ToInt32(Txt_MusteriKalanOdeme.Text));
                komut.Parameters.AddWithValue("@SonrakiRandevu", Txt_MusteriRandevu.Text);
                komut.ExecuteNonQuery();

                string ekle2 = "insert into Musteriler(TC_Kimlik,AdSoyad,DoğumTarihi,Adres,Telefon)values(@TC_Kimlik,@AdSoyad,@DoğumTarihi,@Adres,@Telefon)";
                OleDbCommand komut2 = new OleDbCommand(ekle2, baglanti);
                komut2.Parameters.AddWithValue("@TC_Kimlik", Txt_MusteriTC.Text);
                komut2.Parameters.AddWithValue("@AdSoyad", Txt_MusteriAdSoyad.Text.ToUpper());
                komut2.Parameters.AddWithValue("@DoğumTarihi", DateT_DogumT.Value.ToOADate());
                komut2.Parameters.AddWithValue("@Adres", Txt_MusteriAdres.Text.ToUpper());
                komut2.Parameters.AddWithValue("@Telefon", Txt_MusteriTel.Text);
                try { komut2.ExecuteNonQuery(); }
                catch {}
                

                baglanti.Close();
                Temizle();
                DateT_Tarih.ResetText();
                DateT_DogumT.ResetText();
                Listele();
                DListele();
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (Txt_MusteriAdSoyad.Text == "" && Txt_MusteriAdres.Text == "" && Txt_MusteriTel.Text == "" && Txt_MusteriIslem.Text == "" && Txt_MusteriToplamTutar.Text == "" && Txt_MusteriOdeme.Text == "")
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
                string guncelle = "UPDATE MusteriListe SET TC_Kimlik=@TC_Kimlik,AdSoyad=@AdSoyad,DoğumTarihi=@DoğumTarihi,Adres=@Adres,Telefon=@Telefon,Yapılanİşlem=@Yapılanİşlem,Tarih=@Tarih,ToplamTutar=@ToplamTutar,YapılanÖdeme=@YapılanÖdeme,Taksit=@Taksit,KalanÖdeme=@KalanÖdeme,SonrakiRandevu=@SonrakiRandevu WHERE MNo=@MNo";
                OleDbCommand komut = new OleDbCommand(guncelle, baglanti);
                try
                {
                    komut.Parameters.AddWithValue("@TC_Kimlik", Txt_MusteriTC.Text);
                    komut.Parameters.AddWithValue("@AdSoyad", Txt_MusteriAdSoyad.Text.ToUpper());
                    komut.Parameters.AddWithValue("@DoğumTarihi", DateT_DogumT.Value.ToOADate());
                    komut.Parameters.AddWithValue("@Adres", Txt_MusteriAdres.Text.ToUpper());
                    komut.Parameters.AddWithValue("@Telefon", Txt_MusteriTel.Text);
                    komut.Parameters.AddWithValue("@Yapılanİşlem", Txt_MusteriIslem.Text.ToUpper());
                    komut.Parameters.AddWithValue("@Tarih", DateT_Tarih.Value.ToOADate());
                    komut.Parameters.AddWithValue("@ToplamTutar", Convert.ToInt32(Txt_MusteriToplamTutar.Text));
                    komut.Parameters.AddWithValue("@YapılanÖdeme", Convert.ToInt32(Txt_MusteriOdeme.Text));
                    komut.Parameters.AddWithValue("@Taksit", Txt_MusteriTaksit.Text);
                    komut.Parameters.AddWithValue("@KalanÖdeme", Convert.ToInt32(Txt_MusteriKalanOdeme.Text) - Convert.ToInt32(Txt_MusteriOdeme.Text));
                    komut.Parameters.AddWithValue("@SonrakiRandevu", Txt_MusteriRandevu.Text);
                    komut.Parameters.AddWithValue("@MNo", Convert.ToInt32(Txt_MusteriNo.Text));



                    baglanti.Open();
                    int durum = komut.ExecuteNonQuery();
                    baglanti.Close();
                    Temizle();
                    DateT_Tarih.ResetText();
                    DateT_DogumT.ResetText();
                    Listele();
                    if (durum != 0)
                    {
                        MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Sonra Güncelleme Yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Btn_Bul_Click(object sender, EventArgs e)
        {
            if (Txt_MusteriBul.Text == "")
            {
                MessageBox.Show("Arama Kısmı Boş Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (RadioBtn_MusteriAdi.Checked == true)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
                    OleDbDataAdapter Bul = new OleDbDataAdapter("select * from MusteriListe where AdSoyad like '%" + Txt_MusteriBul.Text.ToUpper() + "%'order by Tarih desc", baglanti);
                    DataSet tasima = new DataSet();
                    baglanti.Open();
                    Bul.Fill(tasima, "Musteri");
                    dataGridView2.DataSource = tasima.Tables["Musteri"];
                    baglanti.Close();
                }

                if (RadioBtn_MusteriTel.Checked == true)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
                    OleDbDataAdapter Bul = new OleDbDataAdapter("select * from MusteriListe where Telefon like '%" + Txt_MusteriBul.Text + "%'order by Tarih desc", baglanti);
                    DataSet tasima = new DataSet();
                    baglanti.Open();
                    Bul.Fill(tasima, "Musteri");
                    dataGridView2.DataSource = tasima.Tables["Musteri"];
                    baglanti.Close();
                }
            }

            
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            Txt_MusteriNo.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Txt_MusteriTC.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Txt_MusteriAdSoyad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            DateT_DogumT.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Txt_MusteriAdres.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Txt_MusteriTel.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Txt_MusteriIslem.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            DateT_Tarih.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            Txt_MusteriToplamTutar.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            Txt_MusteriOdeme.Text = "0";
            Txt_MusteriTaksit.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            Txt_MusteriKalanOdeme.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            Txt_MusteriRandevu.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
        }

        private void Btn_TumMusteriler_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void Btn_MusteriListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Musteri.accdb");
            string sil = "DELETE FROM MusteriListe WHERE Mno=@MNo";
            OleDbCommand komut = new OleDbCommand(sil, baglanti);
            try
            {
                komut.Parameters.AddWithValue("@MNo", Convert.ToInt32(Txt_MusteriNo.Text));
                baglanti.Open();
                int durum = komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                DateT_Tarih.ResetText();
                DateT_DogumT.ResetText();
                if (durum != 0)
                {
                    MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Kayıt Bulunamadığından Dolayı Silinemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            yeniKayitTablo();
            Listele();
        }
    }
}

   


