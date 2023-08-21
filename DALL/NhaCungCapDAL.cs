using QLBH_VoThiKimMen.MODELL;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QLBH_VoThiKimMen.DALL
{
    internal class NhaCungCapDAL : DBConnection
    {
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhaCungCapBEL> lstCus = new List<NhaCungCapBEL>();

            while (reader.Read())
            {
                NhaCungCapBEL cus = new NhaCungCapBEL();
                cus.id = int.Parse(reader["id"].ToString());
                cus.Ten = reader["Ten"].ToString();
                cus.Diachi = reader["DiaChi"].ToString();
                cus.sdt = reader["sdt"].ToString();
                cus.email = reader["email"].ToString();
                cus.KhuVuc = reader["KhuVuc"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void EditNhaCungCap(NhaCungCapBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update  NhaCungCap set Ten=@Ten ,Diachi=@Diachi,sdt=@sdt,email=@email,KhuVuc=@KhuVuc where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.Parameters.Add(new SqlParameter("@Ten", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@Diachi", cus.Diachi));
            cmd.Parameters.Add(new SqlParameter("@sdt", cus.sdt));
            cmd.Parameters.Add(new SqlParameter("@email", cus.email));
            cmd.Parameters.Add(new SqlParameter("@KhuVuc", cus.KhuVuc));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteNhaCungCap(NhaCungCapBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Nhacungcap where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewNhaCungCap(NhaCungCapBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into NhaCungCap (id, Ten, DiaChi, sdt, email, KhuVuc) values (@id, @Ten, @Diachi, @sdt, @email, @KhuVuc)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.Parameters.Add(new SqlParameter("@Ten", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@Diachi", cus.Diachi));
            cmd.Parameters.Add(new SqlParameter("@sdt", cus.sdt));
            cmd.Parameters.Add(new SqlParameter("@email", cus.email));
            cmd.Parameters.Add(new SqlParameter("@KhuVuc", cus.KhuVuc));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
