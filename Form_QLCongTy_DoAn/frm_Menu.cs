using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLCongTy_DoAn
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien NV = new frm_NhanVien();
            NV.MdiParent = this;
            NV.Show();
        }

        private void quảnLíHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HangHoa HH = new frm_HangHoa();
            HH.MdiParent = this;
            HH.Show();
        }
    }
}
