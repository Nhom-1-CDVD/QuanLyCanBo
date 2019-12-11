using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLyNhanVien
{
    class ClsBiLL
    {
        ClsDAL clsdal;
        public ClsBiLL()
        {
            clsdal = new ClsDAL();
        }
        public bool RegisterUser(ClsUser us)
        {
            return clsdal.RegisterUser(us);
        }
        public bool LoginUser(ClsUser us)
        {
            return clsdal.LoginUser(us);
        }
        public DataTable getAllNhanVien()
        {
            return clsdal.getAllNhanVien();
        }
        public bool AddNhanVien(ClsNhanVien nv)
        {
            return clsdal.AddNhanVien(nv);
        }
        public bool UpdateNhanCanBo(ClsNhanVien nv)
        {
            return clsdal.UpdateNhanCanBo(nv);
        }
        public bool DeleteCanBo(ClsNhanVien nv)
        {
            return clsdal.DeleteCanBo(nv);
        }
        public DataTable getAllUser()
        {
            return clsdal.getAllUser();
        }
        public bool AddUser(ClsUser us)
        {
            return clsdal.AddUser(us);
        }
        public bool UpdateUser(ClsUser us)
        {
            return clsdal.UpdateUser(us);
        }
        public bool DeleteUser(ClsUser us)
        {
            return clsdal.DeleteUser(us);
        }
        public DataTable FindCanBo(string nv)
        {
            return clsdal.FindCanBo(nv);
        }
    }
}
