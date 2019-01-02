using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhobai.CONNECT
{
    public class HopDong
    {
        private static HopDong instance;
        public static HopDong Instance
        {
            get { if (instance == null) instance = new HopDong(); return instance; }
            private set { instance = value; }
        }
        private HopDong() { }

        public DataTable LoadListHopDong()
        {
            string query = "Select * from HOPDONG";
            return DataConnect.Instance.ExecuteQuery(query);
        }
        public bool HopDong_Them(float soHD, DateTime ngayKyHD, DateTime ngayBDT, Double tongM3, string maKhachThue)
        {
            string query = string.Format("EXEC dbo.USP_InsertHopDong @soHD ='{0}',@ngayKyHD='{1}',@ngayBDT='{2}',@tongM3='{3}',@maKhachThue='{4}'", soHD,ngayKyHD,ngayBDT,tongM3,maKhachThue);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool HopDong_Sua(float soHD, DateTime ngayKyHD, DateTime ngayBDT, Double tongM3, string maKhachThue)
        {
            string query = string.Format("EXEC dbo.USP_InsertHopDong @soHD = '{0}', @ngayKyHD = '{1}', @ngayBDT = '{2}', @tongM3 = '{3}', @maKhachThue = '{4}'", soHD,ngayKyHD,ngayBDT,tongM3,maKhachThue);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool KhachHang_Xoa(float soHD)
        {
            string query = string.Format("DELETE dbo.HOPDONG WHERE @soHD = '{0}'", soHD);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
}
