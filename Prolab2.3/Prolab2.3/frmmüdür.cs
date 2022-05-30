using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2._3
{
    internal class frmmüdür
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1CU8DQ5;Initial Catalog=prolab2.3;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        müdürekranı müdür = new müdürekranı();
        public SqlDataReader kulanıcı(TextBox tcno, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from müdür where tcno= '" + tcno.Text + "' ";
            read = komut.ExecuteReader();
            if (read.Read())
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    müdür.ShowDialog();
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
        
    }
}
