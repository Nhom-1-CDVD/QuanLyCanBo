using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace QuanLyNhanVien
{
    
    class ClsConnectDB
    {
        string conStr;
        public ClsConnectDB()
        {
            conStr = @"Data Source=DESKTOP-9QR63V4\MQLDAI;Initial Catalog=QuanLyCanBo;Integrated Security=True";
            //conStr = @"Data Source=BLPCQPIBHEDH2LH;Initial Catalog=QuanLyCanBo;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
