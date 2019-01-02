using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhobai.CONNECT
{
    public class KhoBai

    {
        private static KhoBai instance;
        public static KhoBai Instance
        {
            get { if (instance == null) instance = new KhoBai(); return instance; }
            private set { instance = value; }
        }
        private KhoBai() { }

        public DataTable LoadListKhoBai()
        {
            string query = "Select * from KHOBAI";
            return DataConnect.Instance.ExecuteQuery(query);
        }
        public bool KhoBai_Them(string maKho, string tenKho, string diaChiKho, string maKhuVuc,double dongGia1m3Ngay)
        {
            string query = string.Format("EXEC dbo.USP_InsertKhoBai @maKho ='{0}',@tenKho='{1}',@diaChiKho='{2}',@maKhuVuc='{3}',@dongGia1m3Ngay='{4}'", maKho,tenKho,diaChiKho,maKhuVuc,dongGia1m3Ngay);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool HopDong_Sua(string maKho, string tenKho, string diaChiKho, string maKhuVuc, double dongGia1m3Ngay)
        {
            string query = string.Format("EXEC dbo.USP_InsertKhoBai @maKho ='{0}',@tenKho='{1}',@diaChiKho='{2}',@maKhuVuc='{3}',@dongGia1m3Ngay='{4}'", maKho, tenKho, diaChiKho, maKhuVuc, dongGia1m3Ngay);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public HopDong_Xoa(string maKho)
        {
            string query = string.Format("DELETE dbo.KHOBAI WHERE @maKho = '{0}'", maKho);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
