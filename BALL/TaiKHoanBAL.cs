using QLBH_VoThiKimMen.MODELL;
using System.Collections.Generic;

namespace QLBH_VoThiKimMen.BALL
{
    public class TaiKhoanBAL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();
        public List<TaiKhoanBEL> ReadTaiKhoan()
        {
            List<TaiKhoanBEL> lstCus = dal.ReadTaiKhoan();
            return lstCus;
        }

        //public void NewTaiKhoan(TaiKhoanBEL cus)
        //{
        //    dal.NewTaiKhoan(cus);
        //}
        //public void EditTaiKhoan(TaiKhoanBEL cus)
        //{
        //    dal.EditTaikhoan(cus);
        //}


    }
}
