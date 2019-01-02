using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhobai.CONNECT
{
    public class ThanhToan

    {
        private static ThanhToan instance;
        public static ThanhToan Instance
        {
            get { if (instance == null) instance = new ThanhToan(); return instance; }
            private set { instance = value; }
        }
        private ThanhToan() { }

        public DataTable LoadListThanhToan()
        {
            string query = "Select * from THANHTOAN";
            return DataConnect.Instance.ExecuteQuery(query);
        }
        public bool ThanhToan_Them(DateTime ngayLapPhieu,float soTienThu,int sttChiTiet)
        {
            string query = string.Format("EXEC dbo.USP_InsertTHANHTOAN @ngayLapPhieu ='{0}',@soTienThu='{1}',@sttChiTiet='{2}'", ngayLapPhieu, soTienThu, sttChiTiet);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ThanhToan_Sua(DateTime ngayLapPhieu, float soTienThu, int sttChiTiet)
        {
            string query = string.Format("EXEC dbo.USP_InsertTHANHTOAN @ngayLapPhieu = '{0}', @soTienThu = '{1}', @sttChiTiet = '{2}'", ngayLapPhieu, soTienThu, sttChiTiet);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ThanhToan_Xoa(DateTime ngayLapPhieu)
        {
            string query = string.Format("DELETE dbo.THANHTOAN WHERE @ngayLapPhieu = '{0}'", ngayLapPhieu);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
