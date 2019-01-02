using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhobai.CONNECT
{
    public class ChiTietHopDong

    {
        private static ChiTietHopDong instance;
        public static ChiTietHopDong Instance
        {
            get { if (instance == null) instance = new ChiTietHopDong(); return instance; }
            private set { instance = value; }
        }
        private ChiTietHopDong() { }

        public DataTable LoadListChiTietHopDong()
        {
            string query = "Select * from CHITIETHOPDONG";
            return DataConnect.Instance.ExecuteQuery(query);
        }
        public bool ChiTietHopDong_Them(float soHD, string maKho,DateTime ngayKetThuc)
        {
            string query = string.Format("EXEC dbo.USP_InsertCHITIETHOPDONG @soHD ='{0}',@maKho='{1}',@ngayKetThuc='{2}'", soHD,maKho,ngayKetThuc);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ChiTietHopDong_Sua(float soHD, string maKho, DateTime ngayKetThuc)
        {
            string query = string.Format("EXEC dbo.USP_InsertCHITIETHOPDONG @soHD ='{0}',@maKho='{1}',@ngayKetThuc='{2}'", soHD, maKho, ngayKetThuc);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ChiTietHopDong_Xoa(float soHD)
        {
            string query = string.Format("DELETE dbo.CHITIETHOPDONG WHERE @soHD = '{0}'", soHD);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
