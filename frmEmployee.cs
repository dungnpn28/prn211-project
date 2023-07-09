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
    public partial class frmEmployee : Form
    {
        DataTable tblEmployee;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT Id,Name,Gender,Address,Phone,Dob From Employee";
            tblEmployee = Functions.GetDataToTable(sql); 
            dgvEmployee.DataSource = tblEmployee;
            dgvEmployee.Columns[0].HeaderText = "Employee ID";
            dgvEmployee.Columns[1].HeaderText = "Employee Name";
            dgvEmployee.Columns[2].HeaderText = "Gender";
            dgvEmployee.Columns[3].HeaderText = "Address";
            dgvEmployee.Columns[4].HeaderText = "Phone";
            dgvEmployee.Columns[5].HeaderText = "DOB";
            dgvEmployee.Columns[0].Width = 100;
            dgvEmployee.Columns[1].Width = 150;
            dgvEmployee.Columns[2].Width = 100;
            dgvEmployee.Columns[3].Width = 150;
            dgvEmployee.Columns[4].Width = 100;
            dgvEmployee.Columns[5].Width = 100;
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Curently in Add Mode!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeId.Focus();
                return;
            }
            if (tblEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtEmployeeId.Text = dgvEmployee.CurrentRow.Cells["Id"].Value.ToString();
            txtEmployeeName.Text = dgvEmployee.CurrentRow.Cells["Name"].Value.ToString();
            if (dgvEmployee.CurrentRow.Cells["Gender"].Value.ToString() == "True") chkGender.Checked = true;
            else chkGender.Checked = false;
            txtAddress.Text = dgvEmployee.CurrentRow.Cells["Address"].Value.ToString();
            mskPhone.Text = dgvEmployee.CurrentRow.Cells["Phone"].Value.ToString();
            txtDob.Text = dgvEmployee.CurrentRow.Cells["Dob"].Value.ToString();
            btnModify.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDel.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            ResetValues();
            txtEmployeeId.Enabled = true;
            txtEmployeeId.Focus();
        }

        private void ResetValues()
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            chkGender.Checked = false;
            txtAddress.Text = "";
            txtDob.Text = "";
            mskPhone.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtEmployeeId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Employee ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeId.Focus();
                return;
            }
            if (txtEmployeeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Employee Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (mskPhone.Text == "(   )     -")
            {
                MessageBox.Show("Input Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskPhone.Focus();
                return;
            }
            if (txtDob.Text == "")
            {
                MessageBox.Show("Input Date of Birth!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDob.Focus();
                return;
            }
            if (chkGender.Checked == true)
                gt = "True";
            else
                gt = "False";
            sql = "SELECT Id FROM Employee WHERE Id=N'" + txtEmployeeId.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("ID Existed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeId.Focus();
                txtEmployeeId.Text = "";
                return;
            }
            sql = "INSERT INTO Employee(Id,Name,Gender, Address,Phone, Dob) VALUES (N'" + txtEmployeeId.Text.Trim() + "',N'" + txtEmployeeName.Text.Trim() + "',N'" + gt + "',N'" + txtAddress.Text.Trim() + "','" + mskPhone.Text + "','" + txtDob.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnDel.Enabled = true;
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtEmployeeId.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtEmployeeId.Text == "")
            {
                MessageBox.Show("Pick a Employee!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtEmployeeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Employee Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (mskPhone.Text == "(   )     -")
            {
                MessageBox.Show("Input Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskPhone.Focus();
                return;
            }
            if (txtDob.Text == "")
            {
                MessageBox.Show("Input DOB!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDob.Focus();
                return;
            }
            if (chkGender.Checked == true)
                gt = "True";
            else
                gt = "False";
            sql = "UPDATE Employee SET Name=N'" + txtEmployeeName.Text.Trim().ToString() +
                    "',Address=N'" + txtAddress.Text.Trim().ToString() +
                    "',Phone='" + mskPhone.Text.ToString() + "',Gender=N'" + gt +
                    "',Dob='" + txtDob.Text +
                    "' WHERE Id=N'" + txtEmployeeId.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtEmployeeId.Text == "")
            {
                MessageBox.Show("Pick a Employee!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("You Sure You Want To Delete This?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Employee WHERE Id=N'" + txtEmployeeId.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSkip.Enabled = false;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            txtEmployeeId.Enabled = false;  
        }
    }
}
