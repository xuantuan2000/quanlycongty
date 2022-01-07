using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLCongTy_DoAn
{
    class LopDungChung
    {
        public int LoadNonquery(string sql)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\QUANLYCONGTY.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            return ketqua;
        }
        public object LoadScalar(string sql)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\QUANLYCONGTY.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public DataTable LoadDaTa(string sql)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Đồ Án Nhóm\Form_QLCongTy_DoAn\QUANLYCONGTY.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
