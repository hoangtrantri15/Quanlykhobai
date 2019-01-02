using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhobai.CONNECT
{
    public class KhuVuc

    {
        private static KhuVuc instance;
        public static KhuVuc Instance
        {
            get { if (instance == null) instance = new KhuVuc(); return instance; }
            private set { instance = value; }
        }
        private KhuVuc() { }

        public DataTable LoadListKhuVuc()
        {
            string query = "Select * from KHUVUC";
            return DataConnect.Instance.ExecuteQuery(query);
        }
        public bool KhuVuc_Them(string maKhuVuc,string tenQuanHuyen,string tenPhuongXa)
        {
            string query = string.Format("EXEC dbo.USP_InsertKHUVUC @maKhuVuc ='{0}',@tenQuanHuyen='{1}',@tenPhuongXa='{2}'", maKhuVuc,tenQuanHuyen,tenPhuongXa);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool KhuVuc_Sua(string maKhuVuc, string tenQuanHuyen, string tenPhuongXa)
        {
            string query = string.Format("EXEC dbo.USP_InsertKHUVUC @maKhuVuc ='{0}',@tenQuanHuyen='{1}',@tenPhuongXa='{2}'", maKhuVuc, tenQuanHuyen, tenPhuongXa);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool KhuVuc_Xoa(string maKhuVuc)
        {
            string query = string.Format("DELETE dbo.KHUVUC WHERE @maKhuVuc = '{0}'", maKhuVuc);
            int result = DataConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
