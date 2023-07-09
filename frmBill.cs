using ShopManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class frmBill : Form
    {
        DataTable tblBill;
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            cboCustomerId.TextChanged -= cboCustomerId_TextChanged;
            cboEmployeeId.TextChanged -= cboEmployeeId_TextChanged;
            cboProductId.TextChanged -= cboProductId_TextChanged;
            txtQuantity.TextChanged -= txtQuantity_TextChanged;
            txtSale.TextChanged -= txtSale_TextChanged;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnExport.Enabled = false;
            txtBillId.ReadOnly = true;
            txtEmployeeName.ReadOnly = true;
            txtCustomerName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            mskPhone.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtSinglePrice.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtSale.Text = "0";
            txtTotal.Text = "0";
            Functions.FillCombo("SELECT Id, Name FROM Customer", cboCustomerId, "Id", "Id");
            cboCustomerId.SelectedIndex = -1;
            Functions.FillCombo("SELECT Id, Name FROM Employee", cboEmployeeId, "Id", "TenKhach");
            cboEmployeeId.SelectedIndex = -1;
            Functions.FillCombo("SELECT Id, Name FROM Product", cboProductId, "Id", "Id");
            cboProductId.SelectedIndex = -1;
            Functions.FillCombo("SELECT Id FROM Bill", cboSearchBillId, "Id", "Id");
            cboSearchBillId.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtBillId.Text != "")
            {
                LoadInfoHoaDon();
                btnCancel.Enabled = true;
                btnExport.Enabled = true;
            }
            LoadDataGridView();
            cboCustomerId.TextChanged += cboCustomerId_TextChanged;
            cboEmployeeId.TextChanged += cboEmployeeId_TextChanged;
            cboProductId.TextChanged += cboProductId_TextChanged;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtSale.TextChanged += txtSale_TextChanged;

        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.ProductId, b.Name, a.Quantity, b.Price, a.Sale,a.Amount FROM BillDetails AS a, Product AS b WHERE a.BillId = N'" + txtBillId.Text + "' AND a.ProductId=b.Id";
            tblBill = Functions.GetDataToTable(sql);
            dgvBillDetails.DataSource = tblBill;
            dgvBillDetails.Columns[0].HeaderText = "Product ID";
            dgvBillDetails.Columns[1].HeaderText = "Product Name";
            dgvBillDetails.Columns[2].HeaderText = "Quantity";
            dgvBillDetails.Columns[3].HeaderText = "Single Price";
            dgvBillDetails.Columns[4].HeaderText = "Sale";
            dgvBillDetails.Columns[5].HeaderText = "Amount";
            dgvBillDetails.Columns[0].Width = 80;
            dgvBillDetails.Columns[1].Width = 130;
            dgvBillDetails.Columns[2].Width = 80;
            dgvBillDetails.Columns[3].Width = 90;
            dgvBillDetails.Columns[4].Width = 90;
            dgvBillDetails.Columns[5].Width = 90;
            dgvBillDetails.AllowUserToAddRows = false;
            dgvBillDetails.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT Created FROM Bill WHERE Id = N'" + txtBillId.Text + "'";
            dtpDate.Text = Functions.GetFieldValues(str);
            str = "SELECT EmployeeId FROM Bill WHERE Id = N'" + txtBillId.Text + "'";
            cboEmployeeId.Text = Functions.GetFieldValues(str);
            str = "SELECT CustomerId FROM Bill WHERE Id = N'" + txtBillId.Text + "'";
            cboCustomerId.Text = Functions.GetFieldValues(str);
            str = "SELECT Total FROM Bill WHERE Id = N'" + txtBillId.Text + "'";
            txtTotal.Text = Functions.GetFieldValues(str);
            
        }

        private void btnSearchBillId_Click(object sender, EventArgs e)
        {
            if (cboSearchBillId.Text == "")
            {
                MessageBox.Show("Input Bill ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSearchBillId.Focus();
                return;
            }
            txtBillId.Text = cboSearchBillId.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnExport.Enabled = true;
            cboSearchBillId.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetValues()
        {
            txtBillId.Text = "";
            dtpDate.Text = DateTime.Now.ToShortDateString();
            cboEmployeeId.Text = "";
            cboCustomerId.Text = "";
            txtTotal.Text = "0";
            cboProductId.Text = "";
            txtQuantity.Text = "";
            txtSale.Text = "0";
            txtAmount.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
            btnExport.Enabled = false;
            btnAdd.Enabled = false;
            ResetValues();
            txtBillId.Text = Functions.CreateKey();
            LoadDataGridView(); 
        }

        

        private void ResetValuesHang()
        {
            cboProductId.Text = "";
            txtQuantity.Text = "";
            txtSale.Text = "0";
            txtAmount.Text = "0";
        }

        private void cboCustomerId_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboCustomerId.Text == "")
            {
                txtCustomerName.Text = "";
                txtAddress.Text = "";
                mskPhone.Text = "";
            }
            str = "Select Name from Customer where Id = " + cboCustomerId.SelectedValue ;
            txtCustomerName.Text = Functions.GetFieldValues(str);
            str = "Select Address from Customer where Id = " + cboCustomerId.SelectedValue ;
            txtAddress.Text = Functions.GetFieldValues(str);
            str = "Select Phone from Customer where Id = " + cboCustomerId.SelectedValue ;
            mskPhone.Text = Functions.GetFieldValues(str);
        }

        private void cboEmployeeId_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboEmployeeId.Text == "")
                txtEmployeeName.Text = "";
            str = "Select Name from Employee where Id =N'" + cboEmployeeId.SelectedValue + "'";
            txtEmployeeName.Text = Functions.GetFieldValues(str);
        }

        private void cboProductId_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboProductId.Text == "")
            {
                txtProductName.Text = "";
                txtSinglePrice.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT Name FROM Product WHERE Id =N'" + cboProductId.SelectedValue + "'";
            txtProductName.Text = Functions.GetFieldValues(str);
            str = "SELECT Price FROM Product WHERE Id =N'" + cboProductId.SelectedValue + "'";
            txtSinglePrice.Text = Functions.GetFieldValues(str);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtQuantity.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtQuantity.Text);
            if (txtSale.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtSale.Text);
            if (txtSinglePrice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtSinglePrice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtAmount.Text = tt.ToString();
        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtQuantity.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtQuantity.Text);
            if (txtSale.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtSale.Text);
            if (txtSinglePrice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtSinglePrice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtAmount.Text = tt.ToString();
        }

        private void cboSearchBillId_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT Id FROM Bill", cboSearchBillId, "Id", "Id");
            cboSearchBillId.SelectedIndex = -1;
        }

        private void frmBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT Id FROM Bill WHERE Id=N'" + txtBillId.Text + "'";

            if (!Functions.CheckKey(sql))
            {
                if (dtpDate.Text.Length == 0)
                {
                    MessageBox.Show("Input Date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpDate.Focus();
                    return;
                }
                if (cboEmployeeId.Text.Length == 0)
                {
                    MessageBox.Show("Input Employee ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboEmployeeId.Focus();
                    return;
                }
                if (cboCustomerId.Text.Length == 0)
                {
                    MessageBox.Show("Input Customer ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCustomerId.Focus();
                    return;
                }
                sql = $@"INSERT INTO Bill(Id, Created, EmployeeId, CustomerId, Total)
                  VALUES ('{txtBillId.Text.Trim()}', '{dtpDate.Text.Trim()}', 
                          {cboEmployeeId.SelectedValue}, {cboCustomerId.SelectedValue}, 
                          {txtTotal.Text})";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cboProductId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Product ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboProductId.Focus();
                return;
            }
            if ((txtQuantity.Text.Trim().Length == 0) || (txtQuantity.Text == "0"))
            {
                MessageBox.Show("Input Quantity!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Text = "";
                txtQuantity.Focus();
                return;
            }
            if (txtSale.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Sale", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSale.Focus();
                return;
            }
            sql = "SELECT ProductId FROM BillDetails WHERE ProductId=N'" + cboProductId.SelectedValue + "' AND BillId = N'" + txtBillId.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("ProductID Existed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboProductId.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Quantity FROM Product WHERE Id = N'" + cboProductId.SelectedValue + "'"));
            if (Convert.ToDouble(txtQuantity.Text) > sl)
            {
                MessageBox.Show("Product's current quantity: " + sl, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Text = "";
                txtQuantity.Focus();
                return;
            }
            sql = "INSERT INTO BillDetails(BillId, ProductId, Quantity, SinglePrice, Sale, Amount) VALUES('"
                + txtBillId.Text.Trim() + "',"
                + cboProductId.SelectedValue + ","
                + txtQuantity.Text + ","
                + txtSinglePrice.Text
                + "," + txtSale.Text + ","
                + txtAmount.Text + ")";
            Functions.RunSQL(sql);
            Console.WriteLine("2");
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtQuantity.Text);
            sql = "UPDATE Product SET Quantity =" + SLcon + " WHERE Id= N'" + cboProductId.SelectedValue + "'";
            Functions.RunSQL(sql);
            Console.WriteLine("3");
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Total FROM Bill WHERE Id = N'" + txtBillId.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtAmount.Text);
            sql = "UPDATE Bill SET Total =" + Tongmoi + " WHERE Id = N'" + txtBillId.Text + "'";
            Functions.RunSQL(sql);
            Console.WriteLine("4");
            txtTotal.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnCancel.Enabled = true;
            btnAdd.Enabled = true;
            btnExport.Enabled = true;
        }

        private void dgvBillDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblBill.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("You Sure You Want To Delete This?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                MaHangxoa = dgvBillDetails.CurrentRow.Cells["ProductId"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvBillDetails.CurrentRow.Cells["Quantity"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvBillDetails.CurrentRow.Cells["Amount"].Value.ToString());
                sql = "DELETE BillDetails WHERE BillId=N'" + txtBillId.Text + "' AND ProductId = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Quantity FROM Product WHERE Id = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE Product SET Quantity =" + slcon + " WHERE Id= N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Total FROM Bill WHERE Id = N'" + txtBillId.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE Bill SET Total =" + tongmoi + " WHERE Id = N'" + txtBillId.Text + "'";
                Functions.RunSQL(sql);
                txtTotal.Text = tongmoi.ToString();
                LoadDataGridView();
            }
        }
    }
}
