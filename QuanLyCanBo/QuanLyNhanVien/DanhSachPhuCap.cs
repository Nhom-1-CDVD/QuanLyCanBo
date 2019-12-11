/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/12/2019
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of DanhSachPhuCap.
	/// </summary>
	public partial class DanhSachPhuCap : Form
	{
		ClsBiLL clsbill = new ClsBiLL();
		public DanhSachPhuCap()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DanhSachPhuCapLoad(object sender, EventArgs e)
		{
			 SqlDataReader DR = clsbill.getTenCanBo();
			 while (DR.Read())
            {
                cbCanBo.Items.Add(DR[0]);

            }
		}
	}
}
