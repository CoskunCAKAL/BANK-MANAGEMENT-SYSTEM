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

        kullanýcýfrm kfrm = new kullanýcýfrm(); 
        private void button1_Click(object sender, EventArgs e)
        {
            kfrm.kulanýcý(tcnotxt,sifretxt);    
        }

        private void ekletxt_Click(object sender, EventArgs e)
        {
            kfrm.yenikullanýcý(txtad, kyttlfn, kyttcn, kytpst, kytsfr);
        }
        
      

        private void müdürgiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            girismüdür müdür = new girismüdür();
            müdür.ShowDialog(); 
        }

        private void temsilcigiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            giristemsilci temsilci = new giristemsilci();
            temsilci.ShowDialog();  
        }
    }
}