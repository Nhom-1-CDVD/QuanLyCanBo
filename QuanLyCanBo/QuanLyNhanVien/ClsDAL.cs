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
namespace QuanLyNhanVien
{
    class ClsDAL
    {
        ClsConnectDB cndb;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ClsDAL()
        {
            cndb = new ClsConnectDB();
        }

        // phuong thuc login user
        public bool RegisterUser(ClsUser us)
        {
            string sql = "usp_RegisterUser";
            SqlConnection con = cndb.getConnect();
            try
            {
                con.Open();
                var cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = us.Username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = us.password;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = us.Phone;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = us.Address;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
            
        }

        public bool LoginUser(ClsUser us)
        {
            string sql = "usp_LoginUser";
            SqlConnection con = cndb.getConnect(); 
                con.Open();
                var cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = us.Username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = us.password;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    return true;
                }    
               return false;
        }
        // phuong thuc lay het du lieu nhan vien
        public DataTable getAllNhanVien()
        {
            string sql = "usp_Select_All_CanBo";
            SqlConnection con = cndb.getConnect();
            con.Open();
            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // phuong thuc add nhan vien
        public bool AddNhanVien(ClsNhanVien nv)
        {
            string sql = "usp_Add_CanBo";
            SqlConnection con = cndb.getConnect();
            try
            {
                con.Open();
                var cmd = new SqlCommand(sql,con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@macanbo",SqlDbType.NVarChar).Value=nv.MaCanBo;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@namsinh", SqlDbType.DateTime).Value = Convert.ToDateTime(nv.NamSinh);
                cmd.Parameters.Add("@chuyenmon", SqlDbType.NVarChar).Value = nv.ChuyenMon;
                cmd.Parameters.Add("@trinhdo", SqlDbType.NVarChar).Value = nv.TrinhDo;
                cmd.Parameters.Add("@hesoluong", SqlDbType.Int).Value = nv.HesoLuong;
                cmd.Parameters.Add("@namtanluong", SqlDbType.DateTime).Value = Convert.ToDateTime(nv.NamTanLuong);
                cmd.Parameters.Add("@xeploai", SqlDbType.NVarChar).Value = nv.XepLoai;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = nv.GioiTinh;

               
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        // phuong thuc Update 
        public bool UpdateNhanCanBo(ClsNhanVien nv)
        {
            string sql = "usp_Update_CanBo";
            SqlConnection conn = cndb.getConnect();
            try
            {
                conn.Open();
                var cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@macanbo", SqlDbType.NVarChar).Value = nv.MaCanBo;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@namsinh", SqlDbType.DateTime).Value = Convert.ToDateTime(nv.NamSinh);
                cmd.Parameters.Add("@chuyenmon", SqlDbType.NVarChar).Value = nv.ChuyenMon;
                cmd.Parameters.Add("@trinhdo", SqlDbType.NVarChar).Value = nv.TrinhDo;
                cmd.Parameters.Add("@hesoluong", SqlDbType.Int).Value = nv.HesoLuong;
                cmd.Parameters.Add("@namtanluong", SqlDbType.DateTime).Value = Convert.ToDateTime(nv.NamTanLuong);
                cmd.Parameters.Add("@xeploai", SqlDbType.NVarChar).Value = nv.XepLoai;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        // phuong thuc xoa can bo 
        public bool DeleteCanBo(ClsNhanVien nv)
        {
            string sql ="usp_Delete_CanBo";
            SqlConnection conn = cndb.getConnect();
            try
            {
                 conn.Open();
                var cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@macanbo", SqlDbType.NVarChar).Value = nv.MaCanBo;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
