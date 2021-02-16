namespace MüşteriTakipProgramı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_MusteriAd = new System.Windows.Forms.Label();
            this.Lbl_MusteriTel = new System.Windows.Forms.Label();
            this.Txt_MusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.Txt_MusteriTel = new System.Windows.Forms.TextBox();
            this.Lbl_MusteriIslem = new System.Windows.Forms.Label();
            this.Lbl_MusteriTarih = new System.Windows.Forms.Label();
            this.Lbl_MusteriRandevu = new System.Windows.Forms.Label();
            this.Txt_MusteriIslem = new System.Windows.Forms.TextBox();
            this.Lbl_MusteriOdeme = new System.Windows.Forms.Label();
            this.Txt_MusteriOdeme = new System.Windows.Forms.TextBox();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.Lbl_MusteriToplamTutar = new System.Windows.Forms.Label();
            this.Txt_MusteriToplamTutar = new System.Windows.Forms.TextBox();
            this.Lbl_MusteriBilgileri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioBtn_MusteriAdi = new System.Windows.Forms.RadioButton();
            this.RadioBtn_MusteriTel = new System.Windows.Forms.RadioButton();
            this.Btn_Bul = new System.Windows.Forms.Button();
            this.Lbl_MusteriDogumT = new System.Windows.Forms.Label();
            this.Lbl_MusteriDHatirlatma = new System.Windows.Forms.Label();
            this.Txt_MusteriBul = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Lbl_MusteriTaksit = new System.Windows.Forms.Label();
            this.Txt_MusteriTaksit = new System.Windows.Forms.TextBox();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Lbl_MusteriKalanOdeme = new System.Windows.Forms.Label();
            this.Txt_MusteriKalanOdeme = new System.Windows.Forms.TextBox();
            this.Txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.Lbl_MusteriNo = new System.Windows.Forms.Label();
            this.Txt_MusteriRandevu = new System.Windows.Forms.TextBox();
            this.DateT_DogumT = new System.Windows.Forms.DateTimePicker();
            this.DateT_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MusteriTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_MusteriAdres = new System.Windows.Forms.TextBox();
            this.Btn_TumMusteriler = new System.Windows.Forms.Button();
            this.Btn_MusteriListele = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_MusteriAd
            // 
            this.Lbl_MusteriAd.AutoSize = true;
            this.Lbl_MusteriAd.Location = new System.Drawing.Point(4, 89);
            this.Lbl_MusteriAd.Name = "Lbl_MusteriAd";
            this.Lbl_MusteriAd.Size = new System.Drawing.Size(104, 13);
            this.Lbl_MusteriAd.TabIndex = 0;
            this.Lbl_MusteriAd.Text = "*Müşteri Adı Soyadı :";
            // 
            // Lbl_MusteriTel
            // 
            this.Lbl_MusteriTel.AutoSize = true;
            this.Lbl_MusteriTel.Location = new System.Drawing.Point(55, 198);
            this.Lbl_MusteriTel.Name = "Lbl_MusteriTel";
            this.Lbl_MusteriTel.Size = new System.Drawing.Size(53, 13);
            this.Lbl_MusteriTel.TabIndex = 0;
            this.Lbl_MusteriTel.Text = "*Telefon :";
            // 
            // Txt_MusteriAdSoyad
            // 
            this.Txt_MusteriAdSoyad.Location = new System.Drawing.Point(110, 82);
            this.Txt_MusteriAdSoyad.Name = "Txt_MusteriAdSoyad";
            this.Txt_MusteriAdSoyad.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriAdSoyad.TabIndex = 2;
            // 
            // Txt_MusteriTel
            // 
            this.Txt_MusteriTel.Location = new System.Drawing.Point(110, 191);
            this.Txt_MusteriTel.MaxLength = 11;
            this.Txt_MusteriTel.Name = "Txt_MusteriTel";
            this.Txt_MusteriTel.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriTel.TabIndex = 5;
            // 
            // Lbl_MusteriIslem
            // 
            this.Lbl_MusteriIslem.AutoSize = true;
            this.Lbl_MusteriIslem.Location = new System.Drawing.Point(29, 217);
            this.Lbl_MusteriIslem.Name = "Lbl_MusteriIslem";
            this.Lbl_MusteriIslem.Size = new System.Drawing.Size(79, 13);
            this.Lbl_MusteriIslem.TabIndex = 0;
            this.Lbl_MusteriIslem.Text = "*Yapılan İşlem :";
            // 
            // Lbl_MusteriTarih
            // 
            this.Lbl_MusteriTarih.AutoSize = true;
            this.Lbl_MusteriTarih.Location = new System.Drawing.Point(67, 280);
            this.Lbl_MusteriTarih.Name = "Lbl_MusteriTarih";
            this.Lbl_MusteriTarih.Size = new System.Drawing.Size(41, 13);
            this.Lbl_MusteriTarih.TabIndex = 0;
            this.Lbl_MusteriTarih.Text = "*Tarih :";
            // 
            // Lbl_MusteriRandevu
            // 
            this.Lbl_MusteriRandevu.AutoSize = true;
            this.Lbl_MusteriRandevu.Location = new System.Drawing.Point(8, 410);
            this.Lbl_MusteriRandevu.Name = "Lbl_MusteriRandevu";
            this.Lbl_MusteriRandevu.Size = new System.Drawing.Size(96, 13);
            this.Lbl_MusteriRandevu.TabIndex = 0;
            this.Lbl_MusteriRandevu.Text = "Sonraki Randevu :";
            // 
            // Txt_MusteriIslem
            // 
            this.Txt_MusteriIslem.Location = new System.Drawing.Point(110, 217);
            this.Txt_MusteriIslem.Multiline = true;
            this.Txt_MusteriIslem.Name = "Txt_MusteriIslem";
            this.Txt_MusteriIslem.Size = new System.Drawing.Size(169, 51);
            this.Txt_MusteriIslem.TabIndex = 6;
            // 
            // Lbl_MusteriOdeme
            // 
            this.Lbl_MusteriOdeme.AutoSize = true;
            this.Lbl_MusteriOdeme.Location = new System.Drawing.Point(19, 332);
            this.Lbl_MusteriOdeme.Name = "Lbl_MusteriOdeme";
            this.Lbl_MusteriOdeme.Size = new System.Drawing.Size(89, 13);
            this.Lbl_MusteriOdeme.TabIndex = 0;
            this.Lbl_MusteriOdeme.Text = "*Yapılan Ödeme :";
            // 
            // Txt_MusteriOdeme
            // 
            this.Txt_MusteriOdeme.Location = new System.Drawing.Point(110, 325);
            this.Txt_MusteriOdeme.Name = "Txt_MusteriOdeme";
            this.Txt_MusteriOdeme.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriOdeme.TabIndex = 9;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Kaydet.Location = new System.Drawing.Point(43, 432);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(78, 34);
            this.Btn_Kaydet.TabIndex = 13;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = false;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Lbl_MusteriToplamTutar
            // 
            this.Lbl_MusteriToplamTutar.AutoSize = true;
            this.Lbl_MusteriToplamTutar.Location = new System.Drawing.Point(28, 306);
            this.Lbl_MusteriToplamTutar.Name = "Lbl_MusteriToplamTutar";
            this.Lbl_MusteriToplamTutar.Size = new System.Drawing.Size(80, 13);
            this.Lbl_MusteriToplamTutar.TabIndex = 0;
            this.Lbl_MusteriToplamTutar.Text = "*Toplam Tutar :";
            // 
            // Txt_MusteriToplamTutar
            // 
            this.Txt_MusteriToplamTutar.Location = new System.Drawing.Point(110, 299);
            this.Txt_MusteriToplamTutar.Name = "Txt_MusteriToplamTutar";
            this.Txt_MusteriToplamTutar.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriToplamTutar.TabIndex = 8;
            // 
            // Lbl_MusteriBilgileri
            // 
            this.Lbl_MusteriBilgileri.AutoSize = true;
            this.Lbl_MusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_MusteriBilgileri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_MusteriBilgileri.Location = new System.Drawing.Point(132, 8);
            this.Lbl_MusteriBilgileri.Name = "Lbl_MusteriBilgileri";
            this.Lbl_MusteriBilgileri.Size = new System.Drawing.Size(92, 15);
            this.Lbl_MusteriBilgileri.TabIndex = 0;
            this.Lbl_MusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(357, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama";
            // 
            // RadioBtn_MusteriAdi
            // 
            this.RadioBtn_MusteriAdi.AutoSize = true;
            this.RadioBtn_MusteriAdi.Location = new System.Drawing.Point(339, 34);
            this.RadioBtn_MusteriAdi.Name = "RadioBtn_MusteriAdi";
            this.RadioBtn_MusteriAdi.Size = new System.Drawing.Size(112, 17);
            this.RadioBtn_MusteriAdi.TabIndex = 15;
            this.RadioBtn_MusteriAdi.TabStop = true;
            this.RadioBtn_MusteriAdi.Text = "Müşteri Adı Soyadı";
            this.RadioBtn_MusteriAdi.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_MusteriTel
            // 
            this.RadioBtn_MusteriTel.AutoSize = true;
            this.RadioBtn_MusteriTel.Location = new System.Drawing.Point(339, 57);
            this.RadioBtn_MusteriTel.Name = "RadioBtn_MusteriTel";
            this.RadioBtn_MusteriTel.Size = new System.Drawing.Size(61, 17);
            this.RadioBtn_MusteriTel.TabIndex = 16;
            this.RadioBtn_MusteriTel.TabStop = true;
            this.RadioBtn_MusteriTel.Text = "Telefon";
            this.RadioBtn_MusteriTel.UseVisualStyleBackColor = true;
            // 
            // Btn_Bul
            // 
            this.Btn_Bul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Bul.ForeColor = System.Drawing.Color.Black;
            this.Btn_Bul.Location = new System.Drawing.Point(339, 108);
            this.Btn_Bul.Name = "Btn_Bul";
            this.Btn_Bul.Size = new System.Drawing.Size(78, 28);
            this.Btn_Bul.TabIndex = 18;
            this.Btn_Bul.Text = "Bul";
            this.Btn_Bul.UseVisualStyleBackColor = false;
            this.Btn_Bul.Click += new System.EventHandler(this.Btn_Bul_Click);
            // 
            // Lbl_MusteriDogumT
            // 
            this.Lbl_MusteriDogumT.AutoSize = true;
            this.Lbl_MusteriDogumT.Location = new System.Drawing.Point(28, 115);
            this.Lbl_MusteriDogumT.Name = "Lbl_MusteriDogumT";
            this.Lbl_MusteriDogumT.Size = new System.Drawing.Size(80, 13);
            this.Lbl_MusteriDogumT.TabIndex = 0;
            this.Lbl_MusteriDogumT.Text = "*Doğum Tarihi :";
            // 
            // Lbl_MusteriDHatirlatma
            // 
            this.Lbl_MusteriDHatirlatma.AutoSize = true;
            this.Lbl_MusteriDHatirlatma.Location = new System.Drawing.Point(336, 154);
            this.Lbl_MusteriDHatirlatma.Name = "Lbl_MusteriDHatirlatma";
            this.Lbl_MusteriDHatirlatma.Size = new System.Drawing.Size(189, 13);
            this.Lbl_MusteriDHatirlatma.TabIndex = 0;
            this.Lbl_MusteriDHatirlatma.Text = "Haftaya Doğum Günü Olan Müşteriler :";
            // 
            // Txt_MusteriBul
            // 
            this.Txt_MusteriBul.Location = new System.Drawing.Point(339, 80);
            this.Txt_MusteriBul.Name = "Txt_MusteriBul";
            this.Txt_MusteriBul.Size = new System.Drawing.Size(137, 20);
            this.Txt_MusteriBul.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(352, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 480);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(835, 198);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // Lbl_MusteriTaksit
            // 
            this.Lbl_MusteriTaksit.AutoSize = true;
            this.Lbl_MusteriTaksit.Location = new System.Drawing.Point(62, 358);
            this.Lbl_MusteriTaksit.Name = "Lbl_MusteriTaksit";
            this.Lbl_MusteriTaksit.Size = new System.Drawing.Size(42, 13);
            this.Lbl_MusteriTaksit.TabIndex = 0;
            this.Lbl_MusteriTaksit.Text = "Taksit :";
            // 
            // Txt_MusteriTaksit
            // 
            this.Txt_MusteriTaksit.Location = new System.Drawing.Point(110, 351);
            this.Txt_MusteriTaksit.Name = "Txt_MusteriTaksit";
            this.Txt_MusteriTaksit.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriTaksit.TabIndex = 10;
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.BackColor = System.Drawing.Color.Thistle;
            this.Btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Location = new System.Drawing.Point(127, 431);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(75, 34);
            this.Btn_Guncelle.TabIndex = 14;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = false;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Lbl_MusteriKalanOdeme
            // 
            this.Lbl_MusteriKalanOdeme.AutoSize = true;
            this.Lbl_MusteriKalanOdeme.Location = new System.Drawing.Point(27, 384);
            this.Lbl_MusteriKalanOdeme.Name = "Lbl_MusteriKalanOdeme";
            this.Lbl_MusteriKalanOdeme.Size = new System.Drawing.Size(77, 13);
            this.Lbl_MusteriKalanOdeme.TabIndex = 0;
            this.Lbl_MusteriKalanOdeme.Text = "Kalan Ödeme :";
            // 
            // Txt_MusteriKalanOdeme
            // 
            this.Txt_MusteriKalanOdeme.Location = new System.Drawing.Point(110, 377);
            this.Txt_MusteriKalanOdeme.Name = "Txt_MusteriKalanOdeme";
            this.Txt_MusteriKalanOdeme.ReadOnly = true;
            this.Txt_MusteriKalanOdeme.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriKalanOdeme.TabIndex = 11;
            // 
            // Txt_MusteriNo
            // 
            this.Txt_MusteriNo.Location = new System.Drawing.Point(110, 30);
            this.Txt_MusteriNo.Name = "Txt_MusteriNo";
            this.Txt_MusteriNo.ReadOnly = true;
            this.Txt_MusteriNo.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriNo.TabIndex = 0;
            // 
            // Lbl_MusteriNo
            // 
            this.Lbl_MusteriNo.AutoSize = true;
            this.Lbl_MusteriNo.Location = new System.Drawing.Point(40, 38);
            this.Lbl_MusteriNo.Name = "Lbl_MusteriNo";
            this.Lbl_MusteriNo.Size = new System.Drawing.Size(64, 13);
            this.Lbl_MusteriNo.TabIndex = 0;
            this.Lbl_MusteriNo.Text = "Müşteri No :";
            // 
            // Txt_MusteriRandevu
            // 
            this.Txt_MusteriRandevu.Location = new System.Drawing.Point(110, 403);
            this.Txt_MusteriRandevu.Name = "Txt_MusteriRandevu";
            this.Txt_MusteriRandevu.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriRandevu.TabIndex = 12;
            // 
            // DateT_DogumT
            // 
            this.DateT_DogumT.Location = new System.Drawing.Point(110, 108);
            this.DateT_DogumT.Name = "DateT_DogumT";
            this.DateT_DogumT.Size = new System.Drawing.Size(169, 20);
            this.DateT_DogumT.TabIndex = 3;
            // 
            // DateT_Tarih
            // 
            this.DateT_Tarih.Location = new System.Drawing.Point(110, 274);
            this.DateT_Tarih.Name = "DateT_Tarih";
            this.DateT_Tarih.Size = new System.Drawing.Size(169, 20);
            this.DateT_Tarih.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri T.C No :";
            // 
            // Txt_MusteriTC
            // 
            this.Txt_MusteriTC.Location = new System.Drawing.Point(110, 56);
            this.Txt_MusteriTC.MaxLength = 11;
            this.Txt_MusteriTC.Name = "Txt_MusteriTC";
            this.Txt_MusteriTC.Size = new System.Drawing.Size(169, 20);
            this.Txt_MusteriTC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Adresi :";
            // 
            // Txt_MusteriAdres
            // 
            this.Txt_MusteriAdres.Location = new System.Drawing.Point(110, 134);
            this.Txt_MusteriAdres.Multiline = true;
            this.Txt_MusteriAdres.Name = "Txt_MusteriAdres";
            this.Txt_MusteriAdres.Size = new System.Drawing.Size(169, 51);
            this.Txt_MusteriAdres.TabIndex = 4;
            // 
            // Btn_TumMusteriler
            // 
            this.Btn_TumMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_TumMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_TumMusteriler.Location = new System.Drawing.Point(497, 432);
            this.Btn_TumMusteriler.Name = "Btn_TumMusteriler";
            this.Btn_TumMusteriler.Size = new System.Drawing.Size(148, 33);
            this.Btn_TumMusteriler.TabIndex = 19;
            this.Btn_TumMusteriler.Text = "Tüm Müşterilerin Listesi";
            this.Btn_TumMusteriler.UseVisualStyleBackColor = false;
            this.Btn_TumMusteriler.Click += new System.EventHandler(this.Btn_TumMusteriler_Click);
            // 
            // Btn_MusteriListele
            // 
            this.Btn_MusteriListele.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_MusteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_MusteriListele.Location = new System.Drawing.Point(349, 432);
            this.Btn_MusteriListele.Name = "Btn_MusteriListele";
            this.Btn_MusteriListele.Size = new System.Drawing.Size(127, 34);
            this.Btn_MusteriListele.TabIndex = 20;
            this.Btn_MusteriListele.Text = "Tüm Kayıtları Listele";
            this.Btn_MusteriListele.UseVisualStyleBackColor = false;
            this.Btn_MusteriListele.Click += new System.EventHandler(this.Btn_MusteriListele_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Location = new System.Drawing.Point(208, 432);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(75, 34);
            this.Btn_Sil.TabIndex = 22;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = false;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 690);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_MusteriListele);
            this.Controls.Add(this.Btn_TumMusteriler);
            this.Controls.Add(this.Txt_MusteriAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_MusteriTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateT_Tarih);
            this.Controls.Add(this.DateT_DogumT);
            this.Controls.Add(this.Txt_MusteriRandevu);
            this.Controls.Add(this.Lbl_MusteriNo);
            this.Controls.Add(this.Txt_MusteriNo);
            this.Controls.Add(this.Txt_MusteriKalanOdeme);
            this.Controls.Add(this.Lbl_MusteriKalanOdeme);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Txt_MusteriTaksit);
            this.Controls.Add(this.Lbl_MusteriTaksit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_MusteriBul);
            this.Controls.Add(this.Lbl_MusteriDHatirlatma);
            this.Controls.Add(this.Lbl_MusteriDogumT);
            this.Controls.Add(this.Btn_Bul);
            this.Controls.Add(this.RadioBtn_MusteriTel);
            this.Controls.Add(this.RadioBtn_MusteriAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_MusteriBilgileri);
            this.Controls.Add(this.Txt_MusteriToplamTutar);
            this.Controls.Add(this.Lbl_MusteriToplamTutar);
            this.Controls.Add(this.Btn_Kaydet);
            this.Controls.Add(this.Txt_MusteriOdeme);
            this.Controls.Add(this.Lbl_MusteriOdeme);
            this.Controls.Add(this.Txt_MusteriIslem);
            this.Controls.Add(this.Lbl_MusteriRandevu);
            this.Controls.Add(this.Lbl_MusteriTarih);
            this.Controls.Add(this.Lbl_MusteriIslem);
            this.Controls.Add(this.Txt_MusteriTel);
            this.Controls.Add(this.Txt_MusteriAdSoyad);
            this.Controls.Add(this.Lbl_MusteriTel);
            this.Controls.Add(this.Lbl_MusteriAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blush Beauty Studio Müşteri Takibi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_MusteriAd;
        private System.Windows.Forms.Label Lbl_MusteriTel;
        private System.Windows.Forms.TextBox Txt_MusteriAdSoyad;
        private System.Windows.Forms.TextBox Txt_MusteriTel;
        private System.Windows.Forms.Label Lbl_MusteriIslem;
        private System.Windows.Forms.Label Lbl_MusteriTarih;
        private System.Windows.Forms.Label Lbl_MusteriRandevu;
        private System.Windows.Forms.TextBox Txt_MusteriIslem;
        private System.Windows.Forms.Label Lbl_MusteriOdeme;
        private System.Windows.Forms.TextBox Txt_MusteriOdeme;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.Label Lbl_MusteriToplamTutar;
        private System.Windows.Forms.TextBox Txt_MusteriToplamTutar;
        private System.Windows.Forms.Label Lbl_MusteriBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioBtn_MusteriAdi;
        private System.Windows.Forms.RadioButton RadioBtn_MusteriTel;
        private System.Windows.Forms.Button Btn_Bul;
        private System.Windows.Forms.Label Lbl_MusteriDogumT;
        private System.Windows.Forms.Label Lbl_MusteriDHatirlatma;
        private System.Windows.Forms.TextBox Txt_MusteriBul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Lbl_MusteriTaksit;
        private System.Windows.Forms.TextBox Txt_MusteriTaksit;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Label Lbl_MusteriKalanOdeme;
        private System.Windows.Forms.TextBox Txt_MusteriKalanOdeme;
        private System.Windows.Forms.TextBox Txt_MusteriNo;
        private System.Windows.Forms.Label Lbl_MusteriNo;
        private System.Windows.Forms.TextBox Txt_MusteriRandevu;
        private System.Windows.Forms.DateTimePicker DateT_DogumT;
        private System.Windows.Forms.DateTimePicker DateT_Tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_MusteriTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_MusteriAdres;
        private System.Windows.Forms.Button Btn_TumMusteriler;
        private System.Windows.Forms.Button Btn_MusteriListele;
        private System.Windows.Forms.Button Btn_Sil;
    }
}

