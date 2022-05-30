using OneOf.Types;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2._3
{
    internal class kullanıcıfrm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1CU8DQ5;Initial Catalog=prolab2.3;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        formana ana = new formana();
        public SqlDataReader kulanıcı(TextBox tcno, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from müsteri where tcno= '" + tcno.Text + "' ";
            read = komut.ExecuteReader();
            if (read.Read())
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    ana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz.", "Hata");

                }

            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
            }
            baglanti.Close();
            return read;
        }
        public void yenikullanıcı(TextBox adsoyad, TextBox telefon, TextBox tcno, TextBox eposta, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = " insert into müsteri values('" + adsoyad.Text + "','" + telefon.Text + "','" + tcno.Text + "','" + eposta.Text + "','" + sifre.Text + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı.");
        }
        public void yenihesap(TextBox hesapadı, TextBox bakiye, ComboBox döviztürü,TextBox müsterino)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = " insert into hesaplar values('" + hesapadı.Text + "','" + bakiye.Text + "','" + döviztürü.Text + "','"+müsterino.Text+"' )";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı.");
        }
        public void hesapsil(ComboBox hesapno)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut = new SqlCommand("select * from hesaplar where hesapno='" + hesapno.Text + "' ", baglanti);
            read = komut.ExecuteReader();
            int anaBakiye = 0;
            if (read.Read())
            {
                anaBakiye = Convert.ToInt32(read["bakiye"]);
            }
            baglanti.Close();

            baglanti.Open();
            if(anaBakiye > 0)
            {
                MessageBox.Show("Lütfen hesapda bulunan bakiyenizi tamamen boşaltıp tekrar deneyiniz");
            }
            else
            {
                komut = new SqlCommand("delete from hesaplar where hesapno= '" + hesapno.Text + "' ", baglanti);
                komut.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Hesap silindi.");

            }
            baglanti.Close();   
            
        }
        public void Paracek(ComboBox hesapno, TextBox bakiye)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from hesaplar where hesapno= '" + hesapno.Text + "' ", baglanti);
            read = komut.ExecuteReader();
            int anaBakiye = 0;
            if (read.Read())
            {
               anaBakiye = Convert.ToInt32(read["bakiye"]);
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
                return;
            }
            baglanti.Close();
            
            baglanti.Open();
            if (anaBakiye >= Convert.ToInt32(bakiye.Text))
            {
                SqlCommand cmd = new SqlCommand("Update hesaplar Set bakiye = convert(nvarchar(50),CONVERT(int,bakiye) - "+Convert.ToInt32(bakiye.Text)+") Where hesapno = " + hesapno.Text, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hesabınızdan para çekildi");

            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz bulunmamaktadır.", "Hata");

            }
            baglanti.Close();

        }
        public void Parayatır(ComboBox hesapno, TextBox bakiye)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from hesaplar where hesapno= '" + hesapno.Text + "' ", baglanti);
            read = komut.ExecuteReader();
            int anaBakiye = 0;
            if (read.Read())
            {
                anaBakiye = Convert.ToInt32(read["bakiye"]);
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
                return;
            }
            baglanti.Close();

            baglanti.Open();
            
            
                SqlCommand cmd = new SqlCommand("Update hesaplar Set bakiye = convert(nvarchar(50),CONVERT(int,bakiye) + " + Convert.ToInt32(bakiye.Text) + ") Where hesapno = " + hesapno.Text, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hesabınıza para yatırıldı");

            
            
            baglanti.Close();

        }




    }
}
