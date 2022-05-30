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
    public partial class girismüdür : Form
    {
        public girismüdür()
        {
            InitializeComponent();
        }

        private void tcnotxt_TextChanged(object sender, EventArgs e)
        {

        }
        frmmüdür m = new frmmüdür();
        private void müdürgirisbtn_Click(object sender, EventArgs e)
        {
            m.kulanıcı(tcnotxt, sifretxt);
        }
    }
}
