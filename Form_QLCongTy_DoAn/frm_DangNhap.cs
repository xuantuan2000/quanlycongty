using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLCongTy_DoAn
{
    public partial class frm_DangNhap : Form
    {
        LopDungChung lopchung;
        public frm_DangNhap()
        {
            lopchung = new LopDungChung();
            InitializeComponent();
        }
        int dem = 0;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\QUANLYCONGTY.mdf;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "select *from TAIKHOAN where TENTK = '" + txt_tendangnhap.Text + "' and MATKHAU = '" + txt_matkhau.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    frm_Menu KH = new frm_Menu();
                    KH.Show();
                    KH.SetDesktopLocation(300, 80);
                    this.Hide();
                }
                else
                {
                    dem++;
                    lb_canhbao.Text = "Cảnh báo: Bạn đã nhập sai " + dem + " lần!";
                }
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần, thoát chương trình!", "Thông báo!");
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi Catch");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không?", "Thoát đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_dangnhap;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(350, 130);
        }
    }
}
