using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.Controller.DataAccess
{
    public class DataBaseFunction
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối
        public static string connString;   //Khai báo biến chứa chuỗi kết nối

        public static void Connect()
        {
            //Thiết lập giá trị cho chuỗi kết nối
            connString = @"Data Source=DESKTOP-BV1RMRN\TAKA;Initial Catalog=TiemThuoc;Integrated Security=True";

            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
        }

        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose(); 	//Giải phóng tài nguyên
                Conn = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static void ExcuteSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
        }

        public static bool IsExisted(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            adp.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void Delete(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
        }
    }
}
