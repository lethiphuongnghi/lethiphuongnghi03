
using QLBH_VoThiKimMen.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QLBH_VoThiKimMen.DALL
{
    internal class HoaDonDAL : DBConnection
    {
        public void AddHoaDon(HoaDonBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into hoadon (MaKhachHang, TenKhachHang, SoDienThoai, KhuVuc,NgayLapHD,MaSanPham,TenSanPham,SoLuong,Gia,TongTien) values (@MaKhachHang, @TenKhachHang,@SoDienThoai, @KhuVuc,@NgayLapHD,@MaSanPham,@TenSanPham,@Soluong,@Gia,@TongTien)", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", cus.MaKhachHang));
            cmd.Parameters.Add(new SqlParameter("@TenKhachHang", cus.TenKhachHang));
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", cus.SoDienThoai));
            cmd.Parameters.Add(new SqlParameter("@KhuVuc", cus.KhuVuc));
            cmd.Parameters.Add(new SqlParameter("@NgayLapHD", cus.NgayLapHD));
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.MaSanPham));
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.TenSanPham));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", cus.Soluong));
            cmd.Parameters.Add(new SqlParameter("@Gia", cus.Gia));
            cmd.Parameters.Add(new SqlParameter("@TongTien", cus.TongTien));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<HoaDonBEL> ReadHoaDon()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<HoaDonBEL> lstCus = new List<HoaDonBEL>();

            while (reader.Read())
            {
                HoaDonBEL cus = new HoaDonBEL();
                cus.MaKhachHang = int.Parse(reader["MaKhachHang"].ToString());
                cus.TenKhachHang = reader["TenKhachHang"].ToString();
                cus.SoDienThoai = reader["SoDienThoai"].ToString();
                cus.KhuVuc = reader["KhuVuc"].ToString();
                cus.NgayLapHD = DateTime.Parse(reader["NgayLapHD"].ToString());
                cus.MaSanPham = int.Parse(reader["MaSanPham"].ToString());
                cus.TenSanPham = reader["TenSanPham"].ToString();
                cus.Soluong = int.Parse(reader["SoLuong"].ToString());
                cus.Gia = reader["Gia"].ToString();
                cus.TongTien = decimal.Parse(reader["TongTien"].ToString());

                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }



        public void EditHoaDon(HoaDonBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update HoaDon set TenKhachHang=@TenKhachHang ,SoDienThoai=@SoDienThoai,KhuVuc=@KhuVuc,NgayLapHD=@NgayLapHD,MaSanPham=@MaSanPham,TenSanPham=@TenSanPham,SoLuong=@SoLuong,Gia=@Gia,TongTien=@TongTien where MaKhachHang=@MaKhachHang", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", cus.MaKhachHang));
            cmd.Parameters.Add(new SqlParameter("@TenKhachHang", cus.TenKhachHang));
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", cus.SoDienThoai));
            cmd.Parameters.Add(new SqlParameter("@KhuVuc", cus.KhuVuc));
            cmd.Parameters.Add(new SqlParameter("@NgayLapHD", cus.NgayLapHD));
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.MaSanPham));
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.TenSanPham));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", cus.Soluong));
            cmd.Parameters.Add(new SqlParameter("@Gia", cus.Gia));
            cmd.Parameters.Add(new SqlParameter("@TongTien", cus.TongTien));


            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteHoaDon(HoaDonBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from HoaDon where MaKhachHang=@MaKhachHang", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", cus.MaKhachHang));
            cmd.ExecuteNonQuery();
            conn.Close();
            }
            //public void NewHoaDon(HoaDonBEL cus)
            //{


            //    SqlConnection conn = CreateConnection();
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("insert into order_items (MaKhachHang, TenKhachHang, SoDienThoai, KhuVuc) values (@MaKhachHang, @TenKhachHang,@SoDienThoai, @KhuVuc)", conn);
            //    cmd.Parameters.Add(new SqlParameter("@MaKhachHang", cus.MaKhachHang));
            //    cmd.Parameters.Add(new SqlParameter("@TenKhachHang", cus.TenKhachHang));
            //    cmd.Parameters.Add(new SqlParameter("@SoDienThoai", cus.SoDienThoai));
            //    cmd.Parameters.Add(new SqlParameter("@KhuVuc", cus.KhuVuc));


            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

        }
    }

