using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBH_VoThiKimMen.MODELL;
using QLBH_VoThiKimMen.DALL;
using QLBH_VoThiKimMen.BALL;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace QLBH_VoThiKimMen.GUII
{
    public partial class HoaDon : Form
    {

        HoaDonBAL cusBAL = new HoaDonBAL();
        DBConnection dbConnection = new DBConnection();
        NhaCungCapBAL khBAL = new NhaCungCapBAL();
        SanPhamBAL khBAL1 = new SanPhamBAL();

        //AreaBAL areBAL = new AreaBAL();
        public HoaDon()
        {
            InitializeComponent();

            cbrow.CellClick += new DataGridViewCellEventHandler(cbrow_CellClick);
            txtTenKH.ReadOnly = true;


            // Mã Hàng
            List<NhaCungCapBEL> khachhang = khBAL.ReadNhaCungCap();
            cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKH.DataSource = khachhang;
            cbMaKH.DisplayMember = "id";
            cbMaKH.ValueMember = "id";
            cbMaKH.SelectedItem = null;

            // Mã San Pham
            List<SanPhamBEL> sanPhams = khBAL1.ReadSanPham();
            cbMSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMSP.DataSource = sanPhams;
            cbMSP.DisplayMember = "id";
            cbMSP.ValueMember = "id";
            cbMSP.SelectedItem = null;

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            // Check if a supplier is selected
            if (cbMaKH.SelectedItem == null && cbMSP.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp trước khi thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Retrieve selected supplier and product information
            int selectedSupplierId = Convert.ToInt32(cbMaKH.Text);
            int selectedProductId = Convert.ToInt32(cbMSP.Text);

            // Check if the data already exists
            bool dataExists = false;
            foreach (DataGridViewRow row in cbrow.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == selectedSupplierId && Convert.ToInt32(row.Cells[5].Value) == selectedProductId)
                {
                    dataExists = true;
                    break;
                }
            }

            if (dataExists)
            {
                MessageBox.Show("Dữ liệu đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Retrieve selected supplier information
            int selectedSupplierId2 = Convert.ToInt32(cbMaKH.Text);
            string selectedSupplierName = txtTenKH.Text;
            string selectedSupplierSDT = tbSDT.Text;
            string selectedSupplierKV = txtKV.Text;
            int selectedSupplierId1 = Convert.ToInt32(cbMSP.Text);
            string selectedSupplier = txtTSP.Text;
            string selectedSupplierSL = txtSL.Text;
            string selectedSupplierGia = txtGia.Text;
         

            //Perform additional operations or display data as needed
            // For example, you might add this data to a list or display it in a control
            HoaDonBEL cus = new HoaDonBEL();
            cus.MaKhachHang = int.Parse(cbMaKH.Text);
            cus.TenKhachHang = txtTenKH.Text;
            cus.SoDienThoai = tbSDT.Text;
            cus.KhuVuc = txtKV.Text;
            cus.NgayLapHD = DateTime.Now;
            cus.MaSanPham = int.Parse(cbMSP.Text);
            cus.TenSanPham = txtTSP.Text;
            cus.Soluong = int.Parse(txtSL.Text);
            cus.Gia = txtGia.Text;
            cus.TongTien = decimal.Parse(txtSUM.Text);


            cusBAL.AddHoaDon(cus);
            cbrow.Rows.Add(cus.MaKhachHang, cus.TenKhachHang, cus.SoDienThoai, cus.KhuVuc, cus.NgayLapHD, cus.MaSanPham, cus.TenSanPham, cus.Soluong, cus.Gia, cus.TongTien);
            MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //// Reset fields after adding
            cbMaKH.SelectedItem = null;
            cbMaKH.SelectedItem = null;
            cbMSP.SelectedItem = null;
            txtTenKH.Clear();
            tbSDT.Clear();
            txtKV.Clear();
            txtTSP.Clear();
            txtSL.Clear();
            txtGia.Clear();
            txtSUM.Clear();

            MessageBox.Show("Nhà cung cấp đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMaKH.Text == "")
            {
                txtTenKH.Text = "";
                tbSDT.Text = "";
                txtKV.Text = "";
            }

            str = "Select Ten from NhaCungCap where id = N'" + cbMaKH.SelectedValue + "'";
            txtTenKH.Text = dbConnection.GetFieldValues(str);
            str = "Select sdt from NhaCungCap where id = N'" + cbMaKH.SelectedValue + "'";
            tbSDT.Text = dbConnection.GetFieldValues(str);
            str = "Select sdt from NhaCungCap where id = N'" + cbMaKH.SelectedValue + "'";
            txtKV.Text = dbConnection.GetFieldValues(str);
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = cbrow.Rows[e.RowIndex];

                // Assuming the data in the row is stored as follows:
                // [0]: MaKhachHang, [1]: TenKhachHang, [2]: SoDienThoai, [3]: KhuVuc, ...
                cbMaKH.Text = selectedRow.Cells[0].Value.ToString();
                txtTenKH.Text = selectedRow.Cells[1].Value.ToString();
                tbSDT.Text = selectedRow.Cells[2].Value.ToString();
                txtKV.Text = selectedRow.Cells[3].Value.ToString();

                // Populate additional information below the input fields
                string ngayLapHD = selectedRow.Cells[4].Value.ToString();
                string maSanPham = selectedRow.Cells[5].Value.ToString();
                string tenSanPham = selectedRow.Cells[6].Value.ToString();
                string soLuong = selectedRow.Cells[7].Value.ToString();
                string gia = selectedRow.Cells[8].Value.ToString();
                string tongTien = selectedRow.Cells[9].Value.ToString();

                // Update the corresponding labels or text boxes with the retrieved data
                txtNL.Text = ngayLapHD;
                cbMSP.Text = maSanPham;
                txtTSP.Text = tenSanPham;
                txtSL.Text = soLuong;
                txtGia.Text = gia;
                txtSUM.Text = tongTien;

                // ... Update other controls as needed ...

                // You can also display information in other parts of your form
                // based on the selected row's data.
            }
        }


        private void cbrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming that "cbrow" is the DataGridView control where you want to display the data

            // Get the selected supplier information from the form's controls
            //int selectedSupplierId = Convert.ToInt32(cbMaKH.SelectedValue);
            //string selectedSupplierName = txtTenKH.Text;
            //string selectedSupplierSDT = tbSDT.Text;
            //string selectedSupplierKV = txtKV.Text;

            //// Add the selected supplier information to the DataGridView
            //DataGridViewRow newRow = new DataGridViewRow();
            //newRow.CreateCells(cbrow, selectedSupplierId, selectedSupplierName, selectedSupplierSDT, selectedSupplierKV);
            //cbrow.Rows.Add(newRow);

            //// Clear fields after adding
            ////cbMaKH.SelectedItem = null;
            ////txtTenKH.Clear();
            ////tbSDT.Clear();
            ////txtKV.Clear();

            //MessageBox.Show("Nhà cung cấp đã được thêm vào DataGridView!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDonBEL> lstCus = cusBAL.ReadHoaDon();
            foreach (HoaDonBEL cus in lstCus)
            {
                cbrow.Rows.Add(cus.MaKhachHang, cus.TenKhachHang, cus.SoDienThoai, cus.KhuVuc, cus.NgayLapHD, cus.MaSanPham,cus.TenSanPham, cus.Soluong, cus.Gia, cus.TongTien);

            }
            //Reset input fields and combo box selection to their default values
            //ResetInputFields();

        }

        private void cbMSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMSP.SelectedValue == null || string.IsNullOrEmpty(cbMSP.Text))
            {
                txtGia.Text = "";
                txtSL.Text = string.Empty;
                txtTSP.Text = string.Empty;
            }
            else
            {
                str = "Select price from products where id = N'" + cbMSP.SelectedValue + "'";
                txtGia.Text = dbConnection.GetFieldValues(str);

                str = "Select quantity_in_stock from products where id = N'" + cbMSP.SelectedValue + "'";
                txtSL.Text = dbConnection.GetFieldValues(str);
                str = "Select name from products where id = N'" + cbMSP.SelectedValue + "'";
                txtTSP.Text = dbConnection.GetFieldValues(str);

                UpdateTotalSum(); // Calculate and update the total sum
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalSum();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalSum();
        }

        private void UpdateTotalSum()
        {
            if (!string.IsNullOrEmpty(txtSL.Text) && !string.IsNullOrEmpty(txtGia.Text))
            {
                int quantity;
                decimal price;

                if (int.TryParse(txtSL.Text, out quantity) && decimal.TryParse(txtGia.Text, out price))
                {
                    decimal totalSum = quantity * price;
                    txtSUM.Text = totalSum.ToString();
                }
            }
        }





        private void btDelete_Click(object sender, EventArgs e)
        {
            if (cbrow.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = cbrow.SelectedRows[0];

                // Retrieve necessary information to delete from the database
                int selectedSupplierId = Convert.ToInt32(selectedRow.Cells[0].Value);
                int selectedProductId = Convert.ToInt32(selectedRow.Cells[5].Value);

                // Confirm with the user before deleting
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete from the database
                    DeleteRecordFromDatabase(selectedSupplierId, selectedProductId);

                    // Remove the row from the DataGridView
                    cbrow.Rows.Remove(selectedRow);

                    MessageBox.Show("Dòng đã được xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecordFromDatabase(int supplierId, int productId)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                // Create a DELETE command for the HoaDon table
                SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaKhachHang = @MaKhachHang AND MaSanPham = @MaSanPham", conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", supplierId);
                cmd.Parameters.AddWithValue("@MaSanPham", productId);

                // Execute the DELETE command
                cmd.ExecuteNonQuery();
            }
        }

        private SqlConnection CreateConnection()
        {
            // Replace with your connection string
            string connectionString = @"Data Source= DESKTOP-RSMF0P1\MSSQLSERVER3 ;Initial Catalog= TaiKhoan; User Id=sa; Password=sa";
            return new SqlConnection(connectionString);
        }


        private void btEdit_Click_1(object sender, EventArgs e)
        {
            {
                // Check if a supplier is selected
                if (cbMaKH.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp trước khi thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve selected supplier information
                //int selectedSupplierId = Convert.ToInt32(cbMaKH.Text);
                //string selectedSupplierName = txtTenKH.Text;
                //string selectedSupplierSDT = tbSDT.Text;
                //string selectedSupplierKV = txtKV.Text;

                // Perform additional operations or display data as needed
                // For example, you might add this data to a list or display it in a control

                HoaDonBEL cus = new HoaDonBEL();
                cus.MaKhachHang = int.Parse(cbMaKH.Text);
                cus.TenKhachHang = txtTenKH.Text;
                cus.SoDienThoai = tbSDT.Text;
                cus.KhuVuc = txtKV.Text;
                cus.NgayLapHD = DateTime.Now;
                cus.MaSanPham = int.Parse(cbMSP.Text);
                cus.TenSanPham = txtTSP.Text;
                cus.Soluong = int.Parse(txtSL.Text);
                cus.Gia = txtGia.Text;
                cus.TongTien = decimal.Parse(txtSUM.Text);
                decimal updatedTotalTien = decimal.Parse(txtSL.Text) * decimal.Parse(txtGia.Text);
                cus.TongTien = updatedTotalTien;

                cusBAL.EditHoaDon(cus);
                DataGridViewRow selectedRow = cbrow.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                // Update the row in the DataGridView with the edited data
                cbrow.Rows[rowIndex].Cells[0].Value = cus.MaKhachHang;
                cbrow.Rows[rowIndex].Cells[1].Value = cus.TenKhachHang;
                cbrow.Rows[rowIndex].Cells[2].Value = cus.SoDienThoai;
                cbrow.Rows[rowIndex].Cells[3].Value = cus.KhuVuc;
                cbrow.Rows[rowIndex].Cells[4].Value = cus.NgayLapHD;
                cbrow.Rows[rowIndex].Cells[5].Value = cus.MaSanPham;
                cbrow.Rows[rowIndex].Cells[6].Value = cus.TenSanPham;
                cbrow.Rows[rowIndex].Cells[7].Value = cus.Soluong;
                cbrow.Rows[rowIndex].Cells[8].Value = cus.Gia;
                cbrow.Rows[rowIndex].Cells[9].Value = cus.TongTien;
                //cbrow.Rows.Add(cus.MaKhachHang, cus.TenKhachHang, cus.SoDienThoai, cus.KhuVuc, cus.NgayLapHD, cus.MaSanPham, cus.Soluong, cus.Gia, cus.TongTien);
                //MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset fields after adding
                cbMaKH.SelectedItem = null;
                txtTenKH.Clear();
                tbSDT.Clear();
                txtKV.Clear();

                MessageBox.Show("Nhà cung cấp đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Export column headers (field names)
                    for (int colIndex = 0; colIndex < cbrow.Columns.Count; colIndex++)
                    {
                        string columnName = cbrow.Columns[colIndex].HeaderText;
                        worksheet.Cell(1, colIndex + 1).Value = columnName; // First row is for headers
                    }

                    // Loop through the DataGridView rows and columns to export the data
                    for (int rowIndex = 0; rowIndex < cbrow.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < cbrow.Columns.Count; colIndex++)
                        {
                            // Excel uses 1-based indexing for rows and columns
                            // So we add 1 to rowIndex and colIndex to get the correct cell in Excel
                            object cellValue = cbrow.Rows[rowIndex].Cells[colIndex].Value;
                            string cellStringValue = cellValue != null ? cellValue.ToString() : "";
                            worksheet.Cell(rowIndex + 2, colIndex + 1).Value = cellStringValue; // Start from row 2 for data
                        }
                    }

                    // Save the Excel file
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Save Excel File",
                        FileName = "ExportedData.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu thành công!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi sảy ra. Thử lại");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //private void txtGia_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}

