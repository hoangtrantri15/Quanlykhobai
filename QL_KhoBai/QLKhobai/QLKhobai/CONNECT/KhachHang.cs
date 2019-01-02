using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhobai.CONNECT
{
    public class KhachHang
    {
        private static KhachHang instance;

        public static KhachHang Instance
        {
            get { if (instance == null) instance = new KhachHang(); return instance; }
            private set { instance = value; }
        }

        private KhachHang() { }
        public DataTable LoadListKhachHang()
        {
            string query = "Select * from KHACHHANG";
            return DataConnect.Instance.ExecuteQuery(query);
        }
        public bool KhachHang_Them(string maKhachHang,string tenKhachHang,string soCMND,string soDT,double congNo)
        {
            string query = string.Format("EXEC dbo.USP_InsertKhachHang @maKhachHang ='{0}',@tenKhachHang='{1}',@soCMND='{2}',@soDT='{3}',@congNo='{4}'",maKhachHang,tenKhachHang,soCMND,soDT,congNo);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool KhachHang_Sua(string maKhachHang, string tenKhachHang, float soCMND, float soDT, float congNo)
        {
            string query = string.Format("EXEC dbo.USP_UpdateKhachHang @maKhachHang ='{0}',@tenKhachHang='{1}',@soCMND='{2}',@soDT='{3}',@congNo='{4}'", maKhachHang, tenKhachHang, soCMND, soDT, congNo);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool KhachHang_Xoa(int maKhachHang)
        {
            string query = string.Format("DELETE dbo.KHACHHANG WHERE @maKhachHang = '{0}'", maKhachHang);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //viết them may cai class cua may cai form kia nua
        //chỉ làm mấy cái click

    }
}
