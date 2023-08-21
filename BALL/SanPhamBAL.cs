using QLBH_VoThiKimMen.DALL;
using QLBH_VoThiKimMen.MODELL;
using System.Collections.Generic;

namespace QLBH_VoThiKimMen.BALL
{
    public class SanPhamBAL
    {
        SanPhamDAL dal = new SanPhamDAL();
        public List<SanPhamBEL> ReadSanPham()
        {
            List<SanPhamBEL> lstCus = dal.ReadSanPham();
            return lstCus;
        }
        public List<SanPhamBEL> Timkiem(SanPhamBEL c)
        {
            List<SanPhamBEL> lstCus = dal.timkiem(c);
            return lstCus;
        }

        public void AddSanPham(SanPhamBEL cus)
        {
            dal.AddSanPham(cus);
        }
        public void DeleteSanPham(SanPhamBEL cus)
        {
            dal.DeleteSanPham(cus);
        }
        public void EditSanPham(SanPhamBEL cus)
        {
            dal.EditSanPham(cus);
        }


    }
}
