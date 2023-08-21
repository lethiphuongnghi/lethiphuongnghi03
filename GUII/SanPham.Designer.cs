namespace QLBH_VoThiKimMen.GUII
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRead = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKC = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lbquantity_in_stock = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbten = new System.Windows.Forms.Label();
            this.lbma = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(177, 696);
            this.btRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(135, 46);
            this.btRead.TabIndex = 19;
            this.btRead.Text = "Đọc ";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(345, 696);
            this.btNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(122, 46);
            this.btNew.TabIndex = 20;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(500, 696);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(122, 46);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(650, 696);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(122, 46);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(800, 696);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(122, 46);
            this.btExit.TabIndex = 23;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvsp
            // 
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colName,
            this.colPrice,
            this.colQuantityInStock,
            this.colImage,
            this.ColKC});
            this.dgvsp.Location = new System.Drawing.Point(12, 401);
            this.dgvsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidth = 51;
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(990, 258);
            this.dgvsp.TabIndex = 24;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick_1);
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "Mã";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.HeaderText = "Số lượng";
            this.colQuantityInStock.MinimumWidth = 6;
            this.colQuantityInStock.Name = "colQuantityInStock";
            this.colQuantityInStock.Width = 125;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.Width = 125;
            // 
            // ColKC
            // 
            this.ColKC.HeaderText = "Kích Cỡ";
            this.ColKC.MinimumWidth = 6;
            this.ColKC.Name = "ColKC";
            this.ColKC.Width = 125;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(223, 368);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(520, 26);
            this.txtTK.TabIndex = 52;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(60, 374);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(150, 20);
            this.lbTK.TabIndex = 51;
            this.lbTK.Text = "Tìm Kiếm Sản phẩm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 50;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kích Cỡ";
            // 
            // cbKC
            // 
            this.cbKC.FormattingEnabled = true;
            this.cbKC.Items.AddRange(new object[] {
            "X",
            "S",
            "M",
            "Xl"});
            this.cbKC.Location = new System.Drawing.Point(178, 303);
            this.cbKC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKC.Name = "cbKC";
            this.cbKC.Size = new System.Drawing.Size(136, 28);
            this.cbKC.TabIndex = 48;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(541, 75);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(219, 199);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 47;
            this.pictureBox.TabStop = false;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(601, 302);
            this.btFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(99, 41);
            this.btFile.TabIndex = 46;
            this.btFile.Text = "Chọn Ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(178, 239);
            this.tbSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(260, 26);
            this.tbSL.TabIndex = 45;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(178, 183);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(260, 26);
            this.txtGia.TabIndex = 44;
            // 
            // lbquantity_in_stock
            // 
            this.lbquantity_in_stock.AutoSize = true;
            this.lbquantity_in_stock.Location = new System.Drawing.Point(81, 245);
            this.lbquantity_in_stock.Name = "lbquantity_in_stock";
            this.lbquantity_in_stock.Size = new System.Drawing.Size(72, 20);
            this.lbquantity_in_stock.TabIndex = 43;
            this.lbquantity_in_stock.Text = "Số lượng";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(84, 183);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 20);
            this.lbPrice.TabIndex = 42;
            this.lbPrice.Text = "Giá";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(178, 117);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 26);
            this.tbName.TabIndex = 41;
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(84, 117);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(36, 20);
            this.lbten.TabIndex = 40;
            this.lbten.Text = "Tên";
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(84, 53);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(31, 20);
            this.lbma.TabIndex = 39;
            this.lbma.Text = "Mã";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(178, 53);
            this.tbMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(260, 26);
            this.tbMa.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKC);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lbquantity_in_stock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btRead);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SanPham";
            this.Text = "TC_Dat_Hang";
            this.Load += new System.EventHandler(this.gd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvsp_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKC;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKC;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbquantity_in_stock;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label1;
    }
}