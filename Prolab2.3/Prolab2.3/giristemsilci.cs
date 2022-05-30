using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2._3
{
    public partial class giristemsilci : Form
    {
        public giristemsilci()
        {
            InitializeComponent();
        }
        temsilcifrm t = new temsilcifrm();
        private void button1_Click(object sender, EventArgs e)
        {
            t.kulanıcı(tcnotxt, sifretxt);
        }
    }
}
