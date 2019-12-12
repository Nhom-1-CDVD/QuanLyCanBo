using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        public DataTable GetAllPhuCap(){
        	return clsdal.getAllPhuCap();
        }
        public bool addPhuCap(int maPhuCap, string tenPhuCap, double tienPhuCap){
        	if(clsdal.addPhuCap(maPhuCap,tenPhuCap,tienPhuCap))
        	{
        		return true;
        	}
        	return false;
        }
        public bool deletePhuCap(int maPhuCap){
        	if(clsdal.delectPhuCap(maPhuCap)){
        		return true;
        	}
        	return false;
        }
        public bool updatePhuCap(int maPhuCap, string tenPhuCap, double tienPhuCap){
        	if(clsdal.updatePhuCap(maPhuCap,tenPhuCap,tienPhuCap)){
        	   	return true;
        	   }
        	else{
        		return false;
        	}
        }
        
        public SqlDataReader getTenCanBo(){
        	SqlDataReader DR = clsdal.getTenCanBo();
        	return DR;
        }
        public DataTable FindGIoiTinh(ClsNhanVien nv)
        {
            return clsdal.FindGIoiTinh(nv);
        }
        public DataTable FindChuyenMon(ClsNhanVien nv)
        {
            return clsdal.FindChuyenMon(nv);
        }
        public DataTable FindLoaiLaoDong(ClsNhanVien nv)
        {
            return clsdal.FindLoaiLaoDong(nv);
        }
        public DataTable XemTongLuong()
        {
            return clsdal.XemTongLuong();
        }
        
        public SqlDataReader getTenPhuCap(){
        	return clsdal.getTenPhuCap();
        }
        public SqlDataReader getCanBoTen(string macanbo){
        	return clsdal.getCanBoTen(macanbo);
        }
        public SqlDataReader getTTPhuCap(string maPhuCap){
        	return clsdal.getTTPhuCap(maPhuCap);
        }
        public DataTable getAllDSPC(){
        	return clsdal.getAllDanhSachPhuCap();
        }
        public bool InsertDSPC(string maCanBo, string hoTen, string maPhuCap, string tenPhuCap){
        	return clsdal.insertDanhSachPhuCap(maCanBo,hoTen,maPhuCap,tenPhuCap);
        }
        public bool XoaDSPC(string maCanBo, string maPhuCap){
        	return clsdal.XoaDSPC(maCanBo,maPhuCap);
        }
        public bool updatePC(int  maPhuCap, string tenphucap, double soTienPhuCap){
        	return clsdal.updatePhuCap(maPhuCap,tenphucap,soTienPhuCap);
        }
        
        public DataTable sapXepTang(){
        	return clsdal.sapXepTang();
        }
        public DataTable sapXepGiam(){
        	return clsdal.sapXepGiam();
        }
    }
}
