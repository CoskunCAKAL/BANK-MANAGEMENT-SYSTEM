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
using System.Data.OleDb;

namespace Prolab2._3
{
    public partial class formana : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1CU8DQ5;Initial Catalog=prolab2.3;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        public formana()
        {
            InitializeComponent();
        }
        

        private void frmana_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            SqlDataReader read;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from döviz";
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox3.Items.Add(read[0].ToString());
            }
            baglanti.Close();
            ////////////////////////////////////////////////////////////////////////
            comboBox4.Items.Clear();
            
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from hesaplar";
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox4.Items.Add(read[0].ToString());
            }
            baglanti.Close();
            /////////////////////////////////////////////////////////////////////////
            comboBox5.Items.Clear();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from hesaplar";
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox5.Items.Add(read[0].ToString());
            }
            baglanti.Close();
            /////////////////////////////////////////////////////////////////////////
            comboBox2.Items.Clear();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from hesaplar";
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read[0].ToString());
            }
            baglanti.Close();
            /////////////////////////////////////////////////////////////////////////
            comboBox1.Items.Clear();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from hesaplar";
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read[0].ToString());
            }
            baglanti.Close();
            /////////////////////////////////////////////////////////////////////////
            comboBox2.Items.Clear();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from hesaplar";
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read[0].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıfrm kfrm= new kullanıcıfrm();
            kfrm.yenihesap(textBox3, bky, comboBox3,textBox11);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcıfrm kfrm = new kullanıcıfrm();
            kfrm.Paracek(comboBox5, textBox9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanıcıfrm kfrm = new kullanıcıfrm();
            kfrm.Parayatır(comboBox4, textBox8);
        }
    }
}
