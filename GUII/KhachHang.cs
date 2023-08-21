using QLBH_VoThiKimMen.BALL;
using QLBH_VoThiKimMen.MODELL;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLBH_VoThiKimMen.GUII
{
    public partial class KhachHang : Form
    {
        NhaCungCapBAL cusBAL1 = new NhaCungCapBAL();
        private void ClearInputFields()
        {
            tbMa.Text = "";
            tbName.Text = "";
            tbSDT.Text = "";
            tbDC.Text = "";
            tbEmail.Text = "";
            cbKV.SelectedIndex = -1; // Assuming cbKV is a ComboBox
        }

        public KhachHang()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int ma;
            if (!int.TryParse(tbMa.Text, out ma) || ma < 0)
            {
                MessageBox.Show("Mã phải là số nguyên không âm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsIdAlreadyExists(ma))
            {
                MessageBox.Show("Mã đã tồn tại. Vui lòng nhập mã khác!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = tbName.Text;
            if (string.IsNullOrEmpty(name) || name.Length > 15 || !char.IsUpper(name[0]))
            {
                MessageBox.Show("Tên không hợp lệ! Tên phải bắt đầu bằng ký tự viết hoa và tối đa 15 ký tự.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sdt = tbSDT.Text;

            //if (sdt.Length != 10 || (!sdt.StartsWith("09") && !sdt.StartsWith("03")))
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải có 10 chữ số và bắt đầu bằng '09' hoặc '03'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string diachi = tbDC.Text;

            //if (!Regex.IsMatch(diachi, @"^\d+/\w+(\.\w+)?$"))
            //{
            //    MessageBox.Show("Địa chỉ không hợp lệ! Địa chỉ phải có định dạng số nhà/tên đường.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string email = tbEmail.Text;
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email không hợp lệ! Email phải kết thúc bằng '@gmail.com'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string khuVuc = cbKV.Text;
            if (string.IsNullOrEmpty(khuVuc))
            {
                MessageBox.Show("Vui lòng chọn khu vực!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem dữ liệu đã tồn tại trong bảng chưa
            //if (IsDataAlreadyExists(name, sdt, email, khuVuc, diachi))
            //{
            //    MessageBox.Show("Dữ liệu đã tồn tại trong bảng. Vui lòng kiểm tra lại thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // If all required fields are filled and meet the criteria, proceed with adding the supplier
            NhaCungCapBEL supplier = new NhaCungCapBEL();
            supplier.id = ma;
            supplier.Ten = name;
            supplier.sdt = sdt;
            supplier.Diachi = diachi;
            supplier.email = email;
            supplier.KhuVuc = khuVuc;

            cusBAL1.NewNhaCungCap(supplier);
            dataGridView.Rows.Add(supplier.id, supplier.Ten, supplier.sdt, supplier.Diachi, supplier.email, supplier.KhuVuc);

            MessageBox.Show("Nhà cung cấp đã được thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Clear input fields after adding
            ClearInputFields();
        }

        private bool IsDataAlreadyExists(string name, string sdt, string email, string khuVuc, string diachi)
        {
            List<NhaCungCapBEL> suppliers = cusBAL1.ReadNhaCungCap();

            foreach (NhaCungCapBEL supplier in suppliers)
            {
                if (supplier.Ten == name && supplier.sdt == sdt && supplier.email == email && supplier.KhuVuc == khuVuc && supplier.Diachi == diachi)
                {
                    return true; // Data already exists
                }
            }

            return false;
        }


        private bool IsIdAlreadyExists(int ma)
        {
            List<NhaCungCapBEL> suppliers = cusBAL1.ReadNhaCungCap();

            foreach (NhaCungCapBEL supplier in suppliers)
            {
                if (supplier.id == ma)
                {
                    return true; // ID already exists
                }
            }

            return false;
        }

        private void CustomerGUi_Load(object sender, EventArgs e)
        {
            List<NhaCungCapBEL> suppliers = cusBAL1.ReadNhaCungCap();

            dataGridView.Rows.Clear();

            foreach (NhaCungCapBEL supplier in suppliers)
            {
                dataGridView.Rows.Add(supplier.id, supplier.Ten, supplier.sdt, supplier.Diachi, supplier.email, supplier.KhuVuc);
            }
            //dataGridView.SelectionChanged += dgvCustomerGUI_SelectionChanged;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            List<NhaCungCapBEL> suppliers = cusBAL1.ReadNhaCungCap();

            dataGridView.Rows.Clear();

            foreach (NhaCungCapBEL supplier in suppliers)
            {
                dataGridView.Rows.Add(supplier.id, supplier.Ten, supplier.sdt, supplier.Diachi, supplier.email, supplier.KhuVuc);
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                if (selectedRow.Cells[0].Value != null)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string name = selectedRow.Cells[1].Value.ToString();
                    string sdt = selectedRow.Cells[2].Value.ToString();
                    string diachi = selectedRow.Cells[3].Value.ToString();
                    string email = selectedRow.Cells[4].Value.ToString();
                    string khuVuc = selectedRow.Cells[5].Value.ToString();

                    tbMa.Text = id;
                    tbName.Text = name;
                    tbSDT.Text = sdt;
                    tbDC.Text = diachi;
                    tbEmail.Text = email;
                    cbKV.Text = khuVuc;
                }
                else
                {
                    ClearInputFields(); // Call your ClearInputFields method to clear the input fields
                }
            }
        }

        //private void dgvCustomerGUI_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView.SelectedRows.Count > 0 && dataGridView.SelectedRows[0].IsNewRow) // Make sure only one row is selected
        //    {
        //        //DataGridViewRow selectedRow = dgvCustomerGUI.SelectedRows[0];
        //        ClearInputFields();
        //        string id = dataGridView.SelectedCells[0].Value.ToString();
        //        string name = dataGridView.SelectedCells[1].Value.ToString();
        //        string sdt = dataGridView.SelectedCells[2].Value.ToString();
        //        string diachi = dataGridView.SelectedCells[3].Value.ToString();
        //        string email = dataGridView.SelectedCells[4].Value.ToString();
        //        string khuVuc = dataGridView.SelectedCells[5].Value.ToString();

        //        tbMa.Text = id;
        //        tbName.Text = name;
        //        tbSDT.Text = sdt;
        //        tbDC.Text = diachi;
        //        tbEmail.Text = email;
        //        cbKV.Text = khuVuc;
        //    }
        //}



        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

            int id = Convert.ToInt32(selectedRow.Cells[0].Value);

            // Check if the "Mã" field is empty
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NhaCungCapBEL supplier = new NhaCungCapBEL();
            supplier.id = id;

            // Kiểm tra nếu ID bị thay đổi
            if (id != Convert.ToInt32(tbMa.Text))
            {
                MessageBox.Show("Không thể thay đổi ID của nhà cung cấp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Cập nhật các trường khác ngoại trừ id
            supplier.Ten = tbName.Text;
            supplier.sdt = tbSDT.Text;
            supplier.Diachi = tbDC.Text;
            supplier.email = tbEmail.Text;
            supplier.KhuVuc = cbKV.Text;

            // Cập nhật thông tin nhà cung cấp trong cơ sở dữ liệu
            cusBAL1.EditNhaCungCap(supplier);

            // Cập nhật dữ liệu trên DataGridView
            List<NhaCungCapBEL> suppliers = cusBAL1.ReadNhaCungCap();

            dataGridView.Rows.Clear();

            foreach (NhaCungCapBEL cus in suppliers)
            {
                dataGridView.Rows.Add(cus.id, cus.Ten, cus.sdt, cus.Diachi, cus.email, cus.KhuVuc);
            }

            MessageBox.Show("Nhà cung cấp đã được cập nhật!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa nội dung trong các trường sau khi sửa
            ClearInputFields();
        }




        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);


                // Call your delete method from the BAL class using the selected ID
                // If all required fields are filled, proceed with adding the supplier
                NhaCungCapBEL supplier = new NhaCungCapBEL();
                supplier.id = id;

                cusBAL1.DeleteNhaCungCap(supplier);

                dataGridView.Rows.Remove(selectedRow);

                MessageBox.Show("Nhà cung cấp đã được xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after deleting
                ClearInputFields();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                string id = dataGridView.SelectedCells[0].Value.ToString();
                string name = dataGridView.SelectedCells[1].Value.ToString();
                string sdt = dataGridView.SelectedCells[2].Value.ToString();
                string diachi = dataGridView.SelectedCells[3].Value.ToString();
                string email = dataGridView.SelectedCells[4].Value.ToString();
                string khuVuc = dataGridView.SelectedCells[5].Value.ToString();

                tbMa.Text = id;
                tbName.Text = name;
                tbSDT.Text = sdt;
                tbDC.Text = diachi;
                tbEmail.Text = email;
                cbKV.Text = khuVuc;
            }
            // Add an empty row to the DataGridView
            dataGridView.Rows.Add();

        }

        private void tbDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDC_Click(object sender, EventArgs e)
        {

        }

        private void tbMa_TextChanged(object sender, EventArgs e)
        {

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
    }
}
