using QLBH_VoThiKimMen.DALL;
using QLBH_VoThiKimMen.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_VoThiKimMen.BALL
{
    public class NhaCungCapBAL
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            List<NhaCungCapBEL> lstCus = dal.ReadNhaCungCap();
            return lstCus;
        }

        public void NewNhaCungCap(NhaCungCapBEL cus)
        {
            dal.NewNhaCungCap(cus);
        }
        public void EditNhaCungCap(NhaCungCapBEL cus)
        {
            dal.EditNhaCungCap(cus);
        }
        public void DeleteNhaCungCap(NhaCungCapBEL cus)
        {
            dal.DeleteNhaCungCap(cus);
        }
     

      
    }
}
