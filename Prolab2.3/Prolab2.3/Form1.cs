using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;
namespace Prolab2._3
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        kullan�c�frm kfrm = new kullan�c�frm(); 
        private void button1_Click(object sender, EventArgs e)
        {
            kfrm.kulan�c�(tcnotxt,sifretxt);    
        }

        private void ekletxt_Click(object sender, EventArgs e)
        {
            kfrm.yenikullan�c�(txtad, kyttlfn, kyttcn, kytpst, kytsfr);
        }
        
      

        private void m�d�rgiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            girism�d�r m�d�r = new girism�d�r();
            m�d�r.ShowDialog(); 
        }

        private void temsilcigiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            giristemsilci temsilci = new giristemsilci();
            temsilci.ShowDialog();  
        }
    }
}