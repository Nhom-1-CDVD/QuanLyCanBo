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
using System.Data.SqlTypes;
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


        // phuong thuc lay tat ca user
        public DataTable getAllUser()
        {
            string sql = "usp_GetAllUser";
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
        // phuong thuc them user
        public bool AddUser(ClsUser us)
        {
            string sql = "usp_AddUser";
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

        // phuong thuc Update user
        public bool UpdateUser(ClsUser us)
        {
            string sql = "usp_UpdateUser";
            SqlConnection con = cndb.getConnect();
            try
            {
                con.Open();
                var cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = us.ID;
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

        // phuong thuc xoa user 
        public bool DeleteUser(ClsUser us)
        {
            string sql = "usp_DeleteUser";
            SqlConnection conn = cndb.getConnect();
            try
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = us.ID;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable FindCanBo(string nv)
        {
            string sql = "SELECT * FROM Can_Bo WHERE HoTen like N'%" + nv + "%' OR MaCanBo like N'%" + nv + "%'";
            //B2: tạo một kết nói đến sql
            SqlConnection con = cndb.getConnect();
            //B3: khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: mở kết nói
            con.Open();
            //B5:mỡ dữ liệu từ sqldatAdapter vào datatable 
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng két nói
            con.Close();
            return dt;
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
        
        public DataTable getAllPhuCap(){
        	string sql ="usp_Get_All_PhuCap";
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
        public bool addPhuCap(int maPhuCap, string tenPhuCap, double tienPhuCap){
        	string sql ="usp_Add_PhuCap";
        	SqlConnection con = cndb.getConnect();
        	try{
        		con.Open();
            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maphucap", SqlDbType.Int).Value = maPhuCap;
            cmd.Parameters.Add("@tenphucap", SqlDbType.NVarChar).Value = tenPhuCap;
            cmd.Parameters.Add("@sotienphucap", SqlDbType.Money).Value = tienPhuCap;
            cmd.ExecuteNonQuery();
            con.Close();
        	}
        	catch{
        		return false;
        	}
            
            return true;
        }
        public bool delectPhuCap(int maPhuCap){
        	string sql ="usp_Delete_PhuCap";
        	SqlConnection con = cndb.getConnect();
        	try{
        		con.Open();
            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maphucap", SqlDbType.Int).Value = maPhuCap;
            cmd.ExecuteNonQuery();
            con.Close();
        	}
        	catch{
        		return false;
        	}
            
            return true;
        }
        public bool updatePhuCap(int maPhuCap, string tenPhuCap, double tienPhuCap){
        	string sql ="usp_Update_PhuCap";
        	SqlConnection con = cndb.getConnect();
        	try{
        		con.Open();
            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maphucap", SqlDbType.Int).Value = maPhuCap;
            cmd.Parameters.Add("@tenphucap", SqlDbType.NVarChar).Value = tenPhuCap;
            cmd.Parameters.Add("@sotienphucap", SqlDbType.Money).Value = tienPhuCap;
            cmd.ExecuteNonQuery();
            con.Close();
        	}
        	catch{
        		return false;
        	}
            
            return true;
        }
        
        public SqlDataReader getTenCanBo(){
        	string Sql = "select MaCanBo, HoTen from Can_Bo";
        	SqlConnection con = cndb.getConnect();
        	con.Open();
        	SqlCommand cmd = new SqlCommand(Sql, con);
        	SqlDataReader DR = cmd.ExecuteReader();
        	return DR;
        }
    }
}
