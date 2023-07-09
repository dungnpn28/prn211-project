namespace ShopManagementSystem
{
    partial class frmBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchBillId = new System.Windows.Forms.Button();
            this.cboSearchBillId = new System.Windows.Forms.ComboBox();
            this.lbSearchBillId = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCustomerId = new System.Windows.Forms.ComboBox();
            this.cboEmployeeId = new System.Windows.Forms.ComboBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeeId = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbBillId = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboProductId = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtSinglePrice = new System.Windows.Forms.TextBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchBillId);
            this.panel1.Controls.Add(this.cboSearchBillId);
            this.panel1.Controls.Add(this.lbSearchBillId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchBillId
            // 
            this.btnSearchBillId.Location = new System.Drawing.Point(397, 17);
            this.btnSearchBillId.Name = "btnSearchBillId";
            this.btnSearchBillId.Size = new System.Drawing.Size(147, 26);
            this.btnSearchBillId.TabIndex = 2;
            this.btnSearchBillId.Text = "Search";
            this.btnSearchBillId.UseVisualStyleBackColor = true;
            this.btnSearchBillId.Click += new System.EventHandler(this.btnSearchBillId_Click);
            // 
            // cboSearchBillId
            // 
            this.cboSearchBillId.FormattingEnabled = true;
            this.cboSearchBillId.Location = new System.Drawing.Point(81, 17);
            this.cboSearchBillId.Name = "cboSearchBillId";
            this.cboSearchBillId.Size = new System.Drawing.Size(267, 24);
            this.cboSearchBillId.TabIndex = 1;
            this.cboSearchBillId.DropDown += new System.EventHandler(this.cboSearchBillId_DropDown);
            // 
            // lbSearchBillId
            // 
            this.lbSearchBillId.AutoSize = true;
            this.lbSearchBillId.Location = new System.Drawing.Point(12, 20);
            this.lbSearchBillId.Name = "lbSearchBillId";
            this.lbSearchBillId.Size = new System.Drawing.Size(44, 16);
            this.lbSearchBillId.TabIndex = 0;
            this.lbSearchBillId.Text = "Bill ID:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lbBill);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(880, 577);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCustomerId);
            this.groupBox1.Controls.Add(this.cboEmployeeId);
            this.groupBox1.Controls.Add(this.mskPhone);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.lbCustomerName);
            this.groupBox1.Controls.Add(this.lbCustomerId);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.txtBillId);
            this.groupBox1.Controls.Add(this.lbEmployeeName);
            this.groupBox1.Controls.Add(this.lbEmployeeId);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.lbBillId);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // cboCustomerId
            // 
            this.cboCustomerId.FormattingEnabled = true;
            this.cboCustomerId.Location = new System.Drawing.Point(581, 24);
            this.cboCustomerId.Name = "cboCustomerId";
            this.cboCustomerId.Size = new System.Drawing.Size(245, 24);
            this.cboCustomerId.TabIndex = 19;
            this.cboCustomerId.TextChanged += new System.EventHandler(this.cboCustomerId_TextChanged);
            // 
            // cboEmployeeId
            // 
            this.cboEmployeeId.FormattingEnabled = true;
            this.cboEmployeeId.Location = new System.Drawing.Point(152, 83);
            this.cboEmployeeId.Name = "cboEmployeeId";
            this.cboEmployeeId.Size = new System.Drawing.Size(219, 24);
            this.cboEmployeeId.TabIndex = 18;
            this.cboEmployeeId.TextChanged += new System.EventHandler(this.cboEmployeeId_TextChanged);
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(581, 114);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(245, 22);
            this.mskPhone.TabIndex = 17;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(152, 52);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 22);
            this.dtpDate.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(581, 83);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 22);
            this.txtAddress.TabIndex = 14;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(581, 53);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerName.TabIndex = 13;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(458, 117);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(49, 16);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "Phone:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(458, 87);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(61, 16);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Address:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(458, 57);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(107, 16);
            this.lbCustomerName.TabIndex = 9;
            this.lbCustomerName.Text = "Customer Name:";
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(458, 27);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(83, 16);
            this.lbCustomerId.TabIndex = 8;
            this.lbCustomerId.Text = "Customer ID:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(152, 114);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(152, 24);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(219, 22);
            this.txtBillId.TabIndex = 4;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(17, 117);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(112, 16);
            this.lbEmployeeName.TabIndex = 3;
            this.lbEmployeeName.Text = "Employee Name:";
            // 
            // lbEmployeeId
            // 
            this.lbEmployeeId.AutoSize = true;
            this.lbEmployeeId.Location = new System.Drawing.Point(17, 87);
            this.lbEmployeeId.Name = "lbEmployeeId";
            this.lbEmployeeId.Size = new System.Drawing.Size(88, 16);
            this.lbEmployeeId.TabIndex = 2;
            this.lbEmployeeId.Text = "Employee ID:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(17, 57);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(39, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date:";
            // 
            // lbBillId
            // 
            this.lbBillId.AutoSize = true;
            this.lbBillId.Location = new System.Drawing.Point(17, 27);
            this.lbBillId.Name = "lbBillId";
            this.lbBillId.Size = new System.Drawing.Size(44, 16);
            this.lbBillId.TabIndex = 0;
            this.lbBillId.Text = "Bill ID:";
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.Location = new System.Drawing.Point(415, 9);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(51, 29);
            this.lbBill.TabIndex = 0;
            this.lbBill.Text = "Bill";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBillDetails);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(15, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 354);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Details";
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetails.Location = new System.Drawing.Point(3, 79);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.RowHeadersWidth = 51;
            this.dgvBillDetails.RowTemplate.Height = 24;
            this.dgvBillDetails.Size = new System.Drawing.Size(847, 191);
            this.dgvBillDetails.TabIndex = 2;
            this.dgvBillDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetails_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 81);
            this.panel3.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(610, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(173, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(547, 7);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(41, 16);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Total:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(708, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(547, 46);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Bill";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Bill";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(14, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Double click to delete!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboProductId);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.txtSinglePrice);
            this.panel2.Controls.Add(this.txtSale);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 61);
            this.panel2.TabIndex = 0;
            // 
            // cboProductId
            // 
            this.cboProductId.FormattingEnabled = true;
            this.cboProductId.Location = new System.Drawing.Point(93, 6);
            this.cboProductId.Name = "cboProductId";
            this.cboProductId.Size = new System.Drawing.Size(186, 24);
            this.cboProductId.TabIndex = 18;
            this.cboProductId.TextChanged += new System.EventHandler(this.cboProductId_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(654, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(169, 22);
            this.txtAmount.TabIndex = 17;
            // 
            // txtSinglePrice
            // 
            this.txtSinglePrice.Location = new System.Drawing.Point(654, 9);
            this.txtSinglePrice.Name = "txtSinglePrice";
            this.txtSinglePrice.Size = new System.Drawing.Size(169, 22);
            this.txtSinglePrice.TabIndex = 16;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(388, 35);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(172, 22);
            this.txtSale.TabIndex = 15;
            this.txtSale.TextChanged += new System.EventHandler(this.txtSale_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(388, 9);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(172, 22);
            this.txtProductName.TabIndex = 14;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(93, 33);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(186, 22);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Single Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sale(%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product ID:";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 630);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBill_FormClosing);
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchBillId;
        private System.Windows.Forms.ComboBox cboSearchBillId;
        private System.Windows.Forms.Label lbSearchBillId;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbBillId;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        public System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCustomerId;
        private System.Windows.Forms.ComboBox cboEmployeeId;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProductId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtSinglePrice;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
    }
}