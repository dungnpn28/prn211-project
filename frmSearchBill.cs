using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopManagementSystem.Class;

namespace ShopManagementSystem
{
    public partial class frmSearchBill : Form
    {
        DataTable tblBill;
        public frmSearchBill()
        {
            InitializeComponent();
        }

        private void frmSearchBill_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvSearchBill.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtBillId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtBillId.Text == "") && (txtMonth.Text == "") && (txtYear.Text == "") &&
               (txtEmployeeId.Text == "") && (txtCustomerId.Text == "") &&
               (txtAmount.Text == ""))
            {
                MessageBox.Show("Input at least 1 condition!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM Bill WHERE 1=1";
            if (txtBillId.Text != "")
                sql = sql + " AND Id Like N'%" + txtBillId.Text + "%'";
            if (txtMonth.Text != "")
                sql = sql + " AND MONTH(Created) =" + txtMonth.Text;
            if (txtYear.Text != "")
                sql = sql + " AND YEAR(Created) =" + txtYear.Text;
            if (txtEmployeeId.Text != "")
                sql = sql + " AND EmployeeId Like N'%" + txtEmployeeId.Text + "%'";
            if (txtCustomerId.Text != "")
                sql = sql + " AND CustomerId Like N'%" + txtCustomerId.Text + "%'";
            if (txtAmount.Text != "")
                sql = sql + " AND Total <=" + txtAmount.Text;
            tblBill = Functions.GetDataToTable(sql);
            if (tblBill.Rows.Count == 0)
            {
                MessageBox.Show("No Records Found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(tblBill.Rows.Count + " Records Found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSearchBill.DataSource = tblBill;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvSearchBill.Columns[0].HeaderText = "Bill ID";
            dgvSearchBill.Columns[1].HeaderText = "Employee ID";
            dgvSearchBill.Columns[2].HeaderText = "Date";
            dgvSearchBill.Columns[3].HeaderText = "Customer ID";
            dgvSearchBill.Columns[4].HeaderText = "Total";
            dgvSearchBill.Columns[0].Width = 150;
            dgvSearchBill.Columns[1].Width = 100;
            dgvSearchBill.Columns[2].Width = 80;
            dgvSearchBill.Columns[3].Width = 80;
            dgvSearchBill.Columns[4].Width = 80;
            dgvSearchBill.AllowUserToAddRows = false;
            dgvSearchBill.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvSearchBill.DataSource = null;
        }

        private void dgvSearchBill_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd;
            if (MessageBox.Show("You Want To Show Bill Details?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgvSearchBill.CurrentRow.Cells["Id"].Value.ToString();
                frmBill frm = new frmBill();
                frm.txtBillId.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
