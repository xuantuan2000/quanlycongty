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
    public partial class frm_HangHoa : Form
    {
        LopDungChung lopchung;
        public frm_HangHoa()
        {
            lopchung = new LopDungChung();
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
     
            string sqlthem = "Insert into HANGHOA values('" +txt_mshh.Text + "', '" + txt_tenhang.Text + "','" + dateTimePicker_ngaynhaphang.Value + "','" + txt_giaban.Text+"','" + cb_mathang.SelectedValue + "','" + lb_xuatxu.SelectedValue + "')";          
            try
            {
                int ketqua = lopchung.LoadNonquery(sqlthem);
                if (ketqua >= 1)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Lỗi try");
            }
            catch 
            {
                MessageBox.Show("Lỗi catch, lỗi sql");
            }
            
            loadDataGridView();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            
            string sqlSua = "update HANGHOA set MAHH = '" + txt_mshh.Text + "', TENHH = '"+txt_tenhang.Text+"', NGAYNHAPHANG = '" + dateTimePicker_ngaynhaphang.Value +  "', GIABAN= '"+txt_giaban.Text+"', MAHH='"+cb_mathang.SelectedValue+"', MAQG = '"+lb_xuatxu.SelectedValue+"', where MAHH = '" + txt_mshh.Text + "'";
            
            try
            {
                int ketqua = lopchung.LoadNonquery(sqlSua);
                if (ketqua >= 1)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Chưa có mã");
            }
            catch 
            {
                MessageBox.Show("Lỗi câu lệnh sql");
            }
           
            loadDataGridView();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            string sqlXoa = "delete from HANGHOA where MAHH = '" + txt_mshh.Text + "'";
            
            try
            {
                int ketqua = lopchung.LoadNonquery(sqlXoa);
                if (ketqua >= 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Chưa có mã");
            }
            catch 
            {
                MessageBox.Show("Lỗi câu lệnh sql");
            }
            
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            
            string sqlLoadHH = "select * from HANGHOA";
                       
            dataGridView_hh.DataSource = lopchung.LoadDaTa(sqlLoadHH);
        }

        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            Load_Combobox_MMH();
            loadDataGridView();
            Load_lb_XX();
        }

        private void dataGridView_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cb_mathang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string mamh = cb_mathang.SelectedValue.ToString();
            string sqlmamh = "select * from HANGHOA where MAMH='" + mamh + "'";
            
            dataGridView_hh.DataSource = lopchung.LoadDaTa(sqlmamh);
        }
        private void lb_xuatxu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maQG = cb_mathang.SelectedValue.ToString();
            string sqlmaQG = "select * from HANGHOA where MAMH='" + maQG + "'";
            dataGridView_hh.DataSource = lopchung.LoadDaTa(sqlmaQG);
        }
        private void Load_Combobox_MMH()
        {            
            string sqlLoadMMH = "select * from MATHANG";
            
            cb_mathang.DataSource = lopchung.LoadDaTa(sqlLoadMMH);
            cb_mathang.DisplayMember = "TENMH";
            cb_mathang.ValueMember = "MAMH";
        }
        private void Load_lb_XX()
        {
            string sqlLoadXX = "select * from XUATXU";

            lb_xuatxu.DataSource = lopchung.LoadDaTa(sqlLoadXX);
            lb_xuatxu.DisplayMember = "TENQG";
            lb_xuatxu.ValueMember = "MAQG";
        }

        private void dataGridView_hh_CellClick(object sender, DataGridViewCellEventArgs e)
        {                    
            txt_mshh.Text = dataGridView_hh.CurrentRow.Cells["MAHH"].Value.ToString();
            txt_tenhang.Text = dataGridView_hh.CurrentRow.Cells["TENHH"].Value.ToString();
            dateTimePicker_ngaynhaphang.Text = dataGridView_hh.CurrentRow.Cells["NGAYNHAPHANG"].Value.ToString();
            txt_giaban.Text = dataGridView_hh.CurrentRow.Cells["GIABAN"].Value.ToString();
            cb_mathang.SelectedValue = dataGridView_hh.CurrentRow.Cells["MAMH"].Value.ToString();
            lb_xuatxu.SelectedValue = dataGridView_hh.CurrentRow.Cells["MAQG"].Value.ToString();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_mshh.Text = "";
            txt_tenhang.Text = "";
            txt_giaban.Text = "";
            loadDataGridView();
        }

        private void rb_tang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_hh.Sort(dataGridView_hh.Columns[2], ListSortDirection.Ascending);
        }

        private void rb_giam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_hh.Sort(dataGridView_hh.Columns[2], ListSortDirection.Descending);
        }
    }
}
