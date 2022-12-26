using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerçekÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbTuftechElektronik; user ID=postgres; password=Halil29578797846");
        private void btListele_Click(object sender, EventArgs e)
        {

            if (Listele.Text == "urunler")
            {
                string sorgu = "select * from urunler";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "adres")
            {
                string sorgu = "select * from adres";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "ilce")
            {
                string sorgu = "select * from ilce";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "iletisim_bilgileri")
            {
                string sorgu = "select * from iletisim_bilgileri";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "kargo_sirketi")
            {
                string sorgu = "select * from kargo_sirketi";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "musteri")
            {
                string sorgu = "select * from musteri";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "odeme_bilgileri")
            {
                string sorgu = "select * from odeme_bilgileri";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "sehir")
            {
                string sorgu = "select * from sehir";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "siparis")
            {
                string sorgu = "select * from siparis";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "tedarik_liste")
            {
                string sorgu = "select * from tedarik_liste";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "tedarikciler")
            {
                string sorgu = "select * from tedarikciler";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "ulke")
            {
                string sorgu = "select * from ulke";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "urun_liste")
            {
                string sorgu = "select * from urun_liste";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "urun_ozellikleri")
            {
                string sorgu = "select * from urun_ozellikleri";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (Listele.Text == "teslimat_bilgileri")
            {
                string sorgu = "select * from teslimat_bilgileri";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btEkle_Click(object sender, EventArgs e)
        {
            if (Listele.Text == "adres")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into adres (adres_no,ulke_no,musteri_no) values (@p1,@p2,@p3)", baglanti);
                komut1.Parameters.AddWithValue("@p1", Deger1.Text);
                komut1.Parameters.AddWithValue("@p2", Deger2.Text);
                komut1.Parameters.AddWithValue("@p3", Deger3.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "ilce")
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into ilce (ilce_no,ilce_adi,mahalle_adi,sokak_adi,daire_no,ek_bilgi) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut2.Parameters.AddWithValue("@p1", Deger1.Text);
                komut2.Parameters.AddWithValue("@p2", Deger2.Text);
                komut2.Parameters.AddWithValue("@p3", Deger3.Text);
                komut2.Parameters.AddWithValue("@p4", Deger4.Text);
                komut2.Parameters.AddWithValue("@p5", Deger5.Text);
                komut2.Parameters.AddWithValue("@p6", Deger6.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "iletisim_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("insert into iletisim_bilgileri (iletisim_no,telefon_no,adres_no,eposta) values (@p1,@p2,@p3,@p4)", baglanti);
                komut3.Parameters.AddWithValue("@p1", Deger1.Text);
                komut3.Parameters.AddWithValue("@p2", Deger2.Text);
                komut3.Parameters.AddWithValue("@p3", Deger3.Text);
                komut3.Parameters.AddWithValue("@p4", Deger4.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "kargo_sirketi")
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("insert into kargo_sirketi (kargosirketi_no,sirket_adi,teslimat_hizi,kargo_tutari) values (@p1,@p2,@p3,@p4)", baglanti);
                komut4.Parameters.AddWithValue("@p1", Deger1.Text);
                komut4.Parameters.AddWithValue("@p2", Deger2.Text);
                komut4.Parameters.AddWithValue("@p3", Deger3.Text);
                komut4.Parameters.AddWithValue("@p4", Deger4.Text);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "musteri")
            {
                baglanti.Open();
                NpgsqlCommand komut5 = new NpgsqlCommand("insert into musteri (musteri_no,ad_soyad,iletisim_no,odeme_no,siparis_no,adres_no) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut5.Parameters.AddWithValue("@p1", Deger1.Text);
                komut5.Parameters.AddWithValue("@p2", Deger2.Text);
                komut5.Parameters.AddWithValue("@p3", Deger3.Text);
                komut5.Parameters.AddWithValue("@p4", Deger4.Text);
                komut5.Parameters.AddWithValue("@p5", Deger5.Text);
                komut5.Parameters.AddWithValue("@p6", Deger6.Text);
                komut5.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "odeme_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut6 = new NpgsqlCommand("insert into odeme_bilgileri (odeme_no,musteri_no,odeme_yontemi,toplam_tutar,odeme_tarihi) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut6.Parameters.AddWithValue("@p1", Deger1.Text);
                komut6.Parameters.AddWithValue("@p2", Deger2.Text);
                komut6.Parameters.AddWithValue("@p3", Deger3.Text);
                komut6.Parameters.AddWithValue("@p4", Deger4.Text);
                komut6.Parameters.AddWithValue("@p5", Deger5.Text);
                komut6.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "sehir")
            {
                baglanti.Open();
                NpgsqlCommand komut7 = new NpgsqlCommand("insert into sehir (sehir_no,sehir_ad,ilce_no) values (@p1,@p2,@p3)", baglanti);
                komut7.Parameters.AddWithValue("@p1", Deger1.Text);
                komut7.Parameters.AddWithValue("@p2", Deger2.Text);
                komut7.Parameters.AddWithValue("@p3", Deger3.Text);
                komut7.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "siparis")
            {
                baglanti.Open();
                NpgsqlCommand komut8 = new NpgsqlCommand("insert into siparis (siparis_no,müsteri_no,liste_no,siparis_tutar,siparis_tarihi,teslimat_no) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut8.Parameters.AddWithValue("@p1", Deger1.Text);
                komut8.Parameters.AddWithValue("@p2", Deger2.Text);
                komut8.Parameters.AddWithValue("@p3", Deger3.Text);
                komut8.Parameters.AddWithValue("@p4", Deger4.Text);
                komut8.Parameters.AddWithValue("@p5", Deger5.Text);
                komut8.Parameters.AddWithValue("@p6", Deger6.Text);
                komut8.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "tedarik_liste")
            {
                baglanti.Open();
                NpgsqlCommand komut9 = new NpgsqlCommand("insert into tedarik_liste (eksikliste_no,tedarikci_no,eksik_urun,miktar) values (@p1,@p2,@p3,@p4)", baglanti);
                komut9.Parameters.AddWithValue("@p1", Deger1.Text);
                komut9.Parameters.AddWithValue("@p2", Deger2.Text);
                komut9.Parameters.AddWithValue("@p3", Deger3.Text);
                komut9.Parameters.AddWithValue("@p4", Deger4.Text);
                komut9.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "tedarikciler")
            {
                baglanti.Open();
                NpgsqlCommand komut10 = new NpgsqlCommand("insert into tedarikciler (tedarikci_no,tedarikci_adi,iletisim_no,eksikliste_no) values (@p1,@p2,@p3,@p4)", baglanti);
                komut10.Parameters.AddWithValue("@p1", Deger1.Text);
                komut10.Parameters.AddWithValue("@p2", Deger2.Text);
                komut10.Parameters.AddWithValue("@p3", Deger3.Text);
                komut10.Parameters.AddWithValue("@p4", Deger4.Text);
                komut10.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "teslimat_bilgiler")
            {
                baglanti.Open();
                NpgsqlCommand komut11 = new NpgsqlCommand("insert into teslimat_bilgileri (teslimat_no,siparis_no,kargosirketi_no,adres_no) values (@p1,@p2,@p3,@p4)", baglanti);
                komut11.Parameters.AddWithValue("@p1", Deger1.Text);
                komut11.Parameters.AddWithValue("@p2", Deger2.Text);
                komut11.Parameters.AddWithValue("@p3", Deger3.Text);
                komut11.Parameters.AddWithValue("@p4", Deger4.Text);
                komut11.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "ulke")
            {
                baglanti.Open();
                NpgsqlCommand komut12 = new NpgsqlCommand("insert into ulke (ulke_no,ulke_ad,sehir_no) values (@p1,@p2,@p3)", baglanti);
                komut12.Parameters.AddWithValue("@p1", Deger1.Text);
                komut12.Parameters.AddWithValue("@p2", Deger2.Text);
                komut12.Parameters.AddWithValue("@p3", Deger3.Text);
                komut12.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "urun_liste")
            {
                baglanti.Open();
                NpgsqlCommand komut13 = new NpgsqlCommand("insert into urun_liste (liste_no,siparis_no,urun_no) values (@p1,@p2,@p3)", baglanti);
                komut13.Parameters.AddWithValue("@p1", Deger1.Text);
                komut13.Parameters.AddWithValue("@p2", Deger2.Text);
                komut13.Parameters.AddWithValue("@p3", Deger3.Text);
                komut13.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "urun_ozellikleri")
            {
                baglanti.Open();
                NpgsqlCommand komut14 = new NpgsqlCommand("insert into urun_ozellikleri (urun_no,stok_miktari,agirlik,kategori,renk,boyutlari) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut14.Parameters.AddWithValue("@p1", Deger1.Text);
                komut14.Parameters.AddWithValue("@p2", Deger2.Text);
                komut14.Parameters.AddWithValue("@p3", Deger3.Text);
                komut14.Parameters.AddWithValue("@p4", Deger4.Text);
                komut14.Parameters.AddWithValue("@p5", Deger5.Text);
                komut14.Parameters.AddWithValue("@p6", Deger6.Text);
                komut14.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "urunler")
            {
                baglanti.Open();
                NpgsqlCommand komut15 = new NpgsqlCommand("insert into urunler (urun_no,urun_adi,tedarikci_no,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut15.Parameters.AddWithValue("@p1", Deger1.Text);
                komut15.Parameters.AddWithValue("@p2", Deger2.Text);
                komut15.Parameters.AddWithValue("@p3", Deger3.Text);
                komut15.Parameters.AddWithValue("@p4", double.Parse(Deger4.Text));
                komut15.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btSil_Click(object sender, EventArgs e)
        {
            if (Listele.Text == "adres")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from adres where adres_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "ilce")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from ilce where ilce_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "iletisim_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from iletisim_bilgileri where iletisim_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "kargo_sirketi")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from kargo_sirketi where kargo_sirketi_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "musteri")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from musteri where musteri_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "odeme_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from odeme_bilgileri where odeme_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "sehir")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from sehir where sehir_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "siparis")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from siparis where siparis_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "tedarik_liste")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from tedarik_liste where eksikliste_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "tedarikciler")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from tedarikciler where tedarikci_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "teslimat_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from teslimat_bilgileri where teslimat_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "ulke")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from ulke where ulke_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "urun_liste")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from urun_liste where liste_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "urun_ozellikleri")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from urun_ozellikleri where urun_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Listele.Text == "urunler")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("delete from urunler where urun_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", SilinecekDeger.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deger silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDegistir_Click(object sender, EventArgs e)
        {
            if (Listele.Text == "adres")
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("update adres set ulke_no=@p2,musteri_no=@p3 where adres_no=@p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", Deger1.Text);
                komut1.Parameters.AddWithValue("@p2", Deger2.Text);
                komut1.Parameters.AddWithValue("@p3", Deger3.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "ilce")
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("update ilce set ilce_adi=@p2,mahalle_adi=@p3,sokak_adi=@p4,daire_no=@p5,ek_bilgi=@p6 where ilce_no=@p1 ", baglanti);
                komut2.Parameters.AddWithValue("@p1", Deger1.Text);
                komut2.Parameters.AddWithValue("@p2", Deger2.Text);
                komut2.Parameters.AddWithValue("@p3", Deger3.Text);
                komut2.Parameters.AddWithValue("@p4", Deger4.Text);
                komut2.Parameters.AddWithValue("@p5", Deger5.Text);
                komut2.Parameters.AddWithValue("@p6", Deger6.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "iletisim_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update iletisim_bilgileri set telefon_no=@p2,adres_no=@p3,eposta=@p4 where iletisim_no=@p1 ", baglanti);
                komut3.Parameters.AddWithValue("@p1", Deger1.Text);
                komut3.Parameters.AddWithValue("@p2", Deger2.Text);
                komut3.Parameters.AddWithValue("@p3", Deger3.Text);
                komut3.Parameters.AddWithValue("@p4", Deger4.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "kargo_sirketi")
            {
                baglanti.Open();
                NpgsqlCommand komut4 = new NpgsqlCommand("update kargo_sirketi set sirket_adi=@p2,teslimat_hizi=@p3,kargo_tutari=@p4 where kargosirketi_no=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", Deger1.Text);
                komut4.Parameters.AddWithValue("@p2", Deger2.Text);
                komut4.Parameters.AddWithValue("@p3", Deger3.Text);
                komut4.Parameters.AddWithValue("@p4", Deger4.Text);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "musteri")
            {
                baglanti.Open();
                NpgsqlCommand komut5 = new NpgsqlCommand("update musteri set ad_soyad=@p2,iletisim_no=@p3,odeme_no=@p4,siparis_no=@p5,adres_no=@p6 where musteri_no=@p1", baglanti);
                komut5.Parameters.AddWithValue("@p1", Deger1.Text);
                komut5.Parameters.AddWithValue("@p2", Deger2.Text);
                komut5.Parameters.AddWithValue("@p3", Deger3.Text);
                komut5.Parameters.AddWithValue("@p4", Deger4.Text);
                komut5.Parameters.AddWithValue("@p5", Deger5.Text);
                komut5.Parameters.AddWithValue("@p6", Deger6.Text);
                komut5.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "odeme_bilgileri")
            {
                baglanti.Open();
                NpgsqlCommand komut6 = new NpgsqlCommand("update odeme_bilgileri set musteri_no=@p2,odeme_yontemi=@p3,toplam_tutar=@p4,odeme_tarihi=@p5 where odeme_no=@p1", baglanti);
                komut6.Parameters.AddWithValue("@p1", Deger1.Text);
                komut6.Parameters.AddWithValue("@p2", Deger2.Text);
                komut6.Parameters.AddWithValue("@p3", Deger3.Text);
                komut6.Parameters.AddWithValue("@p4", Deger4.Text);
                komut6.Parameters.AddWithValue("@p5", Deger5.Text);
                komut6.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "sehir")
            {
                baglanti.Open();
                NpgsqlCommand komut7 = new NpgsqlCommand("update sehir set sehir_ad=@p2,ilce_no=@p3 where sehir_no=@p1", baglanti);
                komut7.Parameters.AddWithValue("@p1", Deger1.Text);
                komut7.Parameters.AddWithValue("@p2", Deger2.Text);
                komut7.Parameters.AddWithValue("@p3", Deger3.Text);
                komut7.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "siparis")
            {
                baglanti.Open();
                NpgsqlCommand komut8 = new NpgsqlCommand("update siparis set müsteri_no=@p2,liste_no=@p3,siparis_tutar=@p4,siparis_tarihi=@p5,teslimat_no=@p6 where siparis_no=@p1", baglanti);
                komut8.Parameters.AddWithValue("@p1", Deger1.Text);
                komut8.Parameters.AddWithValue("@p2", Deger2.Text);
                komut8.Parameters.AddWithValue("@p3", Deger3.Text);
                komut8.Parameters.AddWithValue("@p4", Deger4.Text);
                komut8.Parameters.AddWithValue("@p5", Deger5.Text);
                komut8.Parameters.AddWithValue("@p6", Deger6.Text);
                komut8.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "tedarik_liste")
            {
                baglanti.Open();
                NpgsqlCommand komut9 = new NpgsqlCommand("update tedarik_liste set tedarikci_no=@p2,eksik_urun=@p3,miktar=@p4 where eksikliste_no=@p1", baglanti);
                komut9.Parameters.AddWithValue("@p1", Deger1.Text);
                komut9.Parameters.AddWithValue("@p2", Deger2.Text);
                komut9.Parameters.AddWithValue("@p3", Deger3.Text);
                komut9.Parameters.AddWithValue("@p4", Deger4.Text);
                komut9.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "tedarikciler")
            {
                baglanti.Open();
                NpgsqlCommand komut10 = new NpgsqlCommand("update tedarikciler set tedarikci_adi=@p2,iletisim_no=@p3,eksikliste_no=@p4 where tedarikci_no=@p1", baglanti);
                komut10.Parameters.AddWithValue("@p1", Deger1.Text);
                komut10.Parameters.AddWithValue("@p2", Deger2.Text);
                komut10.Parameters.AddWithValue("@p3", Deger3.Text);
                komut10.Parameters.AddWithValue("@p4", Deger4.Text);
                komut10.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "teslimat_bilgiler")
            {
                baglanti.Open();
                NpgsqlCommand komut11 = new NpgsqlCommand("update teslimat_bilgileri set siparis_no=@p2,kargosirketi_no=@p3,adres_no=@p4 where teslimat_no=@p1", baglanti);
                komut11.Parameters.AddWithValue("@p1", Deger1.Text);
                komut11.Parameters.AddWithValue("@p2", Deger2.Text);
                komut11.Parameters.AddWithValue("@p3", Deger3.Text);
                komut11.Parameters.AddWithValue("@p4", Deger4.Text);
                komut11.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "ulke")
            {
                baglanti.Open();
                NpgsqlCommand komut12 = new NpgsqlCommand("update ulke set ulke_ad=@p2,sehir_no=@p3 where ulke_no=@p1", baglanti);
                komut12.Parameters.AddWithValue("@p1", Deger1.Text);
                komut12.Parameters.AddWithValue("@p2", Deger2.Text);
                komut12.Parameters.AddWithValue("@p3", Deger3.Text);
                komut12.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler degisti!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "urun_liste")
            {
                baglanti.Open();
                NpgsqlCommand komut13 = new NpgsqlCommand("update urun_liste set siparis_no=@p2,urun_no=@p3 where liste_no=@p1", baglanti);
                komut13.Parameters.AddWithValue("@p1", Deger1.Text);
                komut13.Parameters.AddWithValue("@p2", Deger2.Text);
                komut13.Parameters.AddWithValue("@p3", Deger3.Text);
                komut13.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "urun_ozellikleri")
            {
                baglanti.Open();
                NpgsqlCommand komut14 = new NpgsqlCommand("update urun_ozellikleri set stok_miktari=@p2,agirlik=@p3,kategori=@p4,renk=@p5,boyutlari=@p6 where urun_no=@p1", baglanti);
                komut14.Parameters.AddWithValue("@p1", Deger1.Text);
                komut14.Parameters.AddWithValue("@p2", Deger2.Text);
                komut14.Parameters.AddWithValue("@p3", Deger3.Text);
                komut14.Parameters.AddWithValue("@p4", Deger4.Text);
                komut14.Parameters.AddWithValue("@p5", Deger5.Text);
                komut14.Parameters.AddWithValue("@p6", Deger6.Text);
                komut14.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Listele.Text == "urunler")
            {
                baglanti.Open();
                NpgsqlCommand komut15 = new NpgsqlCommand("update urunler set urun_adi=@p2,tedarikci_no=@p3,fiyat=@p4 where (urun_no=@p1", baglanti);
                komut15.Parameters.AddWithValue("@p1", Deger1.Text);
                komut15.Parameters.AddWithValue("@p2", Deger2.Text);
                komut15.Parameters.AddWithValue("@p3", Deger3.Text);
                komut15.Parameters.AddWithValue("@p4", double.Parse(Deger4.Text));
                komut15.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Degerler eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btreset_Click(object sender, EventArgs e)
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
    }
}
