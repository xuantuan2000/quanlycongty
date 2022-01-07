using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLCongTy_DoAn
{
    public partial class frm_NhanVien : Form
    {
        LopDungChung lopchung;
        public frm_NhanVien()
        {
            lopchung = new LopDungChung();
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataNV();
            Load_cbMH();
        }
        public void LoadDataNV()
        {
            string sqlLoadNV = "select * from NHANVIEN";
            dataGridView_nv.DataSource = lopchung.LoadDaTa(sqlLoadNV);
        }
        private void Load_cbMH()
        {
            string sqlLoadMH = "select * from MATHANG";
            cb_mathang.DataSource = lopchung.LoadDaTa(sqlLoadMH);
            cb_mathang.DisplayMember = "TENMH";
            cb_mathang.ValueMember = "MAMH";
        }
        private void cb_MH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MAMH = cb_mathang.SelectedValue.ToString();
            string sqlmaMH = "select *from NHANVIEN where MAMH = '" + MAMH + "' ";
            dataGridView_nv.DataSource = lopchung.LoadDaTa(sqlmaMH);
        }
        private void dataGridView_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_msnv.Text = dataGridView_nv.CurrentRow.Cells["MANV"].Value.ToString();
            txt_hoten.Text = dataGridView_nv.CurrentRow.Cells["HOTEN"].Value.ToString();
            dateTimePicker_ngaysinh.Text = dataGridView_nv.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_diachi.Text = dataGridView_nv.CurrentRow.Cells["DIACHI"].Value.ToString();
            cb_mathang.SelectedValue = dataGridView_nv.CurrentRow.Cells["MAMH"].Value.ToString();
            txt_hinhanh.Text = dataGridView_nv.CurrentRow.Cells["HINHANH"].Value.ToString();
            pictureBox1.ImageLocation = @"C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\HINHANH\" + txt_hinhanh.Text;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sqlThem = "Insert into NHANVIEN values('" + txt_msnv.Text + "', '" + txt_hoten.Text + "', '" + dateTimePicker_ngaysinh.Value + "', '" + txt_diachi.Text + "', '" + cb_mathang.SelectedValue + "', '" + txt_hinhanh.Text + "')";
            string sqlTimkiem = "select * from NHANVIEN where MANV LIKE '% " + txt_timkiem.Text + " %' or HOTEN LIKE '%" + txt_hoten + "%'";

            try
            {
                int ketqua = lopchung.LoadNonquery(sqlThem);
                if (ketqua >= 1)
                {
                    MessageBox.Show("Thêm thành công");
                    pictureBox1.Image.Save(@"C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\Form_QLCongTy_DoAn\HINHANH\" + txt_hinhanh.Text);
                }
                else MessageBox.Show("Thêm thất bại");
            }
            catch
            {
                MessageBox.Show("Lỗi SQL");
            }
            LoadDataNV();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string sqlCapnhat = "update NHANVIEN set MANV = '" + txt_msnv.Text + "', HOTEN = '" + txt_hoten.Text + "', NGAYSINH = '" + dateTimePicker_ngaysinh.Value + "', DIACHI = '" + txt_diachi.Text + "', MAMH = '" + cb_mathang.SelectedValue + "', HINHANH = '" + txt_hinhanh.Text + "'  where MANV = '" + txt_msnv.Text + "'";

            try
            {
                int ketqua = lopchung.LoadNonquery(sqlCapnhat);
                if (ketqua >= 1)
                {
                    MessageBox.Show("Cập Nhật thành công");
                    pictureBox1.Image.Save(@"C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\Form_QLCongTy_DoAn\HINHANH\" + txt_hinhanh.Text);
                }
                else MessageBox.Show("Cập nhật thất bại");
            }
            catch
            {
                MessageBox.Show("Lỗi SQL");
            }

            LoadDataNV();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from NHANVIEN where MANV = '" + txt_msnv.Text + "'  ";

            try
            {
                int ketqua = lopchung.LoadNonquery(sqlXoa);
                if (ketqua >= 1)
                {
                    MessageBox.Show("Xóa thành công");
                    File.Delete(@"C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\Form_QLCongTy_DoAn\HINHANH\" + txt_hinhanh.Text);
                }
                else MessageBox.Show("Không tồn tại mã này");
            }
            catch
            {
                MessageBox.Show("Lỗi SQL");
            }
            LoadDataNV();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_msnv.Text = "";
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txt_hinhanh.Text = "";
            LoadDataNV();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string sqlTim = "select * from NHANVIEN where MANV LIKE '%" + txt_timkiem.Text + "%' or HOTEN LIKE '%" + txt_timkiem.Text + "%'";
            dataGridView_nv.DataSource = lopchung.LoadDaTa(sqlTim);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Tất cả ảnh|*.*|File jpg|*.jpg| File png|*.png";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OFD.FileName);
            }
        }
    }
}
